set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[pr_GD_LICH_THANH_TOAN_LAI_GOC_select_in_times]
@ID_TRAI_PHIEU numeric(18, 0),
@NGAY_BAT_DAU DATETIME,
@NGAY_KET_THUC DATETIME
AS
BEGIN
	-- Khai báo biến lưu lái suất thỏa thuận
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
	
	SELECT
		tr.ID,
		tr.NGAY_DAU,
		tr.NGAY_KET_THUC,
		(tr.NGAY_KET_THUC - tr.NGAY_DAU) AS SO_NGAY_AP_DUNG,
		tr.LAI_SUAT,
		tr.GHI_CHU
	FROM
		@table_result tr
END

Sau 13/11/2012
Proc
	- pr_DM_NGAY_LAM_VIEC_get_ngay_chot_lai
	- pr_DM_NGAY_LAM_VIEC_get_ngay_thanh_toan_thuc_te
	- pr_V_DM_TRAI_CHU_Select_dang_phong_toa
	- pr_CM_DM_TU_DIEN_Insert
	- pr_V_DM_TRAI_CHU_CHOT_LAI_Select_FillDatasetByIDTraiPhieuAndKyTL
	- pr_V_DM_TRAI_CHU_CHOT_LAI_Select_FillDatasetByIDTraiPhieuAndKyTLbyTrangThai
	- pr_GD_LICH_THANH_TOAN_LAI_GOC_select_lai_suat_by_trai_phieu

GO
--Get ngày chốt lãi từ ngày thanh toán, ngày làm việc 26, số ngày chốt lái trước thanh toán
ALTER PROCEDURE [dbo].[pr_DM_NGAY_LAM_VIEC_get_ngay_chot_lai]
@NGAY_THANH_TOAN DATETIME,
@NGAY_LAM_VIEC_26_YN NVARCHAR(1),
@SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN INT
AS
BEGIN	
	IF @NGAY_LAM_VIEC_26_YN = 'Y'
	BEGIN
		SELECT TOP (@SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN) * FROM DM_NGAY_LAM_VIEC dnlv
		WHERE dnlv.NGAY_LAM_VIEC_YN = 'Y'
		AND dnlv.NGAY < @NGAY_THANH_TOAN
		ORDER BY dnlv.NGAY DESC
	END	
	ELSE
	BEGIN
		SELECT TOP (@SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN) * FROM DM_NGAY_LAM_VIEC dnlv
		WHERE dnlv.NGAY_LAM_VIEC_HAI_BAY_YN = 'Y'
		AND dnlv.NGAY < @NGAY_THANH_TOAN
		ORDER BY dnlv.NGAY DESC		
	END
END

GO
--Get ngày thanh toán thực tế
ALTER PROCEDURE [dbo].[pr_DM_NGAY_LAM_VIEC_get_ngay_thanh_toan_thuc_te]
@NGAY_THANH_TOAN DATETIME,
@NGAY_LAM_VIEC_26_YN NVARCHAR(1),
@NGAY_LAM_VIEC_TRUOC_NGHI_YN NVARCHAR(1)
AS
BEGIN
	--Danh sách biến lưu thông tin ngày làm việc
	DECLARE @ng_id INT
	DECLARE @ng_ngay DATETIME
	DECLARE @ng_lam_viec_26 NVARCHAR(1)
	DECLARE @ng_lam_viec_27 NVARCHAR(1)
	DECLARE @ng_thanh_toan_thuc_te DATETIME
	--Bản lưu dữ liệu cuối cùng
	DECLARE @table_retrun TABLE (
		ID NUMERIC(18,0),
		NGAY DATETIME,
		NGAY_LAM_VIEC_YN NVARCHAR(1),
		NGAY_LAM_VIEC_HAI_BAY_YN NVARCHAR(1))	
	--Lấy thông tin ngày thanh toán
	SELECT @ng_id = dnlv.ID,
		@ng_ngay = dnlv.NGAY,
		@ng_lam_viec_26 = dnlv.NGAY_LAM_VIEC_YN,
		@ng_lam_viec_27 = dnlv.NGAY_LAM_VIEC_HAI_BAY_YN
	FROM DM_NGAY_LAM_VIEC dnlv
	WHERE dnlv.NGAY = @NGAY_THANH_TOAN
	--Trái phiếu thuộc loại làm việc từ thứ 2 đến thứ 6
	IF @NGAY_LAM_VIEC_26_YN = 'Y'
	BEGIN
		--Nếu ngày thanh toán này là ngày nghỉ
		IF	@ng_lam_viec_26 = 'N'
		BEGIN
			--lấy ngày tt thực tế là ngày làm việc trước gần nhất với ngày thanh toán là ngày nghỉ
			IF	@NGAY_LAM_VIEC_TRUOC_NGHI_YN = 'Y'
			BEGIN
				SELECT TOP 1 @ng_thanh_toan_thuc_te = dnlv.NGAY
				FROM DM_NGAY_LAM_VIEC dnlv
				WHERE dnlv.NGAY < @ng_ngay
				AND dnlv.NGAY_LAM_VIEC_YN = 'Y'
				ORDER BY dnlv.NGAY DESC 
			END
			ELSE--lấy ngày tt thực tế là ngày làm việc sau gần nhất với ngày thanh toán là ngày nghỉ
			BEGIN
				SELECT TOP 1 @ng_thanh_toan_thuc_te = dnlv.NGAY
				FROM DM_NGAY_LAM_VIEC dnlv
				WHERE dnlv.NGAY > @ng_ngay
				AND dnlv.NGAY_LAM_VIEC_YN = 'Y'
				ORDER BY dnlv.NGAY ASC 
			END
		END
		ELSE
			BEGIN
			    SET	@ng_thanh_toan_thuc_te = @ng_ngay
			END
	END
	ELSE --Trái phiếu thuộc loại làm việc từ thứ 2 đến thứ 7
	BEGIN
		--Nếu ngày thanh toán này là ngày nghỉ
		IF	@ng_lam_viec_27 = 'N'
		BEGIN
			--lấy ngày tt thực tế là ngày làm việc trước gần nhất với ngày thanh toán là ngày nghỉ
			IF	@NGAY_LAM_VIEC_TRUOC_NGHI_YN = 'Y'
			BEGIN
				SELECT TOP 1 @ng_thanh_toan_thuc_te = dnlv.NGAY
				FROM DM_NGAY_LAM_VIEC dnlv
				WHERE dnlv.NGAY < @ng_ngay
				AND dnlv.NGAY_LAM_VIEC_HAI_BAY_YN = 'Y'
				ORDER BY dnlv.NGAY DESC 
			END
			ELSE--lấy ngày tt thực tế là ngày làm việc sau gần nhất với ngày thanh toán là ngày nghỉ
			BEGIN
				SELECT TOP 1 @ng_thanh_toan_thuc_te = dnlv.NGAY
				FROM DM_NGAY_LAM_VIEC dnlv
				WHERE dnlv.NGAY > @ng_ngay
				AND dnlv.NGAY_LAM_VIEC_HAI_BAY_YN = 'Y'
				ORDER BY dnlv.NGAY ASC 
			END
		END
		ELSE
			BEGIN
				SET	@ng_thanh_toan_thuc_te = @ng_ngay
			END
	END
	
	--Gán kết quả vào bản cuối
	INSERT INTO @table_retrun
	(
		ID,
		NGAY,
		NGAY_LAM_VIEC_YN,
		NGAY_LAM_VIEC_HAI_BAY_YN
	)
	VALUES
	(
		@ng_id,
		@ng_thanh_toan_thuc_te,
		@ng_lam_viec_26,
		@ng_lam_viec_27
	)
	
	SELECT * FROM @table_retrun tr
