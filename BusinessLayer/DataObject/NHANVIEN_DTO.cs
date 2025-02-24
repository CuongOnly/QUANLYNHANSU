﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    //khi add dữ liệu dân tộc, tôn giáo, bộ phận,,... sẽ trắng không lấy được thì cần
    // hứng dữ liệu từ add nhân viên, lấy data ở QLNS entities

    // sau đó nó được dùng trong class NHANVIEN
    public class NHANVIEN_DTO
    {
        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<int> IDPB { get; set; }
        public string TENPB { get; set; }
        public Nullable<int> IDBP { get; set; }
        public string TENBP { get; set; }

        public Nullable<int> IDCV { get; set; }
        public string TENCV { get; set; }

        public Nullable<int> IDTD { get; set; }
        public string TENTD { get; set; }

        public Nullable<int> MACTY { get; set; }

        public Nullable<int> IDDT { get; set; }
        public string TENDT { get; set; }

        public Nullable<int> IDTG { get; set; }
        public string TENTG { get; set; }

    }
}
