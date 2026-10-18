# Bài tập 2.2 — Ca kiểm thử và minh chứng

Thư mục này bổ sung các file mô tả ca kiểm thử và ảnh minh chứng vào repository nhóm.

## Cấu trúc

- `kiem-thu/txt_ca1.txt` đến `txt_ca8.txt`: mô tả TC01–TC08, các bước và kết quả mong đợi.
- `minh-chung/TC01-...` đến `minh-chung/TC08-...`: ảnh được tách ra từ gói minh chứng đã cung cấp và đặt cạnh ca tương ứng.
- `minh-chung/kiem-tra-bo-sung/`: ảnh bổ sung về kiểm thử đăng nhập và đối chiếu dữ liệu/hash trong SQL Server.

## Ánh xạ ảnh chính

| Ca | Ảnh |
|---|---|
| TC01 | `minh-chung/TC01-dang-ky-thanh-cong/tc01-dang-ky-thanh-cong.webp` |
| TC02 | `minh-chung/TC02-ten-dang-nhap-trung/tc02-ten-dang-nhap-trung.webp` |
| TC03 | `minh-chung/TC03-xac-nhan-mat-khau-lech/tc03-xac-nhan-mat-khau-lech.webp` |
| TC04 | `minh-chung/TC04-bo-trong-truong-bat-buoc/tc04-bo-trong-ten-dang-nhap.webp` |
| TC05 | `minh-chung/TC05-dang-nhap-thanh-cong/tc05-trang-chinh-sau-dang-nhap.webp` |
| TC06 | `minh-chung/TC06-mat-khau-sai/tc06-dang-nhap-sai-mat-khau.webp` |
| TC07 | `minh-chung/TC07-tai-khoan-khong-ton-tai/tc07-tai-khoan-khong-ton-tai.webp` |
| TC08 | `minh-chung/TC08-mat-ket-noi-sql-server/` (ảnh lúc dịch vụ dừng và ảnh sau khi khởi động lại) |

## Lưu ý về tính chính xác của minh chứng

- Ảnh đang có là ảnh chụp được cung cấp, không bị dựng lại hoặc chỉnh sửa nội dung. Tên file đã được chuẩn hoá để dễ tìm trong Git.
- Ảnh TC07 hiện cho thấy ô mật khẩu đang để trống. Nếu cần minh chứng chặt chẽ cho trường hợp *tài khoản không tồn tại* độc lập với trường hợp thiếu mật khẩu, hãy chạy lại ca với một mật khẩu bất kỳ được nhập đầy đủ rồi thay ảnh bằng ảnh chụp mới.
- Ba ảnh trong `kiem-tra-bo-sung` gồm trạng thái đăng nhập khi để trống mật khẩu và ảnh truy vấn SQL để kiểm tra thông tin tài khoản/hash/salt. Chúng là ảnh bổ sung, không thay thế các ảnh TC01–TC08.
- Tên đăng nhập thể hiện trong ảnh là tài khoản thử nghiệm. Không đưa dữ liệu người dùng thật hoặc thông tin bí mật vào repository công khai.
- Trong `txt_ca1.txt`, `txt_ca5.txt` và `txt_ca8.txt`, mật khẩu được mô tả là giá trị thử nghiệm đã dùng khi đăng ký; không ghi mật khẩu thực vào file công khai.

Chỉ đánh dấu ca là **ĐẠT** sau khi đối chiếu kết quả thực tế theo các bước mô tả.
