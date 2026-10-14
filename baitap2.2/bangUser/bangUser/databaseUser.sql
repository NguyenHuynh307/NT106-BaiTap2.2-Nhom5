if DB_ID(N'healthInforDB') is null
	create database healthInforDB;
go
use healthInforDB;
go
if OBJECT_ID (N'dbo.User') is null
begin
	create table Users
	(
	UserID int identity(1,1) primary key,
	TenDangNhap nvarchar(20) not null unique,
	MatKhauBam nvarchar(64) not null ,
	Salt nvarchar(32) not null,
	HoTen nvarchar(50) not null,
	Email nvarchar(100) null,
	NgayTao datetime2 not null default sysdatetime(),
	LanDangNhapCuoi datetime2 null

	);

end;
go 

if NOT EXISTS (
    select 1 from dbo.Users
    where TenDangNhap = N'thu_nghiem'
)
begin
    insert into dbo.Users (TenDangNhap, MatKhauBam, Salt, HoTen)
    values (N'thu_nghiem', N'hash_thu_nghiem', N'salt_thu_nghiem',
            N'Người dùng thử');
end;
go

select * from dbo.Users
where TenDangNhap = N'thu_nghiem';