END

GO
--Danh sách những trái chủ đang bị phong tỏa trái phiếu
ALTER PROCEDURE [dbo].[pr_V_DM_TRAI_CHU_Select_dang_phong_toa]
AS
SELECT *	
FROM V_DM_TRAI_CHU tc
WHERE tc.TONG_SO_DU > tc.SO_DU_KHA_DUNG
ORDER BY tc.[ID] ASC

GO
--Sửa lại để lưu được tên dài hơn.
ALTER  PROCEDURE [dbo].[pr_CM_DM_TU_DIEN_Insert]
	@MA_TU_DIEN nvarchar(15),
	@ID_LOAI_TU_DIEN numeric(18, 0),
	@TEN_NGAN nvarchar(35),
	@TEN nvarchar(250),
	@GHI_CHU nvarchar(250),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[CM_DM_TU_DIEN]
(
	[MA_TU_DIEN],
	[ID_LOAI_TU_DIEN],
	[TEN_NGAN],
	[TEN],
	[GHI_CHU]
)
VALUES
(
	@MA_TU_DIEN,
	@ID_LOAI_TU_DIEN,
	@TEN_NGAN,
	@TEN,
	@GHI_CHU
)
SELECT @ID=SCOPE_IDENTITY()

GO
--danh sách trái chủ theo trái phiếu và kỳ tính lãi
ALTER PROC [dbo].[pr_V_DM_TRAI_CHU_CHOT_LAI_Select_FillDatasetByIDTraiPhieuAndKyTL]
@ID_TRAI_PHIEU NUMERIC(18,0)
, @KY_TINH_LAI NUMERIC(4,0)
AS
SELECT * FROM V_DM_TRAI_CHU_CHOT_LAI dtccl
WHERE dtccl.KY_TINH_LAI = @KY_TINH_LAI
AND dtccl.ID_TRAI_PHIEU_SO_HUU = @ID_TRAI_PHIEU

GO
--Danh sách trái chủ theo trái phiếu và kỳ tính lãi, trạng thái
ALTER PROC [dbo].[pr_V_DM_TRAI_CHU_CHOT_LAI_Select_FillDatasetByIDTraiPhieuAndKyTLbyTrangThai]
@ID_TRAI_PHIEU NUMERIC(18,0)
, @KY_TINH_LAI NUMERIC(4,0)
, @DA_THANH_TOAN NVARCHAR
AS
SELECT * FROM V_DM_TRAI_CHU_CHOT_LAI dtccl
WHERE dtccl.KY_TINH_LAI = @KY_TINH_LAI
AND dtccl.ID_TRAI_PHIEU_SO_HUU = @ID_TRAI_PHIEU
AND (dtccl.DA_NHAN_TIEN_YN = @DA_THANH_TOAN OR @DA_THANH_TOAN = 'A')

GO
ALTER PROCEDURE [dbo].[pr_GD_LICH_THANH_TOAN_LAI_GOC_select_chot_lai_by_trai_phieu]
@ID_TRAI_PHIEU numeric(18, 0)
AS
BEGIN
	SELECT *
	FROM [dbo].[GD_LICH_THANH_TOAN_LAI_GOC]
	WHERE ID_TRAI_PHIEU = @ID_TRAI_PHIEU
	AND CHOT_LAI_YN = 'Y'	
	ORDER BY NGAY DESC	
END

