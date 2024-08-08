using BusinessLayer.DataObject;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLYNHANSUEntities db = new QLYNHANSUEntities();
        public tb_HOPDONG getItem(string shd)
        {
            return db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == shd);
        }

        //public HOPDONG_DTO getItemFull(string sohd)
        //{
        //    var item = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        //    HOPDONG_DTO hd = new HOPDONG_DTO();
        //    hd.SOHD = item.SOHD;
        //    hd.NGAYBATDAU = item.NGAYBATDAU;
        //    hd.NGAYKETTHUC = item.NGAYKETTHUC;
        //    hd.NGAYKY = item.NGAYKY;
        //    hd.LANKY = item.LANKY;
        //    hd.HESOLUONG = item.HESOLUONG;
        //    hd.NOIDUNG = item.NOIDUNG;
        //    hd.THOIHAN = item.THOIHAN;
        //    hd.MANV = item.MANV;
        //    var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
        //    hd.HOTEN = nv.HOTEN;
        //    hd.CCCD = nv.CCCD;
        //    hd.DIENTHOAI = nv.DIENTHOAI;
        //    hd.DIACHI = nv.DIACHI;
        //    hd.CREATE_BY = item.CREATE_BY;
        //    hd.CREATE_DATE = item.CREATE_DATE;
        //    hd.UPDATED_BY = item.UPDATED_BY;
        //    hd.UPDATED_DATE = item.UPDATED_DATE;
        //    hd.DELETED_BY = item.DELETED_BY;
        //    hd.DELETED_DATE = item.DELETED_DATE;
        //    hd.MACTY = item.MACTY;

        //    return hd; // bước tiếp theo rptHĐLĐ
        //}
        //lấy gtri in
        public List<HOPDONG_DTO> getItemFull (string sohd)
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>x.SOHD==sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            // tu HOPDONG DTO lấy gtri đưa vào print
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                // cắt chuỗi
                // hd.NGAYBATDAU ="Từ ngày "+ item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(0,2) + "tháng" + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(3,2) + "năm" + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.THOIHAN = item.THOIHAN;
                hd.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                // data ban đầu là datetime ở DTO lấy string nên ở đây phải format lại khi in
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy"); 
                hd.CREATE_BY = item.CREATE_BY;
                hd.CREATE_DATE = item.CREATE_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public List<tb_HOPDONG> getList()
        {
            return db.tb_HOPDONG.ToList();
        }
        // hiện ở bảng giá trị
        public List<HOPDONG_DTO> getListFull()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            // tu HOPDONG DTO lấy gtri đưa vào print
            foreach(var item in lstHD){
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.ToString();
                hd.NGAYKETTHUC = item.NGAYKETTHUC.ToString();
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.THOIHAN = item.THOIHAN;
                hd.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n=>n.MANV== item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                hd.CREATE_BY = item.CREATE_BY;
                hd.CREATE_DATE = item.CREATE_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO; 
        }
        public tb_HOPDONG Add(tb_HOPDONG hd)
        {
            try
            {
                db.tb_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_HOPDONG Update(tb_HOPDONG hd)
        {
            try
            {
                var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.MANV = hd.MANV;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.NOIDUNG =   hd.NOIDUNG;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.SOHD = hd.SOHD;
                _hd.MACTY = hd.MACTY;
                _hd.UPDATED_BY = hd.UPDATED_BY;
                _hd.UPDATED_DATE = hd.UPDATED_DATE;

                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // người xóa và id cần xóa
        public void Delete(string shd, int manv)
        {
            var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == shd);
            _hd.DELETED_BY = manv;
            _hd.DELETED_DATE = DateTime.Now;
            db.SaveChanges();
        }
        public string MaxSoHopDong()
        {
            // Orderby cho ngày giảm dần -> FirstOrDefault lấy cái đầu tiên
            // khác null thì lấy SOHD ko có SOHD đưa về 00001
            var _hd = db.tb_HOPDONG.OrderByDescending(x=>x.CREATE_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
                return "00000";
        }
    }
}
