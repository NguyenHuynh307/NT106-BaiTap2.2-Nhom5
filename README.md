# NT106 – Bài tập 2.2 – Nhóm 5

## 1. Mục tiêu

Hiện thực ứng dụng quản lý người dùng bằng C# Windows Forms, sử dụng SQL Server để đăng ký và đăng nhập theo đề Bài tập 2.2 môn Lập trình mạng căn bản.

## 2. Phạm vi

Repository này dành riêng cho Bài tập 2.2, không phải repository sản phẩm đồ án cuối kỳ.

Theo PDF 2.2, ứng dụng bài tập kết nối trực tiếp tới SQL Server để giảm khối lượng triển khai. Mã truy vấn cơ sở dữ liệu phải được tách khỏi hàm xử lý sự kiện của giao diện.

Đối với đồ án cuối kỳ Hệ thống tra cứu triệu chứng và thông tin sức khỏe, client giao tiếp với server qua mạng; chỉ server được truy cập cơ sở dữ liệu.

Không tự ý đẩy mã hoặc thực hiện thay đổi trên repository đồ án cuối kỳ:
https://github.com/phu529/Health_Information_Lockup_System

## 3. Yêu cầu chính theo PDF 2.2

- Có ba form: Đăng nhập, Đăng ký và Chính.
- Kiểm tra dữ liệu đầu vào; tên đăng nhập phải duy nhất ở cả chương trình và cơ sở dữ liệu.
- Mật khẩu phải được băm với salt riêng cho từng tài khoản; không lưu mật khẩu nguyên văn.
- Dùng bảng Users theo yêu cầu đề bài, bao gồm thông tin người dùng và thời điểm đăng nhập gần nhất.
- Mọi câu lệnh SQL phải dùng tham số; mã truy vấn được tách thành lớp truy cập dữ liệu.
- Xử lý lỗi bằng thông báo tiếng Việt dễ hiểu; ứng dụng không được kết thúc bất thường khi SQL Server không sẵn sàng.
- Chạy và ghi nhận kết quả thực tế các ca kiểm thử trước khi hoàn tất báo cáo.

## 4. Môi trường

- Windows và Visual Studio có workload .NET desktop development.
- .NET SDK phù hợp với phiên bản TargetFramework trong file .csproj.
- SQL Server và SQL Server Management Studio (SSMS).
- Git for Windows.

## 5. Quy ước cấu hình và dữ liệu

- Script tạo cơ sở dữ liệu phải được rà soát, thống nhất tên database và có hướng dẫn chạy.
- Cấu hình kết nối riêng của máy phát triển phải lưu cục bộ, không đưa thông tin xác thực lên Git.
- Có thể dùng appsettings.example.json làm mẫu cấu hình; không thay mẫu bằng cấu hình chứa thông tin thật.
- Không commit thư mục bin/, obj/, file build, database cục bộ hoặc bản sao lưu.
- Không ghi mật khẩu, token, API key hay thông tin xác thực vào mã nguồn hoặc nhật ký.

## 6. Quy trình phối hợp Git

- Mỗi thành viên thực hiện đúng phần việc được phân công, ưu tiên nhánh riêng cho từng nhiệm vụ.
- Trước khi tích hợp, phải xem danh sách file thay đổi và kiểm tra xung đột.
- Không ghi đè file do thành viên khác phụ trách.
- Chỉ đưa thay đổi lên main sau khi rà soát mã nguồn, cấu hình, kiểm thử và xác nhận phạm vi.

## 7. Trạng thái hoàn thành

Không đánh dấu chức năng hoặc ca kiểm thử là hoàn thành khi chưa có kết quả kiểm tra thực tế. Các lỗi, thay đổi thiết kế và kết quả kiểm thử phải được ghi nhận trong tài liệu báo cáo/nhật ký của nhóm.
