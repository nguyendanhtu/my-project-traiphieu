using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Drawing;

namespace IPChart
{
    public class ChartDataSourceInterface
    {
        DataTable m_DataTable;

        CChartParameter m_ChartParameter;
        public CChartParameter ChartParameter
        {
            get
            {
                return m_ChartParameter;
            }
            set 
            { 
                m_ChartParameter = value;
                InitiateDataSource();
            }
        }

        List<int> m_SortList;
        decimal m_restValueOnGroup = 0;

        decimal[] m_values;
        public decimal[] Values
        {
            get
            {
                if (m_ChartParameter.IsGroup && m_restValueOnGroup != 0)
                {
                    m_values = new decimal[m_SortList.Count + 1];
                    DataRow[] _rows = m_DataTable.Select();
                    int _index = 0;
                    foreach (int i in m_SortList)
                    {
                        if (_rows[i][m_ChartParameter.StrDataColName] == DBNull.Value)
                            m_values[_index++] = 0;
                        else
                            m_values[_index++] = Convert.ToDecimal(_rows[i][m_ChartParameter.StrDataColName]);
                    }
                    m_values[_index] = m_restValueOnGroup;

                }
                else
                {
                    m_values = new decimal[m_SortList.Count];
                    DataRow[] _rows = m_DataTable.Select();
                    int _index = 0;
                    foreach (int i in m_SortList)
                    {
                        if ((_rows[i][m_ChartParameter.StrDataColName] == DBNull.Value) || (double)_rows[i][m_ChartParameter.StrDataColName] == 0)
                            m_values[_index++] = 0;
                        else
                            m_values[_index++] = Convert.ToDecimal((double)_rows[i][m_ChartParameter.StrDataColName]);
                    }
                }
                return m_values; 
            }
        }

        string[] m_texts;
        public string[] Texts
        {
            get
            {
                if (m_ChartParameter.IsGroup && m_restValueOnGroup != 0)
                {
                    m_texts = new string[m_SortList.Count + 1];
                    DataRow[] _rows = m_DataTable.Select();
                    int _index = 0;
                    foreach (int i in m_SortList)
                        m_texts[_index++] = _rows[i][m_ChartParameter.StrCaptionColName].ToString();
                    m_texts[_index] = "Phần còn lại";
                }
                else
                {
                    m_texts = new string[m_SortList.Count];
                    DataRow[] _rows = m_DataTable.Select();
                    int _index = 0;
                    foreach (int i in m_SortList)
                        m_texts[_index++] = _rows[i][m_ChartParameter.StrCaptionColName].ToString();
                }
                return m_texts; 
            }
        }

        string[] m_tooltips;
        public string[] Tooltips
        {
            get 
            {
                m_tooltips = m_texts;
                return m_tooltips; 
            }
        }

        Color[] m_colors;
        public Color[] Colors
        {
            get 
            {
                m_colors = new Color[] {
                Color.FromArgb(122, 200, 255, 255), 
                Color.FromArgb(122, 150, 200, 255), 
                Color.FromArgb(122, 100, 100, 200),
                Color.FromArgb(122, 255, 60, 130),
                Color.FromArgb(122, 250, 200, 255),
                Color.FromArgb(122, 255, 255, 0),
                Color.FromArgb(122, 255, 155, 55),
                Color.FromArgb(122, 150, 200, 155),
                Color.FromArgb(122, 255, 255, 200),
                Color.FromArgb(122, 100, 150, 200),
                Color.FromArgb(122, 130, 235, 250),
                Color.FromArgb(122, 150, 240, 80)};
                return m_colors; 
            }
            set { m_colors = value; }
        }

        float[] m_displacements;
        public float[] Displacements
        {
            get 
            {
                if (m_ChartParameter.IsGroup && m_restValueOnGroup != 0)
                {
                    m_displacements = new float[m_SortList.Count + 1];
                    for (int i = 0; i < m_SortList.Count + 1; i++)
                    {
                        m_displacements[i] = (float)(0.05);
                    }
                    m_displacements[0] = (float)0.2;
                }
                else
                {
                    m_displacements = new float[m_SortList.Count];
                    for (int i = 0; i < m_SortList.Count; i++)
                    {
                        m_displacements[i] = (float)(0.05);
                    }
                    m_displacements[0] = (float)0.2;
                }
                return m_displacements; 
            }
            set { m_displacements = value; }
        }

