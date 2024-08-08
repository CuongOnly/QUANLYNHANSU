using DataLayer;
using BusinessLayer;
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
    public partial class fmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public fmTonGiao()
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
            txtTen1.Enabled = !kt;
        }

        TONGIAO _tongiao;
        bool _them;
        int _id;

        private void fmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new TONGIAO();
            _showHide(true);
            loadData();
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tongiao.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen1.Text = string.Empty;
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
                _tongiao.Delete(_id);
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
                tb_TONGIAO tg = new tb_TONGIAO(); ;
                tg.TENTG = txtTen1.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var tg = _tongiao.getItem(_id); // ở gvDanhSach_Click gán _id vào khi click vào dòng cần sửa
                tg.TENTG = txtTen1.Text;
                _tongiao.Update(tg);
            }
        }

        private void gvDanhSach_Click_1(object sender, EventArgs e)
        {
            // lay id khi click sua
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            // load dong len ô textbox
            txtTen1.Text = gvDanhSach.GetFocusedRowCellValue("TENTG").ToString();
        }
    }
}