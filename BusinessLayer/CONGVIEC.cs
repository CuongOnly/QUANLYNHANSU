using BusinessLayer.DataObject;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGVIEC
    {
        QLYNHANSUEntities db = new QLYNHANSUEntities();

        public tb_CONGVIEC getItem (int id)
        {
            return db.tb_CONGVIEC.FirstOrDefault(x => x.MACONGVIEC == id);
        }
        public List<tb_CONGVIEC> getList()
        {
            return db.tb_CONGVIEC.ToList();
        }
        public List<CONGVIEC_DTO> getListFull()
        {
            var lsCV = db.tb_CONGVIEC.ToList();
            List<CONGVIEC_DTO> lstCVDTO = new List<CONGVIEC_DTO>();
            CONGVIEC_DTO cvDTO;
            foreach(var item in lsCV)
            {
                cvDTO = new CONGVIEC_DTO();
                cvDTO.MACONGVIEC = item.MACONGVIEC;
                cvDTO.TENCONGVIEC = item.TENCONGVIEC;
                cvDTO.NGAYBATDAU = item.NGAYBATDAU;
                cvDTO.NGAYKETTHUC = item.NGAYKETTHUC;
                cvDTO.DOUUTIEN =item.DOUUTIEN;
                cvDTO.LOAICONGVIEC = item.LOAICONGVIEC;
                cvDTO.TIENTRIEN = item.TIENTRIEN;
                cvDTO.MOTA = item.MOTA;
                cvDTO.FILEEXP = item.FILEEXP;
                cvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                cvDTO.NGUOITHUCHIEN = nv.HOTEN;
                cvDTO.NGUOIGIAOVIEC = nv.HOTEN;
                cvDTO.NGUOITHEODOI = nv.HOTEN;
                lstCVDTO.Add(cvDTO);
            }
            return lstCVDTO;
        }
        public tb_CONGVIEC Add(tb_CONGVIEC cv)
        {
            try
            {
                db.tb_CONGVIEC.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public tb_CONGVIEC Update(tb_CONGVIEC cv)
        {
            try
            {
                var _cv = db.tb_CONGVIEC.FirstOrDefault(v => v.MACONGVIEC == cv.MACONGVIEC);
                _cv.TENCONGVIEC = cv.TENCONGVIEC;
                _cv.MACONGVIEC = cv.MACONGVIEC;
                _cv.TENCONGVIEC = cv.TENCONGVIEC;
                _cv.NGAYBATDAU = cv.NGAYBATDAU;
                _cv.NGAYKETTHUC = cv.NGAYKETTHUC;
                _cv.DOUUTIEN = cv.DOUUTIEN;
                _cv.LOAICONGVIEC = cv.LOAICONGVIEC;
                _cv.TIENTRIEN = cv.TIENTRIEN;
                _cv.MOTA = cv.MOTA;
                _cv.FILEEXP = cv.FILEEXP;
                _cv.MANV = cv.MANV;
                _cv.NGUOITHUCHIEN = cv.NGUOITHUCHIEN;
                _cv.NGUOIGIAOVIEC = cv.NGUOIGIAOVIEC;
                _cv.NGUOITHEODOI = cv.NGUOITHEODOI;
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _cv = db.tb_CONGVIEC.FirstOrDefault(v=>v.MACONGVIEC == id);
                db.tb_CONGVIEC.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
