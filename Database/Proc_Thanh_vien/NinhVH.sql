set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--PR_select_bao_cao_lai
CREATE PROCEDURE [dbo].[pr_GD_LICH_THANH_TOAN_LAI_GOC_select_in_times]
@ID_TRAI_PHIEU numeric(18, 0),
@NGAY_BAT_DAU DATETIME,
@NGAY_KET_THUC DATETIME
AS
BEGIN
	-- Khai báo biến lưu lãi suất thỏa thuận
	DECLARE @id_lai_suat_tt INT
	DECLARE @ngay_bat_dau_ls_tt DATETIME
	DECLARE @ngay_ket_thuc_ls_tt DATETIME
	DECLARE @lai_suat_tt NUMERIC(21,3)
	DECLARE @ghi_chu_ls_tt NVARCHAR(250)
	-- Khai báo biến lưu lái suất cập nhật
	DECLARE @id_lai_suat_cn INT
	DECLARE @ngay_bat_dau_ls_cn DATETIME
	DECLARE @ngay_ket_thuc_ls_cn DATETIME
	DECLARE @lai_suat_cn NUMERIC(21,3)
	DECLARE @ghi_chu_ls_cn NVARCHAR(250)	
	-- Khai báo bảng dữ liệu cuối cùng
	DECLARE @table_result TABLE (
	ID INT,
	NGAY_DAU DATETIME,
	NGAY_KET_THUC DATETIME,	
	LAI_SUAT NUMERIC(21,3),	
	GHI_CHU NVARCHAR(250))
	
	DECLARE @table_item TABLE (
	ID INT,
	NGAY_DAU DATETIME,
	NGAY_KET_THUC DATETIME,	
	LAI_SUAT NUMERIC(21,3),	
	GHI_CHU NVARCHAR(250))
	
	--Chèn dữ liệu là những giao dịch cập nhật lái suât có ngày bắt đầu trong khoản (ngay_dau, ngay_ket_thuc)
	INSERT INTO @table_item(ID,NGAY_DAU,NGAY_KET_THUC,LAI_SUAT, GHI_CHU)
	SELECT ID
	, NGAY_BAT_DAU_AD_LS AS NGAY_DAU
	, dbo.f_get_ngay_ket_thuc_ls(@ID_TRAI_PHIEU, NGAY_BAT_DAU_AD_LS) AS NGAY_KET_THUC
	, LAI_SUAT
	, GHI_CHU
	FROM [dbo].[GD_LICH_THANH_TOAN_LAI_GOC]
	WHERE ID_TRAI_PHIEU = @ID_TRAI_PHIEU
	AND CAP_NHAT_LS_YN = 'Y'
	AND DA_THUC_HIEN_YN = 'Y'
	AND DA_DUYET_YN = 'Y'
	AND NGAY_BAT_DAU_AD_LS > @NGAY_BAT_DAU
	AND NGAY_BAT_DAU_AD_LS < @NGAY_KET_THUC
	  	
	--Chèn dữ liệu là giao dịch cập nhật lái suât có ngày bắt đầu sát NGAY_DAU nhất
	INSERT INTO @table_item(ID,NGAY_DAU,NGAY_KET_THUC,LAI_SUAT, GHI_CHU)
	SELECT TOP 1 ID
	, glttlg.NGAY_BAT_DAU_AD_LS AS NGAY_DAU
	, dbo.f_get_ngay_ket_thuc_ls(@ID_TRAI_PHIEU, NGAY_BAT_DAU_AD_LS) AS NGAY_KET_THUC
	, LAI_SUAT
	, GHI_CHU
	FROM GD_LICH_THANH_TOAN_LAI_GOC glttlg
	WHERE glttlg.ID_TRAI_PHIEU = @ID_TRAI_PHIEU
	AND CAP_NHAT_LS_YN = 'Y'
	AND DA_THUC_HIEN_YN = 'Y'
	AND DA_DUYET_YN = 'Y'
	AND NGAY_BAT_DAU_AD_LS < @NGAY_BAT_DAU	
	ORDER BY glttlg.NGAY_BAT_DAU_AD_LS ASC
	
	--Update lại ngày cho những khoảng không thuộc thời gian đang xét
	UPDATE @table_item
	SET		
		NGAY_DAU = @NGAY_BAT_DAU
	WHERE NGAY_DAU < @NGAY_BAT_DAU
	
	UPDATE @table_item
	SET	
		NGAY_KET_THUC = @NGAY_KET_THUC
	WHERE NGAY_KET_THUC > @NGAY_KET_THUC	
	
	--Xem lại phần này cần thêm một @table_ls_thoa_thuan nữa select những dòng có ngày bắt đầu hoặc ngày kết thúc thuộc khoảng đang xét
	--Sử dụng 2 vòng for để cập nhật lại suất vào @table_result
	--Thay đổi những cái giao với ls_thoa_thuan
	--Xóa những cái nằm trong ls_thao_thuan
	DECLARE v_cur_ls_thoa_thuan CURSOR FOR
	SELECT ID
	, NGAY_BAT_DAU_AD_LS AS NGAY_DAU
	, DATEADD(DAY,1,glttls.NGAY_KET_THUC_AD_LS) AS NGAY_KET_THUC
	, LAI_SUAT
	, GHI_CHU
	FROM [dbo].[GD_LICH_THANH_TOAN_LAI_GOC] glttls
	WHERE ID_TRAI_PHIEU = @ID_TRAI_PHIEU
	AND LAI_SUAT_THOA_THUAN_YN = 'Y'
	AND DA_THUC_HIEN_YN = 'Y'
	AND DA_DUYET_YN = 'Y'
	AND ((NGAY_BAT_DAU_AD_LS > @NGAY_BAT_DAU AND NGAY_BAT_DAU_AD_LS < @NGAY_KET_THUC)
	OR (glttls.NGAY_KET_THUC_AD_LS >= @NGAY_BAT_DAU AND glttls.NGAY_KET_THUC_AD_LS < @NGAY_KET_THUC))
	
	OPEN v_cur_ls_thoa_thuan;
	FETCH NEXT FROM v_cur_ls_thoa_thuan 
	INTO @id_lai_suat_tt
		, @ngay_bat_dau_ls_tt
		, @ngay_ket_thuc_ls_tt
		, @lai_suat_tt
		, @ghi_chu_ls_tt
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @ngay_bat_dau_ls_tt < @NGAY_BAT_DAU
		BEGIN
			SET	@ngay_bat_dau_ls_tt = @NGAY_BAT_DAU
		END
		
		IF @ngay_ket_thuc_ls_tt > @NGAY_KET_THUC
		BEGIN
			SET @ngay_ket_thuc_ls_tt = @NGAY_KET_THUC
		END
		
		INSERT INTO @table_result
		(
			ID,
			NGAY_DAU,
			NGAY_KET_THUC,
			LAI_SUAT,
			GHI_CHU
		)
		VALUES
		(
			@id_lai_suat_tt, 
			@ngay_bat_dau_ls_tt,
			@ngay_ket_thuc_ls_tt,
			@lai_suat_tt, 
			@ghi_chu_ls_tt
		)	
		
		DECLARE v_cur_ls_cap_nhat CURSOR FOR
		SELECT * FROM @table_item
		
		OPEN v_cur_ls_cap_nhat;
		FETCH NEXT FROM v_cur_ls_cap_nhat 
		INTO @id_lai_suat_cn
			, @ngay_bat_dau_ls_cn
			, @ngay_ket_thuc_ls_cn
			, @lai_suat_cn
			, @ghi_chu_ls_cn
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF (@ngay_bat_dau_ls_tt < @ngay_bat_dau_ls_cn 
				AND @ngay_ket_thuc_ls_cn < @ngay_ket_thuc_ls_tt)
			BEGIN
				DELETE FROM @table_item WHERE ID = @id_lai_suat_cn
			END
			ELSE
			BEGIN
				IF (@ngay_bat_dau_ls_cn < @ngay_bat_dau_ls_tt 
					AND @ngay_bat_dau_ls_tt < @ngay_ket_thuc_ls_cn 
					AND @ngay_ket_thuc_ls_cn < @ngay_ket_thuc_ls_tt)
				BEGIN
					UPDATE @table_item
					SET
						NGAY_KET_THUC = @ngay_bat_dau_ls_tt					
					WHERE ID = @id_lai_suat_cn
				END
				ELSE
				BEGIN
					IF (@ngay_bat_dau_ls_tt < @ngay_bat_dau_ls_cn
						AND @ngay_bat_dau_ls_cn < @ngay_ket_thuc_ls_tt 
						AND @ngay_ket_thuc_ls_tt < @ngay_ket_thuc_ls_cn)
					BEGIN
						UPDATE @table_item
						SET							
							NGAY_DAU = @ngay_ket_thuc_ls_tt					
						WHERE ID = @id_lai_suat_cn
					END
					ELSE
					BEGIN
						IF (@ngay_bat_dau_ls_cn < @ngay_bat_dau_ls_tt
							AND @ngay_ket_thuc_ls_tt < @ngay_ket_thuc_ls_cn)
						BEGIN
							UPDATE @table_item
							SET
								NGAY_KET_THUC = @ngay_bat_dau_ls_tt			
							WHERE ID = @id_lai_suat_cn
							
							INSERT INTO @table_item
							(
								ID,
								NGAY_DAU,
								NGAY_KET_THUC,
								LAI_SUAT,
								GHI_CHU
							)
							VALUES
							(
								@id_lai_suat_cn
								, @ngay_ket_thuc_ls_tt
								, @ngay_ket_thuc_ls_cn
								, @lai_suat_cn
								, @ghi_chu_ls_cn
							)
						END
					END
				END
			END
			FETCH NEXT FROM v_cur_ls_cap_nhat 
			INTO @id_lai_suat_cn
			, @ngay_bat_dau_ls_cn
			, @ngay_ket_thuc_ls_cn
			, @lai_suat_cn
			, @ghi_chu_ls_cn	
		END
		CLOSE v_cur_ls_cap_nhat
		DEALLOCATE v_cur_ls_cap_nhat;
	  FETCH NEXT FROM v_cur_ls_thoa_thuan INTO @id_lai_suat_tt, @ngay_bat_dau_ls_tt,@ngay_ket_thuc_ls_tt,@lai_suat_tt, @ghi_chu_ls_tt	
	END
	CLOSE v_cur_ls_thoa_thuan
	DEALLOCATE v_cur_ls_thoa_thuan;

END



