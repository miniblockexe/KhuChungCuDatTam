# Dự án Quản lý Khu chung cư

Hệ thống quản lý thông tin dân cư, căn hộ và các dịch vụ đi kèm được phát triển bằng C# WinForms.

## Thành viên thực hiện

- **Trần Tâm** - Phát triển chính & Cấu trúc dự án.
- **Lê Nguyễn Trọng Đạt** - Phát triển tính năng & Quản lý cơ sở dữ liệu.

## Hướng dẫn cài đặt và chạy dự án

### 1. Yêu cầu hệ thống

- Visual Studio 2022 trở lên.
- .NET Framework.
- SQL Server Management Studio (SSMS).

### 2. Thiết lập Cơ sở dữ liệu (Database)

1. Mở **SQL Server Management Studio (SSMS)**.
2. Vào thư mục `SQL/` trong dự án, mở file `script.sql`.
3. Bấm **Execute (F5)** để khởi tạo các bảng và dữ liệu mẫu.

## Nếu Lỗi

### Cấu hình kết nối trong Visual Studio

1. Mở file giải pháp `.sln` bằng Visual Studio.
2. Tìm đến file cấu hình chuỗi kết nối (thường là `App.config` hoặc class cấu hình database).
3. Sửa chuỗi `ConnectionString` sao cho khớp với tên Server SQL trên máy của bạn:

   ```xml
   <add name="DbChungCu" connectionString="data source=.;initial catalog=BD_CHUNGCU;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
   ```
