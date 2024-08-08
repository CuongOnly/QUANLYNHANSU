using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLNHANSU.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class AppTest : DevExpress.XtraEditors.XtraForm
    {
        private CONGTY _congty;
       List<CONGTY_DTO> lsCV;
        private int _id;
        public AppTest()
        {
            InitializeComponent();
        }
        private void AppTest_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
        }
        void loadData()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACTY").ToString());
            var ct = _congty.getItem(_id);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptAppTest rpt = new rptAppTest(lsCV);// lấy được ds
            // gọi chúng ra show lớn
            rpt.ShowRibbonPreview();
        }
    }
}