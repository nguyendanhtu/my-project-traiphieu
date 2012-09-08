using System;
using System.Collections.Generic;

using System.Text;

namespace IPChart
{
    public enum SortType
    {
        None,
        ASC,
        DESC
    }

    public class CChartParameter
    {
        private string strCaptionColName;
        public string StrCaptionColName
        {
            get { return strCaptionColName; }
            set { strCaptionColName = value; }
        }
        
        private string strDataColName;
        public string StrDataColName
        {
            get { return strDataColName; }
            set { strDataColName = value; }
        }

        private string strOrderColName;
        public string StrOrderColName
        {
            get { return strOrderColName; }
            set { strOrderColName = value; }
        }

        private string strCaptionOfChart;
        public string StrCaptionOfChart
        {
            get { return strCaptionOfChart; }
            set { strCaptionOfChart = value; }
        }

        private SortType type = SortType.None;
        public SortType Type
        {
            get { return type; }
            set { type = value; }
        }

        private bool isRemovedZeroValues = true;
        public bool IsRemovedZeroValues
        {
            get { return isRemovedZeroValues; }
            set { isRemovedZeroValues = value; }
        }

        private bool isGroup = true;
        public bool IsGroup
        {
            get { return isGroup; }
            set { isGroup = value; }
        }

        private double thresholdGroup = 0.070;
        public double ThresholdGroup
        {
            get { return thresholdGroup; }
            set { thresholdGroup = value; }
        }

        public CChartParameter()
        { }

        public CChartParameter(string ip_chart_description, string ip_Order_col_name, string ip_Caption_col_name, string ip_Data_col_name, SortType ip_sort_type)
        {
            strCaptionColName = ip_Caption_col_name;
            strDataColName = ip_Data_col_name;
            strOrderColName = ip_Order_col_name;
            strCaptionOfChart = ip_chart_description;
            type = ip_sort_type;
        }
    }

  
}
