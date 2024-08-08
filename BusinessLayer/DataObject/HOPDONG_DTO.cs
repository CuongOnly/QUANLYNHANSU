using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class HOPDONG_DTO
    {
        public string SOHD { get; set; }
        public string HOTEN { get; set; }
        public string DIENTHOAI {  get; set; }
        public string CCCD { get; set; }
        public string DIACHI {  get; set; }

        public string NGAYBATDAU { get; set; }
        public string NGAYKETTHUC { get; set; }
        public string NGAYKY { get; set; }
        public string NOIDUNG { get; set; }
        public string NGAYSINH { get; set; }
        public Nullable<int> LANKY { get; set; }
        public string THOIHAN { get; set; }
        public Nullable<double> HESOLUONG { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> MACTY { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }

    }
}
