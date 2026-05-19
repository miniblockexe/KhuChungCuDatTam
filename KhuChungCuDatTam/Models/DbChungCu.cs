using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KhuChungCuDatTam.Models
{
    public partial class DbChungCu : DbContext
    {
        public DbChungCu()
            : base("name=DbChungCu")
        {
        }

        public virtual DbSet<audit_log> audit_log { get; set; }
        public virtual DbSet<bang_luong> bang_luong { get; set; }
        public virtual DbSet<bao_tri> bao_tri { get; set; }
        public virtual DbSet<can_ho> can_ho { get; set; }
        public virtual DbSet<cham_cong> cham_cong { get; set; }
        public virtual DbSet<chi_so_dien_nuoc> chi_so_dien_nuoc { get; set; }
        public virtual DbSet<cong_no> cong_no { get; set; }
        public virtual DbSet<cu_dan> cu_dan { get; set; }
        public virtual DbSet<dang_ky_dich_vu> dang_ky_dich_vu { get; set; }
        public virtual DbSet<danh_gia> danh_gia { get; set; }
        public virtual DbSet<dat_lich_tien_ich> dat_lich_tien_ich { get; set; }
        public virtual DbSet<dich_vu> dich_vu { get; set; }
        public virtual DbSet<hoa_don> hoa_don { get; set; }
        public virtual DbSet<hoa_don_chi_tiet> hoa_don_chi_tiet { get; set; }
        public virtual DbSet<hop_dong> hop_dong { get; set; }
        public virtual DbSet<khieu_nai> khieu_nai { get; set; }
        public virtual DbSet<nguoi_dung> nguoi_dung { get; set; }
        public virtual DbSet<phuong_tien> phuong_tien { get; set; }
        public virtual DbSet<quyen> quyens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tai_lieu> tai_lieu { get; set; }
        public virtual DbSet<tam_tru> tam_tru { get; set; }
        public virtual DbSet<thanh_toan> thanh_toan { get; set; }
        public virtual DbSet<thong_bao> thong_bao { get; set; }
        public virtual DbSet<thong_bao_cu_dan> thong_bao_cu_dan { get; set; }
        public virtual DbSet<tien_ich_chung> tien_ich_chung { get; set; }
        public virtual DbSet<toa_nha> toa_nha { get; set; }
        public virtual DbSet<vai_tro> vai_tro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<audit_log>()
                .Property(e => e.hanh_dong)
                .IsUnicode(false);

            modelBuilder.Entity<audit_log>()
                .Property(e => e.bang)
                .IsUnicode(false);

            modelBuilder.Entity<bang_luong>()
                .Property(e => e.luong_co_ban)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bang_luong>()
                .Property(e => e.thuong)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bang_luong>()
                .Property(e => e.khau_tru)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bang_luong>()
                .Property(e => e.tong_luong)
                .HasPrecision(17, 2);

            modelBuilder.Entity<bang_luong>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<bao_tri>()
                .Property(e => e.chi_phi)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bao_tri>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<can_ho>()
                .Property(e => e.so_can_ho)
                .IsUnicode(false);

            modelBuilder.Entity<can_ho>()
                .Property(e => e.dien_tich)
                .HasPrecision(10, 2);

            modelBuilder.Entity<can_ho>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.bao_tri)
                .WithOptional(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.chi_so_dien_nuoc)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.cong_no)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.cu_dan)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.dang_ky_dich_vu)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.hoa_don)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.hop_dong)
                .WithRequired(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<can_ho>()
                .HasMany(e => e.tai_lieu)
                .WithOptional(e => e.can_ho)
                .HasForeignKey(e => e.can_ho_id);

            modelBuilder.Entity<cham_cong>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<chi_so_dien_nuoc>()
                .Property(e => e.chi_so_dien_cu)
                .HasPrecision(10, 2);

            modelBuilder.Entity<chi_so_dien_nuoc>()
                .Property(e => e.chi_so_dien_moi)
                .HasPrecision(10, 2);

            modelBuilder.Entity<chi_so_dien_nuoc>()
                .Property(e => e.chi_so_nuoc_cu)
                .HasPrecision(10, 2);

            modelBuilder.Entity<chi_so_dien_nuoc>()
                .Property(e => e.chi_so_nuoc_moi)
                .HasPrecision(10, 2);

            modelBuilder.Entity<cong_no>()
                .Property(e => e.so_tien_no)
                .HasPrecision(15, 2);

            modelBuilder.Entity<cong_no>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<cu_dan>()
                .Property(e => e.so_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<cu_dan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cu_dan>()
                .Property(e => e.cmnd_cccd)
                .IsUnicode(false);

            modelBuilder.Entity<cu_dan>()
                .Property(e => e.loai_cu_dan)
                .IsUnicode(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.danh_gia)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.dat_lich_tien_ich)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.hop_dong)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.khieu_nai)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.phuong_tien)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.tai_lieu)
                .WithOptional(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.tam_tru)
                .WithOptional(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id);

            modelBuilder.Entity<cu_dan>()
                .HasMany(e => e.thong_bao_cu_dan)
                .WithRequired(e => e.cu_dan)
                .HasForeignKey(e => e.cu_dan_id);

            modelBuilder.Entity<dang_ky_dich_vu>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<dat_lich_tien_ich>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<dich_vu>()
                .Property(e => e.don_gia)
                .HasPrecision(12, 2);

            modelBuilder.Entity<dich_vu>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<dich_vu>()
                .HasMany(e => e.dang_ky_dich_vu)
                .WithRequired(e => e.dich_vu)
                .HasForeignKey(e => e.dich_vu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tien_dien)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tien_nuoc)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tien_gui_xe)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tien_bao_tri)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tien_phi_khac)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.tong_tien)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hoa_don>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<hoa_don>()
                .HasMany(e => e.cong_no)
                .WithOptional(e => e.hoa_don)
                .HasForeignKey(e => e.hoa_don_id);

            modelBuilder.Entity<hoa_don>()
                .HasMany(e => e.hoa_don_chi_tiet)
                .WithRequired(e => e.hoa_don)
                .HasForeignKey(e => e.hoa_don_id);

            modelBuilder.Entity<hoa_don>()
                .HasMany(e => e.thanh_toan)
                .WithRequired(e => e.hoa_don)
                .HasForeignKey(e => e.hoa_don_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hoa_don_chi_tiet>()
                .Property(e => e.loai)
                .IsUnicode(false);

            modelBuilder.Entity<hoa_don_chi_tiet>()
                .Property(e => e.so_luong)
                .HasPrecision(12, 2);

            modelBuilder.Entity<hoa_don_chi_tiet>()
                .Property(e => e.don_gia)
                .HasPrecision(12, 2);

            modelBuilder.Entity<hoa_don_chi_tiet>()
                .Property(e => e.thanh_tien)
                .HasPrecision(25, 4);

            modelBuilder.Entity<hop_dong>()
                .Property(e => e.loai_hop_dong)
                .IsUnicode(false);

            modelBuilder.Entity<hop_dong>()
                .Property(e => e.gia_tri_hop_dong)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hop_dong>()
                .Property(e => e.tien_dat_coc)
                .HasPrecision(15, 2);

            modelBuilder.Entity<hop_dong>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<khieu_nai>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .Property(e => e.ten_dang_nhap)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .Property(e => e.mat_khau)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .Property(e => e.so_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.audit_log)
                .WithRequired(e => e.nguoi_dung)
                .HasForeignKey(e => e.nguoi_dung_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.bang_luong)
                .WithRequired(e => e.nguoi_dung)
                .HasForeignKey(e => e.nguoi_dung_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.bao_tri)
                .WithOptional(e => e.nguoi_dung)
                .HasForeignKey(e => e.nhan_vien_xu_ly_id);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.cham_cong)
                .WithRequired(e => e.nguoi_dung)
                .HasForeignKey(e => e.nguoi_dung_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.khieu_nai)
                .WithOptional(e => e.nguoi_dung)
                .HasForeignKey(e => e.nhan_vien_xu_ly_id);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.thanh_toan)
                .WithRequired(e => e.nguoi_dung)
                .HasForeignKey(e => e.nhan_vien_thu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nguoi_dung>()
                .HasMany(e => e.thong_bao)
                .WithRequired(e => e.nguoi_dung)
                .HasForeignKey(e => e.nguoi_gui_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<phuong_tien>()
                .Property(e => e.bien_so)
                .IsUnicode(false);

            modelBuilder.Entity<phuong_tien>()
                .Property(e => e.loai_xe)
                .IsUnicode(false);

            modelBuilder.Entity<phuong_tien>()
                .Property(e => e.phi_gui_thang)
                .HasPrecision(10, 2);

            modelBuilder.Entity<phuong_tien>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<quyen>()
                .Property(e => e.ten_quyen)
                .IsUnicode(false);

            modelBuilder.Entity<quyen>()
                .HasMany(e => e.vai_tro)
                .WithMany(e => e.quyens)
                .Map(m => m.ToTable("vai_tro_quyen"));

            modelBuilder.Entity<tai_lieu>()
                .Property(e => e.loai)
                .IsUnicode(false);

            modelBuilder.Entity<tam_tru>()
                .Property(e => e.cmnd_cccd)
                .IsUnicode(false);

            modelBuilder.Entity<tam_tru>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<thanh_toan>()
                .Property(e => e.so_tien)
                .HasPrecision(15, 2);

            modelBuilder.Entity<thanh_toan>()
                .Property(e => e.ma_phieu_thu)
                .IsUnicode(false);

            modelBuilder.Entity<thanh_toan>()
                .Property(e => e.phuong_thuc)
                .IsUnicode(false);

            modelBuilder.Entity<thong_bao>()
                .Property(e => e.loai)
                .IsUnicode(false);

            modelBuilder.Entity<thong_bao>()
                .HasMany(e => e.thong_bao_cu_dan)
                .WithRequired(e => e.thong_bao)
                .HasForeignKey(e => e.thong_bao_id);

            modelBuilder.Entity<tien_ich_chung>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<tien_ich_chung>()
                .HasMany(e => e.dat_lich_tien_ich)
                .WithRequired(e => e.tien_ich_chung)
                .HasForeignKey(e => e.tien_ich_id)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<toa_nha>()
                .Property(e => e.trang_thai)
                .IsUnicode(false);

            modelBuilder.Entity<toa_nha>()
                .HasMany(e => e.can_ho)
                .WithRequired(e => e.toa_nha)
                .HasForeignKey(e => e.toa_nha_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vai_tro>()
                .Property(e => e.ten_vai_tro)
                .IsUnicode(false);

            modelBuilder.Entity<vai_tro>()
                .HasMany(e => e.nguoi_dung)
                .WithRequired(e => e.vai_tro)
                .HasForeignKey(e => e.vai_tro_id)
                .WillCascadeOnDelete(false);
        }
    }
}
