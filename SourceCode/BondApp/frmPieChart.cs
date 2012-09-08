using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Drawing.PieChart;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace IPChart
{
    public partial class frmPieChart : Form
    {
        ChartDataSourceInterface m_dataSource;

        public frmPieChart(CChartParameter ip_chart_para,DataTable ip_DataTable)
        {
            m_dataSource = new ChartDataSourceInterface(ip_DataTable, ip_chart_para);
            InitializeComponent();
            FillEdgeColorTypeListBox();
            InitializeChart();
        }

        #region Init Chart
        private void InitializeChart()
        {
            SetValues();
            SetPieDisplacements();
            SetColors();
            SetTexts();
            SetToolTips();
            pieChartControl.LeftMargin = (float)numericUpDownLeftMargin.Value;
            pieChartControl.RightMargin = (float)numericUpDownRightMargin.Value;
            pieChartControl.TopMargin = (float)numericUpDownTopMargin.Value;
            pieChartControl.BottomMargin = (float)numericUpDownBottomMargin.Value;
            pieChartControl.FitChart = checkBoxFitChart.Checked;
            pieChartControl.SliceRelativeHeight = (float)numericUpDownPieHeight.Value;
            pieChartControl.InitialAngle = (float)numericUpDownAngle.Value;
            pieChartControl.EdgeLineWidth = (float)numericUpDownEdgeLineWidth.Value;
        }

        private void FillEdgeColorTypeListBox()
        {
            string[] types = Enum.GetNames(typeof(EdgeColorType));
            comboBoxEdgeType.Items.AddRange(types);
            comboBoxEdgeType.SelectedIndex = (int)EdgeColorType.DarkerThanSurface;
        }

        private void UpdateChart()
        {
            SetValues();
            SetPieDisplacements();
            SetColors();
            SetTexts();
            SetToolTips();
        }

        private void SetValues()
        {
            pieChartControl.Values = m_dataSource.Values;
            
        }

        private void SetPieDisplacements()
        {
            pieChartControl.SliceRelativeDisplacements = m_dataSource.Displacements;
        }

        private void SetColors()
        {
            pieChartControl.Colors = m_dataSource.Colors;
        }

        private void SetTexts()
        {
            pieChartControl.Texts = m_dataSource.Texts;
        }

        private void SetToolTips()
        {
            pieChartControl.ToolTips = m_dataSource.Tooltips;
        }
        #endregion

        #region Events
        private void numericUpDownLeftMargin_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.LeftMargin = (float)numericUpDownLeftMargin.Value;
        }

        private void numericUpDownRightMargin_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.RightMargin = (float)numericUpDownRightMargin.Value;
        }

        private void numericUpDownTopMargin_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.TopMargin = (float)numericUpDownTopMargin.Value;
        }

        private void numericUpDownBottomMargin_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.BottomMargin = (float)numericUpDownBottomMargin.Value;
        }

        private void numericUpDownPieHeight_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.SliceRelativeHeight = (float)numericUpDownPieHeight.Value;
        }

        private void radioButtonShadowStyle_Changed(object sender, System.EventArgs e)
        {
            if (radioButtonShadowStyleNone.Checked)
                pieChartControl.ShadowStyle = ShadowStyle.NoShadow;
            else if (radioButtonShadowStyleUniform.Checked)
                pieChartControl.ShadowStyle = ShadowStyle.UniformShadow;
            else
                pieChartControl.ShadowStyle = ShadowStyle.GradualShadow;
        }

        private void numericUpDownAngle_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.InitialAngle = (float)numericUpDownAngle.Value;
        }

        private void checkBoxFitChart_CheckedChanged(object sender, System.EventArgs e)
        {
            pieChartControl.FitChart = checkBoxFitChart.Checked;
        }

        private void comboBoxEdgeType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            pieChartControl.EdgeColorType = (EdgeColorType)comboBoxEdgeType.SelectedIndex;
        }

        private void numericUpDownEdgeLineWidth_ValueChanged(object sender, System.EventArgs e)
        {
            pieChartControl.EdgeLineWidth = (float)numericUpDownEdgeLineWidth.Value;
        }

        private void m_numericUpDownAlpha_ValueChanged(object sender, System.EventArgs e)
        {
            SetColors();
        }

        private void checkBoxRemoveZeroValue_CheckedChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.IsRemovedZeroValues = checkBoxRemoveZeroValue.Checked;
            m_dataSource.InitiateDataSource();
            InitializeChart();
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.IsGroup = checkBoxGroup.Checked;
            m_dataSource.InitiateDataSource();
            InitializeChart();
        }

        private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.ThresholdGroup = (double)numericUpDownThreshold.Value;
            m_dataSource.InitiateDataSource();
            InitializeChart();
        }

        private void m_buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog _saveFileDialog = new SaveFileDialog();
                _saveFileDialog.CheckPathExists = true;
                _saveFileDialog.AddExtension = false;
                _saveFileDialog.ValidateNames = true;
                _saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                _saveFileDialog.DefaultExt = ".bmp";
                _saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp| Jpeg (*.jpg)|*.jpg";
                if (_saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    switch (_saveFileDialog.FilterIndex)
                    {
                        case 2:
                            //pieChartControl.saveImage(_saveFileDialog.FileName, ImageFormat.Jpeg);
                            saveImage(pieChartControl, _saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        default:
                            //pieChartControl.saveImage(_saveFileDialog.FileName, ImageFormat.Bmp);
                            saveImage(pieChartControl, _saveFileDialog.FileName, ImageFormat.Bmp);
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        
        #region Save Image From Control Method
        [DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt(
        IntPtr hdcDest,
        int nXDest,
        int nYDest,
        int nWidth,
        int nHeight,
        IntPtr hdcSrc,
        int nXSrc,
        int nYSrc,
        int dwRop);

        public Bitmap CaptureControl(Control control)
        {
            Bitmap controlBmp;
            using (Graphics g1 = control.CreateGraphics())
            {
                controlBmp = new Bitmap(control.Width, control.Height, g1);
                using (Graphics g2 = Graphics.FromImage(controlBmp))
                {
                    IntPtr dc1 = g1.GetHdc();
                    IntPtr dc2 = g2.GetHdc();
                    BitBlt(dc2, 0, 0, control.Width, control.Height, dc1, 0, 0, 13369376);
                    g1.ReleaseHdc(dc1);
                    g2.ReleaseHdc(dc2);
                    g2.Dispose();
                }
                g1.Dispose();
            }

            return controlBmp;
        }

        public void saveImage(Control ip_ctrl, string ip_filename, ImageFormat ip_imgformat)
        {
            Bitmap _bmpChart = CaptureControl(ip_ctrl);
            FileStream _fs = new FileStream(ip_filename, FileMode.Create);
            _bmpChart.Save(_fs, ip_imgformat);
            _fs.Dispose();
            _bmpChart.Dispose();
        }
        #endregion
   
    }
}
