using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class fmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public fmBoPhan()
        {
            InitializeComponent();
        }

        void _showHide (bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtTen.Enabled = !kt;
        }
        BOPHAN _bophan;
        bool _them;
        int _id;
        private void fmBoPhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _bophan = new BOPHAN();
            _showHide(true);
            loadData();
        }
            void loadData()
            {
                gcDanhSach.DataSource = _bophan.getList();
                gvDanhSach.OptionsBehavior.Editable = false;
            }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bophan.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                _them = false;
                _showHide(true);
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();    
        }
        void SaveData()
        {
            if (_them)
            {
                tb_BOPHAN tg = new tb_BOPHAN(); ;
                tg.TENBP = txtTen.Text;
                _bophan.Add(tg);
            }
            else
            {
                var tg = _bophan.getItem(_id); // ở gvDanhSach_Click gán _id vào khi click vào dòng cần sửa
                tg.TENBP = txtTen.Text;
                _bophan.Update(tg);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // lay id khi click sua
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDBP").ToString());
            // load dong len ô textbox
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENBP").ToString();
        }
    }
}