        DataTable m_horizontalDataTable;
        public DataTable HorizontalDataTable
        {
            get 
            {
                m_horizontalDataTable = new DataTable();
                for (int i = 0; i < Texts.Length; i++)
                {
                    m_horizontalDataTable.Columns.Add(Texts[i].ToString(), typeof(System.Double));
                }
                DataRow _row = m_horizontalDataTable.NewRow();
                for (int i = 0; i < Values.Length; i++)
                {
                    _row[i] = (double)Values[i];
                }
                m_horizontalDataTable.Rows.Add(_row);
                return m_horizontalDataTable; 
            }
        }

        public ChartDataSourceInterface(DataTable ip_DataTable, CChartParameter ip_chart_para)
        {
            m_DataTable = ip_DataTable;
            m_ChartParameter = ip_chart_para;
            InitiateDataSource();
        }

        public void InitiateDataSource()
        {
            getSortList();
            if (m_ChartParameter.IsRemovedZeroValues)
                removeZeroValueFromSortList();
            if (m_ChartParameter.IsGroup)
                group();
        }

        private void getSortList()
        {
            DataRow[] _rows = m_DataTable.Select();
            List<int> _orderList = new List<int>(m_DataTable.Rows.Count);
            Dictionary<int, int> _dict = new Dictionary<int, int>();
            m_SortList = new List<int>(m_DataTable.Rows.Count);

            switch (m_ChartParameter.Type)
            {
                case SortType.None:
                    m_SortList = new List<int>(m_DataTable.Rows.Count);
                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        m_SortList.Add(i);
                    break;
                case SortType.ASC:
                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    {
                        _orderList.Add((int)_rows[i][m_ChartParameter.StrOrderColName]);
                        _dict.Add((int)_rows[i][m_ChartParameter.StrOrderColName], i);
                    }
                    _orderList.Sort();
                    foreach (int i in _orderList)
                    {
                        m_SortList.Add(_dict[i]);
                    }
                    break;
                case SortType.DESC:
                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    {
                        _orderList.Add((int)_rows[i][m_ChartParameter.StrOrderColName]);
                        _dict.Add((int)_rows[i][m_ChartParameter.StrOrderColName], i);
                    }
                    _orderList.Sort(new SortIntDescending());
                    foreach (int i in _orderList)
                    {
                        m_SortList.Add(_dict[i]);
                    }
                    break;
                default:
                    break;
            }
        }

        private void removeZeroValueFromSortList()
        {
            List<int> _newSortList = new List<int>();
            DataRow[] _rows = m_DataTable.Select();
            foreach (int i in m_SortList)
            {
                if (!((_rows[i][m_ChartParameter.StrDataColName] == DBNull.Value) || (Convert.ToInt32(_rows[i][m_ChartParameter.StrDataColName]) == 0)))
                    _newSortList.Add(i);
            }
            m_SortList = _newSortList;
        }

        private void group()
        {
            List<int> _newSortList = new List<int>();
            DataRow[] _rows = m_DataTable.Select();
            decimal _totalvalue = 0;
            m_restValueOnGroup = 0;

            foreach (int i in m_SortList)
                _totalvalue += Convert.ToDecimal(_rows[i][m_ChartParameter.StrDataColName]);

            foreach (int i in m_SortList)
            {
                if ((double)((decimal)_rows[i][m_ChartParameter.StrDataColName] / _totalvalue) < m_ChartParameter.ThresholdGroup)
                    m_restValueOnGroup += Convert.ToDecimal(_rows[i][m_ChartParameter.StrDataColName]);
                else
                    _newSortList.Add(i);
            }
            m_SortList = _newSortList;
        }
    }

    public class SortIntDescending : IComparer<int>
    {
        int IComparer<int>.Compare(int a, int b) //implement Compare
        {
            if (a > b)
                return -1; //normally greater than = 1
            if (a < b)
                return 1; // normally smaller than = -1
            else
                return 0; // equal
        }
    }
}
