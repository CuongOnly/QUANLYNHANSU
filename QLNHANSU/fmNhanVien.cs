using BusinessLayer;
using BusinessLayer.DataObject;
using DataLayer;
using DevExpress.XtraEditors;
using QLNHANSU.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLNHANSU
{
    public partial class fmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public fmNhanVien()
        {
            InitializeComponent();
        }
       private NHANVIEN _nhanvien;
        private DANTOC _dantoc;
        private TONGIAO _tongiao;
        private CHUCVU _chucvu;
        private TRINHDO _trinhdo;
        private PHONGBAN _phongban;
        private BOPHAN _bophan;
        private bool _them;
        private int _id;
        private Image _hinh;
        List<NHANVIEN_DTO> _lstNVDTO;

        private void fmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
             _dantoc= new DANTOC();
             _tongiao = new TONGIAO();
             _chucvu = new CHUCVU();
             _trinhdo = new TRINHDO();
             _phongban = new PHONGBAN();
             _bophan = new BOPHAN();
            _showHide(true);
            loadData();
            loadCombo();
            // ẩn panel 1
            splitContainer1.Panel1Collapsed = true;
        }

        // load bảng nhan viên
       
        void loadCombo()
        {
            cboBoPhan.DataSource = _bophan.getList();
            cboBoPhan.DisplayMember = "TENBP";
            cboBoPhan.ValueMember = "IDBP";

            cboPhongBan.DataSource = _phongban.getList();
            cboPhongBan.DisplayMember = "TENPB";
            cboPhongBan.ValueMember = "IDPB";

            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TENTD";
            cboTrinhDo.ValueMember = "IDTD";

            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "IDCV";

            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TENDT";
            cboDanToc.ValueMember = "ID";

            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TENTG";
            cboTonGiao.ValueMember = "ID";
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtHoten.Enabled = !kt;
            txtHoten.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDT.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            cboBoPhan.Enabled = !kt;
            cboPhongBan.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            //picHinhAnh.Image = Properties.Resources.noimage;
            gcDanhSach.Enabled = kt;
        }

        void _reset()
        {
            txtHoten.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            chkGioiTinh.Checked = false;

        }
        void loadData()
        {
            //gcDanhSach.DataSource = _nhanvien.getList();
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            // lấy ds gán vào Print
            _lstNVDTO = _nhanvien.getListFull();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            //mở panel nhập
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            picHinhAnh.Image = _hinh;
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
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
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);// lấy được ds
            // gọi chúng ra show lớn
            rpt.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtHoten.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtDT.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.MACTY = 2;

                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtHoten.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtDT.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                _nhanvien.Update(nv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.FocusedRowHandle >= 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtHoten.Text = nv.HOTEN;
                chkGioiTinh.Checked = nv.GIOITINH.Value;
                dtNgaySinh.Value = nv.NGAYSINH.Value;
                txtDT.Text = nv.DIENTHOAI;
                txtCCCD.Text = nv.CCCD;
                txtDiaChi.Text = nv.DIACHI;
                picHinhAnh.Image = Base64ToImage(nv.HINHANH);
                cboBoPhan.SelectedValue = nv.IDBP;
                cboPhongBan.SelectedValue = nv.IDPB;
                cboTrinhDo.SelectedValue = nv.IDTD;
                cboChucVu.SelectedValue = nv.IDCV;
                cboDanToc.SelectedValue = nv.IDDT;
                cboTonGiao.SelectedValue = nv.IDTG;
            }
        }

        // giải mã hình ảnh
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        // giải mã hình ảnh
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg) |*.png;*.jpg ";
            openFile.Title = "Chọn hình ảnh";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}