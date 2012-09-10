using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarChart;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace IPChart
{
    public partial class frmBarChart : Form
    {
        //    /*
        //    // Chart can either get data directly
        //    // 
        //    //
        //    barChart.Add(1900.25668, "Jan", Color.FromArgb(255, 200, 255, 255));
        //    barChart.Add(2841.5468, "Feb", Color.FromArgb(255, 150, 200, 255));
        //    barChart.Add(1045.3258, "Mar", Color.FromArgb(255, 100, 100, 200));
        //    barChart.Add(1502.215 , "Apr", Color.FromArgb(255, 255, 60, 130));
        //    barChart.Add(1467     , "May", Color.FromArgb(255, 250, 200, 255));
        //    barChart.Add(1678.354 , "Jun", Color.FromArgb(255, 255, 255, 0));
        //    barChart.Add(1785.689 , "Jul", Color.FromArgb(255, 255, 155, 55));
        //    barChart.Add(1283.099 , "Aug", Color.FromArgb(255, 150, 200, 155));
        //    barChart.Add(1554.879 , "Sep", Color.FromArgb(255, 255, 255, 200));
        //    barChart.Add(1400.10  , "Oct", Color.FromArgb(255, 100, 150, 200));
        //    barChart.Add(1600.556 , "Nov", Color.FromArgb(255, 130, 235, 250));
        //    barChart.Add(1900.3546, "Des", Color.FromArgb(255, 150, 240, 80));
        //    */
        ChartDataSourceInterface m_dataSource = null;

        public frmBarChart(CChartParameter ip_obj_chart_para, DataTable ip_DataTable )
        {
            InitializeComponent();
            InitialBarChart(ip_obj_chart_para);
            m_dataSource = new ChartDataSourceInterface(ip_DataTable, ip_obj_chart_para);
            this.barChart.DataSource = m_dataSource.HorizontalDataTable;
        }

        private void InitialBarChart(CChartParameter ip_obj_chart_para)
        {
            // Not AutoScale
            comboBoxSizingMode.SelectedIndex = 1;
            //barChart.SizingMode = HBarChart.BarSizingMode.Normal;

            // Percent
            comboBoxValueMode.SelectedIndex = 1;
            barChart.Values.Mode = CValueProperty.ValueMode.Percent;

            // Glass
            comboBoxDrawingMode.SelectedIndex = 0;

            // Radial gradient background
            radioButtonBKRadial.Select();

            barChart.Border.Width = 10;
            barChart.Shadow.Mode = CShadowProperty.Modes.Both;
            barChart.Shadow.WidthInner = 1;
            barChart.Shadow.WidthOuter = 4;
            barChart.Shadow.ColorOuter = Color.FromArgb(100, 0, 0, 0);

            this.comboBoxShadowMode.SelectedIndex = 3;
            this.trackBarOuterShadow.Value = 4;
            this.trackBarInnerShadow.Value = 1;

            checkBoxDescription.Checked = true;
            barChart.Description.Visible = checkBoxDescription.Checked;

            checkBoxShowValues.Checked = true;
            barChart.Values.Visible = checkBoxShowValues.Checked;

            checkBoxLabels.Checked = true;
            barChart.Label.Visible = checkBoxLabels.Checked;

            checkBoxTooltips.Checked = true;

            barChart.Description.Text = ip_obj_chart_para.StrCaptionOfChart;
            textBoxDesc.Text = barChart.Description.Text;

            // Register for control events
            barChart.BarClicked += new HBarChart.OnBarEvent(barChart_BarClicked);
            barChart.BarDoubleClicked += new HBarChart.OnBarEvent(barChart_BarDoubleClicked);
            barChart.BarMouseEnter += new HBarChart.OnBarEvent(barChart_BarMouseEnter);
            barChart.BarMouseLeave += new HBarChart.OnBarEvent(barChart_BarMouseLeave);

            bool b = comboBoxSizingMode.Focus();
        }

        #region Events
        private void barChart_BarClicked(Object sender, BarEventArgs e)
        {
            //textBoxEvents.Text = String.Format("Click event raised for bar:{0}", e.BarIndex);
        }

        private void barChart_BarDoubleClicked(Object sender, BarEventArgs e)
        {
           // textBoxEvents.Text = String.Format("DoubleClick event raised for bar:{0}", e.BarIndex);
        }

        private void barChart_BarMouseEnter(Object sender, BarEventArgs e)
        {
            //textBoxEvents.Text = String.Format("MouseEnter event raised for bar:{0}", e.BarIndex);
        }

        private void barChart_BarMouseLeave(Object sender, BarEventArgs e)
        {
            //textBoxEvents.Text = String.Format("MouseLeave raised for bar:{0}", e.BarIndex);
        }

        private void comboBoxSizingMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            if (senderComboBox.SelectedItem == comboBoxSizingMode.Items[0]) // "AutoScale"
            {
                barChart.SizingMode = HBarChart.BarSizingMode.AutoScale;
                groupBoxSizing.Enabled = false;
            }
            else if (senderComboBox.SelectedItem == comboBoxSizingMode.Items[1]) // Normal
            {
                barChart.SizingMode = HBarChart.BarSizingMode.Normal;
                groupBoxSizing.Enabled = true; ;
            }
            barChart.RedrawChart();
        }

        private void comboBoxValueMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            if (senderComboBox.SelectedItem == comboBoxValueMode.Items[0]) // "Digit"
            {
                barChart.Values.Mode = CValueProperty.ValueMode.Digit;
                barChart.RedrawChart();
            }
            else if (senderComboBox.SelectedItem == comboBoxValueMode.Items[1]) // Normal
            {
                barChart.Values.Mode = CValueProperty.ValueMode.Percent;
                barChart.RedrawChart();
            }
            barChart.RedrawChart();
        }

        private void checkBoxShowValues_CheckedChanged(object sender, EventArgs e)
        {
            barChart.Values.Visible = checkBoxShowValues.Checked;
            barChart.RedrawChart();
        }

        private void checkBoxLabels_CheckedChanged(object sender, EventArgs e)
        {
            barChart.Label.Visible = checkBoxLabels.Checked;
            barChart.RedrawChart();
        }

        private void checkBoxDescription_CheckedChanged(object sender, EventArgs e)
        {
            barChart.Description.Visible = checkBoxDescription.Checked;
            barChart.RedrawChart();
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            barChart.Description.Text = textBoxDesc.Text;
            barChart.RedrawChart();
        }

        private void radioButtonBKGradient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBKSolid_CheckedChanged(object sender, EventArgs e)
        {
            barChart.Background.PaintingMode = CBackgroundProperty.PaintingModes.SolidColor;
            barChart.RedrawChart();
        }

        private void buttonBKColor1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Background.GradientColor1 = colorDialog.Color;
                barChart.RedrawChart();
            }
        }

        private void buttonBKColor2_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Background.GradientColor2 = colorDialog.Color;
                barChart.RedrawChart();
            }
        }

        private void buttonBKColorSolid_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Background.SolidColor = colorDialog.Color;
                barChart.RedrawChart();
            }
        }

        private void trackBarGap_Scroll(object sender, EventArgs e)
        {
            barChart.BarsGap = trackBarGap.Value;
            barChart.RedrawChart();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Gap siz({0})", trackBarGap.Value.ToString());
            labelGapValue.Text = sb.ToString();
        }

        private void trackBarWidthBar_Scroll(object sender, EventArgs e)
        {
            barChart.BarWidth = trackBarWidthBar.Value;
            barChart.RedrawChart();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Bar Width({0})", trackBarWidthBar.Value.ToString());

            labelBarWidthValue.Text = sb.ToString();
        }

        private void buttonLabelFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Label.Font = fontDialog.Font;
                barChart.RedrawChart();
            }
        }

        private void buttonValueFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Values.Font = fontDialog.Font;
                barChart.RedrawChart();
            }
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Description.Font = fontDialog.Font;
                barChart.RedrawChart();
            }
        }
          
        private void buttonColorValues_Click(object sender, EventArgs e)
        {
            Color color;
            if (GetColor(out color))
            {
                barChart.Values.Color = color;
                barChart.RedrawChart();

                buttonColorValues.BackColor = color;
            }
        }

        private void buttonColorDesc_Click(object sender, EventArgs e)
        {
            Color color;
            if (GetColor(out color))
            {
                barChart.Description.Color = color;
                barChart.RedrawChart();

                buttonColorDesc.BackColor = color;
            }
        }

        private void buttonColorLabels_Click(object sender, EventArgs e)
        {
            Color color;
            if (GetColor(out color))
            {
                barChart.Label.Color = color;
                barChart.RedrawChart();

                buttonColorLabel.BackColor = color;
            }
        }

        private bool GetColor(out Color colorSelected)
        {
            colorSelected = Color.Empty;
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                colorSelected = colorDialog.Color;
                return true;
            }

            return false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (comboBoxSizingMode.SelectedItem == comboBoxSizingMode.Items[0]) // "AutoScale"
            {
                barChart.Print(true, "TestChartPrint");
            }
            else if (comboBoxSizingMode.SelectedItem == comboBoxSizingMode.Items[1]) // Normal
            {
                barChart.Print(false, "TestChartPrint");
            }
        }

        private void checkBoxTooltips_CheckedChanged(object sender, EventArgs e)
        {
            barChart.BarTooltip.Active = checkBoxTooltips.Checked;
        }

        private void comboBoxBarDrawingMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            if (senderComboBox.SelectedItem == comboBoxDrawingMode.Items[0]) // "AutoScale"
            {
                barChart.Items.DrawingMode = HBarItems.DrawingModes.Glass;
            }
            else if (senderComboBox.SelectedItem == comboBoxDrawingMode.Items[1]) // Normal
            {
                barChart.Items.DrawingMode = HBarItems.DrawingModes.Rubber;
            }
            else
            {
                barChart.Items.DrawingMode = HBarItems.DrawingModes.Solid;
            }
            barChart.RedrawChart();

        }

        private void comboBoxShadowMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;

            if (senderComboBox.SelectedItem == comboBoxShadowMode.Items[0]) // "AutoScale"
            {
                barChart.Shadow.Mode = CShadowProperty.Modes.None;
            }
            else if (senderComboBox.SelectedItem == comboBoxShadowMode.Items[1]) // Normal
            {
                barChart.Shadow.Mode = CShadowProperty.Modes.Inner;
            }
            else if (senderComboBox.SelectedItem == comboBoxShadowMode.Items[2]) // Normal
            {
                barChart.Shadow.Mode = CShadowProperty.Modes.Outer;
            }
            else if (senderComboBox.SelectedItem == comboBoxShadowMode.Items[3]) // Normal
            {
                barChart.Shadow.Mode = CShadowProperty.Modes.Both;
            }


            barChart.RedrawChart();
        }

        private void trackBarShadowInner_Scroll(object sender, EventArgs e)
        {
            barChart.Shadow.WidthInner = trackBarInnerShadow.Value;
            barChart.RedrawChart();

            labelShadowInnerWidth.Text = String.Format("Inner({0})", trackBarInnerShadow.Value);
        }

        private void trackBarShadowOuter_Scroll(object sender, EventArgs e)
        {
            barChart.Shadow.WidthOuter = trackBarOuterShadow.Value;
            barChart.RedrawChart();

            labelShadowOuterWidth.Text = String.Format("Outer({0})", trackBarOuterShadow.Value);
        }

        private void trackBarBorder_Scroll(object sender, EventArgs e)
        {
            barChart.Border.Width = trackBarBorder.Value;
            barChart.RedrawChart();

            labelBorder.Text = String.Format("Size({0})", trackBarBorder.Value);
        }

        private void buttonColorInnerShadow_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Shadow.ColorInner = Color.FromArgb(barChart.Shadow.ColorInner.A, colorDialog.Color);
                barChart.RedrawChart();
            }
        }

        private void buttonColorOuterShadow_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Shadow.ColorOuter = Color.FromArgb(barChart.Shadow.ColorOuter.A, colorDialog.Color);
                barChart.RedrawChart();
            }
        }

        private void buttonColorBorder_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                barChart.Border.Color = colorDialog.Color;
                barChart.RedrawChart();
            }

        }

        private void radioButtonBKRadial_CheckedChanged(object sender, EventArgs e)
        {
            barChart.Background.PaintingMode = CBackgroundProperty.PaintingModes.RadialGradient;
            barChart.RedrawChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog _saveFileDialog = new SaveFileDialog();
                _saveFileDialog.CheckPathExists = true;
                _saveFileDialog.AddExtension = true;
                _saveFileDialog.ValidateNames = true;
                _saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                _saveFileDialog.DefaultExt = ".bmp";
                _saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp| Jpeg (*.jpg)|*.jpg";
                    if (_saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        switch (_saveFileDialog.FilterIndex)
                        {
                            case 2:
                                //barChart.SaveImage(_saveFileDialog.FileName, ImageFormat.Jpeg);
                                saveImage(barChart, _saveFileDialog.FileName, ImageFormat.Jpeg);
                                break;
                            default:
                                //barChart.SaveImage(_saveFileDialog.FileName, ImageFormat.Bmp);
                                saveImage(barChart, _saveFileDialog.FileName, ImageFormat.Bmp);
                                break;
                        }
                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void checkBoxRemoveZeroValue_CheckedChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.IsRemovedZeroValues = checkBoxRemoveZeroValue.Checked;
            m_dataSource.InitiateDataSource();
            barChart.DataSource = m_dataSource.HorizontalDataTable;
            barChart.RedrawChart();
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.IsGroup = checkBoxGroup.Checked;
            m_dataSource.InitiateDataSource();
            barChart.DataSource = m_dataSource.HorizontalDataTable;
            barChart.RedrawChart();
        }

        private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e)
        {
            m_dataSource.ChartParameter.ThresholdGroup = (double)numericUpDownThreshold.Value;
            m_dataSource.InitiateDataSource();
            barChart.DataSource = m_dataSource.HorizontalDataTable;
            barChart.RedrawChart();
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
