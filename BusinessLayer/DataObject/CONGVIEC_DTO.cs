using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class CONGVIEC_DTO
    {
        public int MACONGVIEC { get; set; }
        public string TENCONGVIEC { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string NGUOITHUCHIEN { get; set; }
        public string NGUOIGIAOVIEC { get; set; }
        public string NGUOITHEODOI { get; set; }
        public string DOUUTIEN { get; set; }
        public string LOAICONGVIEC { get; set; }
        public string TIENTRIEN { get; set; }
        public string MOTA { get; set; }
        public byte[] FILEEXP { get; set; }
        public Nullable<int> MANV { get; set; }
    }
}
