//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NHANVIEN()
        {
            this.tb_BANGCONG = new HashSet<tb_BANGCONG>();
            this.tb_BAOHIEM = new HashSet<tb_BAOHIEM>();
            this.tb_KHENTHUONG_KYLUAT = new HashSet<tb_KHENTHUONG_KYLUAT>();
            this.tb_NHANVIEN_PHUCAP = new HashSet<tb_NHANVIEN_PHUCAP>();
            this.tb_TANGCA = new HashSet<tb_TANGCA>();
            this.tb_UNGLUONG = new HashSet<tb_UNGLUONG>();
            this.tb_HOPDONG = new HashSet<tb_HOPDONG>();
            this.tb_CONGVIEC = new HashSet<tb_CONGVIEC>();
        }
    
        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<int> IDPB { get; set; }
        public Nullable<int> IDBP { get; set; }
        public Nullable<int> IDCV { get; set; }
        public Nullable<int> IDTD { get; set; }
        public Nullable<int> MACTY { get; set; }
        public Nullable<int> IDDT { get; set; }
        public Nullable<int> IDTG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BANGCONG> tb_BANGCONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BAOHIEM> tb_BAOHIEM { get; set; }
        public virtual tb_BOPHAN tb_BOPHAN { get; set; }
        public virtual tb_CHUCVU tb_CHUCVU { get; set; }
        public virtual tb_CONGTY tb_CONGTY { get; set; }
        public virtual tb_DANTOC tb_DANTOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KHENTHUONG_KYLUAT> tb_KHENTHUONG_KYLUAT { get; set; }
        public virtual tb_PHONGBAN tb_PHONGBAN { get; set; }
        public virtual tb_TRINHDO tb_TRINHDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NHANVIEN_PHUCAP> tb_NHANVIEN_PHUCAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TANGCA> tb_TANGCA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_UNGLUONG> tb_UNGLUONG { get; set; }
        public virtual tb_TONGIAO tb_TONGIAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HOPDONG> tb_HOPDONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CONGVIEC> tb_CONGVIEC { get; set; }
    }
}
