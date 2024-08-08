using BusinessLayer;
using BusinessLayer.DataObject;
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
    public partial class fmCongViec : DevExpress.XtraEditors.XtraForm
    {
        public fmCongViec()
        {
            InitializeComponent();
        }
        private NHANVIEN _nhanvien;
        private CONGVIEC _congviec;
        private bool _them;
        private int _idCV;
        List<CONGVIEC_DTO> _lstCVDTO;
        void loadCombo()
        {
            cbeNGUOITHUCHIEN.Properties.DataSource = "HOTEN";
            cbeNGUOITHEODOI.Properties.DataSource = "HOTEN";
            cbeNGUOIGIAOVIEC.Properties.DataSource = "HOTEN";
        }

            void _showHide( bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtTENCONGVIEC.Enabled = !kt;
            dtNGAYBATDAU.Enabled = !kt;
            dtNGAYKETTHUC.Enabled = !kt;
            cbeNGUOITHUCHIEN.Enabled = !kt;
            cbeNGUOITHEODOI.Enabled = !kt;
            cbeNGUOIGIAOVIEC.Enabled = !kt;
            cboCONGVIECCHA.Enabled = !kt;
            cboTIENTRIEN.Enabled = !kt;
            cboTIENTRIEN.Enabled = !kt;
            txtMOTA.Enabled = !kt;
            btnFile.Enabled = !kt;
            //picHinhAnh.Image = Properties.Resources.noimage;
            gcDanhSach.Enabled = kt;
        }

        void _reset()
        {
            txtTENCONGVIEC.Text = string.Empty;
            dtNGAYBATDAU.Value = DateTime.Now;
            dtNGAYKETTHUC.Value = dtNGAYBATDAU.Value.AddMonths(6);
            txtMOTA.Text = string.Empty;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _congviec.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstCVDTO = _congviec.getListFull();
        }
        private void fmCongViec_Load(object sender, EventArgs e)
        {
            _them = false;
            _congviec = new CONGVIEC();
            _nhanvien = new NHANVIEN();
            _showHide(true);
            loadData();
            loadCombo();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them= true;
            _reset();
            splitContainer1 = new SplitContainer();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_idCV);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
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
                tb_CONGVIEC cv = new tb_CONGVIEC();
                cv.TENCONGVIEC = txtTENCONGVIEC.Text;
                cv.NGAYBATDAU = dtNGAYBATDAU.Value;
                cv.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                cv.DOUUTIEN = cboDOUUTIEN.SelectedValue.ToString();
                cv.TIENTRIEN = cboTIENTRIEN.SelectedValue.ToString();
                cv.MOTA = txtMOTA.Text;
                var selectedValues = cbeNGUOITHUCHIEN.Properties.Items.GetCheckedValues();

                // Chuyển đổi danh sách giá trị thành chuỗi
                string nguoiThucHien = string.Join(",", selectedValues);
                cv.NGUOITHUCHIEN = nguoiThucHien;
                cv.NGUOIGIAOVIEC = nguoiThucHien;
                cv.NGUOITHEODOI = nguoiThucHien;
            }
            else
            {
                var nv = _congviec.getItem(_idCV);
                tb_CONGVIEC cv = new tb_CONGVIEC();
                cv.TENCONGVIEC = txtTENCONGVIEC.Text;
                cv.NGAYBATDAU = dtNGAYBATDAU.Value;
                cv.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                cv.DOUUTIEN = cboDOUUTIEN.SelectedValue.ToString();
                cv.TIENTRIEN = cboTIENTRIEN.SelectedValue.ToString();
                cv.MOTA = txtMOTA.Text;
                var selectedValues1 = cbeNGUOITHUCHIEN.Properties.Items.GetCheckedValues();
                var selectedValues2 = cbeNGUOIGIAOVIEC.Properties.Items.GetCheckedValues();
                var selectedValues3 = cbeNGUOITHEODOI.Properties.Items.GetCheckedValues();

                // Chuyển đổi danh sách giá trị thành chuỗi
                string nguoiThucHien1 = string.Join(",", selectedValues1);
                string nguoiThucHien2 = string.Join(",", selectedValues2);
                string nguoiThucHien3 = string.Join(",", selectedValues3);
                cv.NGUOITHUCHIEN = nguoiThucHien1;
                cv.NGUOIGIAOVIEC = nguoiThucHien2;
                cv.NGUOITHEODOI = nguoiThucHien3;
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.FocusedRowHandle >= 0)
            {
                _idCV = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACONGVIEC").ToString());
                var cv = _congviec.getItem(_idCV);
                txtTENCONGVIEC.Text = cv.TENCONGVIEC;
                dtNGAYBATDAU.Value = cv.NGAYBATDAU.Value;
                dtNGAYKETTHUC.Value = cv.NGAYKETTHUC.Value;
                cboDOUUTIEN.SelectedValue = cv.DOUUTIEN;
                cboTIENTRIEN.SelectedValue = cv.TIENTRIEN;
                txtMOTA.Text = cv.MOTA;
                SetCheckedItems(cbeNGUOITHUCHIEN, cv.NGUOITHUCHIEN);
                SetCheckedItems(cbeNGUOIGIAOVIEC, cv.NGUOIGIAOVIEC);
                SetCheckedItems(cbeNGUOITHEODOI, cv.NGUOITHEODOI);

            }
        }
        private void SetCheckedItems(CheckedComboBoxEdit comboBox, string selectedItems)
        {
            // Chia chuỗi các ID thành một mảng
            var items = selectedItems.Split(',');

            // Bỏ chọn tất cả các mục trước khi thiết lập lại
            for (int i = 0; i < comboBox.Properties.Items.Count; i++)
            {
                comboBox.Properties.Items[i].CheckState = CheckState.Unchecked;
            }

            // Thiết lập trạng thái được chọn cho từng mục
            foreach (var item in items)
            {
                for (int i = 0; i < comboBox.Properties.Items.Count; i++)
                {
                    if (comboBox.Properties.Items[i].Value.ToString() == item)
                    {
                        comboBox.Properties.Items[i].CheckState = CheckState.Checked;
                        break;
                    }
                }
            }
        }
    }
}