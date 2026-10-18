# NT106 – Bài tập 2.2 – Nhóm 5

Ứng dụng quản lý người dùng bằng **C# Windows Forms** và **SQL Server**, có chức năng đăng ký và đăng nhập. Môn Lập trình mạng căn bản (NT106).

## Chức năng

- Đăng ký tài khoản mới
- Đăng nhập
- Trang chính hiển thị thông tin người dùng
- Mật khẩu được băm trước khi lưu, không lưu nguyên văn

## Thành viên

| Thành viên | Vai trò | Phần việc |
|---|---|---|
| Huỳnh Thanh Nguyên | Nhóm trưởng | Tạo project, kiểm thử, báo cáo, tích hợp và nộp bài |
| Huỳnh Vĩnh Phú | Thành viên | Cơ sở dữ liệu, băm mật khẩu |
| Nguyễn Quốc Nhật Minh | Thành viên | Giao diện ba form |
| Hoàng Anh | Thành viên | Lớp truy cập dữ liệu |
| Lê Trọng Phú | Thành viên | Xử lý nút Đăng ký, Đăng nhập |

## Cấu trúc

```
├── databaseUser.sql               Script tạo cơ sở dữ liệu
└── src/QuanLyNguoiDung/
    ├── Frm*.cs                    Các form giao diện
    ├── Data/                      Truy cập cơ sở dữ liệu
    ├── security/                  Xử lý mật khẩu
    └── appsettings.example.json   Mẫu cấu hình
```
## Cách chạy

1. Chạy `databaseUser.sql` trong SQL Server Management Studio.
2. Sao chép `appsettings.example.json` thành `appsettings.json` và sửa tên server cho đúng máy.
3. Mở file `.sln` bằng Visual Studio và nhấn F5.

> Yêu cầu: Windows, Visual Studio, .NET SDK, SQL Server. File `appsettings.json` chỉ lưu trên máy cá nhân, không đưa lên Git.

## Ghi chú

- Repository chỉ dành cho Bài tập 2.2, không phải sản phẩm đồ án cuối kỳ.
- Nhánh `main` được bảo vệ, mọi thay đổi đi qua Pull Request và do nhóm trưởng duyệt.