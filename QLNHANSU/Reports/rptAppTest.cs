using BusinessLayer.DataObject;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptAppTest : DevExpress.XtraReports.UI.XtraReport
    {
        List<CONGTY_DTO> _lsCV;
        public rptAppTest()
        {
            InitializeComponent();
        }
       public rptAppTest(List<CONGTY_DTO> lsCV)
        {
            InitializeComponent();
            this._lsCV = lsCV;
            this.DataSource = _lsCV;
            loadData();
        }

        void loadData()
        {
            MACTY.DataBindings.Add("Text", _lsCV, "MACTY");
            TENCTY.DataBindings.Add("Text", _lsCV, "TENCTY");
            DIACHI.DataBindings.Add("Text", _lsCV, "DIACHI");
            EMAIL.DataBindings.Add("Text", _lsCV, "EMAIL");
            DIENTHOAI.DataBindings.Add("Text", _lsCV, "DIENTHOAI");
        }

    }
}
