using BusinessLayer.DataObject;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        public rptHopDongLaoDong(List<HOPDONG_DTO> lstHD)

        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD; // ko có datasource thì k hiểu add dưới
            loadData();
        }
        List<HOPDONG_DTO> _lstHD;

        // byding tuwf rptDS
        void loadData()
        {
            lblSoHD.DataBindings.Add("Text", _lstHD, "SOHD");
        }
        // bước tiếp theo nút print frmHĐLĐ
    }
}
