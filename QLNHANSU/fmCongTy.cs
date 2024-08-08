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
    public partial class fmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public fmCongTy()
        {
            InitializeComponent();
        }
        void _showHide(bool kt)
        {
            // ẩn hoặc hiện nút
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtTenCty.Enabled = !kt;
            txtDiaChiCty.Enabled = !kt;
            txtEmailCty.Enabled = !kt;
            txtDienThoaiCty.Enabled = !kt;
        }

        CONGTY _congty;
        bool _them;
        int _id;

        private void fmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CONGTY();
            _showHide(true);
            loadData();
        }
        void loadData()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTenCty.Text = string.Empty;
            txtDiaChiCty.Text = string.Empty;
            txtEmailCty.Text = string.Empty;
            txtDienThoaiCty.Text = string.Empty;
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
                _congty.Delete(_id);
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
                tb_CONGTY ct = new tb_CONGTY();
                ct.TENCTY = txtTenCty.Text;
                ct.DIENTHOAI = txtDienThoaiCty.Text;
                ct.EMAIL = txtEmailCty.Text;
                ct.DIACHI = txtDiaChiCty.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_id); // ở gvDanhSach_Click gán _id vào khi click vào dòng cần sửa
                ct.TENCTY = txtTenCty.Text;
                ct.DIENTHOAI = txtDienThoaiCty.Text;
                ct.EMAIL = txtEmailCty.Text;
                ct.DIACHI = txtDiaChiCty.Text;
                _congty.Update(ct);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // lay id khi click sua
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACTY").ToString());
            // load dong len ô textbox
            txtTenCty.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
            txtDienThoaiCty.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
            txtDiaChiCty.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            txtEmailCty.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
        }
    }
}