GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/06/2018 4:33:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoTen] [nvarchar](30) NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/06/2018 4:33:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[GioiTinh] [tinyint] NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[MaPhong] [varchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/06/2018 4:33:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhong] [varchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi]) VALUES (1, N'dangbq', N'123456', N'Bùi Quang Đăng', NULL, NULL, NULL)
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi]) VALUES (2, N'admin', N'123', N'Quản trị hệ thống', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF001', N'Đồng Văn Thư', 0, CAST(0x781B0B00 AS Date), N'0988235689', N'thudv@gmail.com', N'Hà Nội', N'KD')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF002', N'Nguyễn Ngọc Nam', 0, CAST(0x611D0B00 AS Date), N'0982456890', N'namnn@gmail.com', N'Hải Dương', N'CNTT')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF003', N'Nguyễn Trần An', 1, CAST(0x811D0B00 AS Date), N'0904567892', N'annt@gmail.com', N'Nam Định', N'CNTT')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF004', N'Trần Thanh Hà', 1, CAST(0x9E160B00 AS Date), N'0904235689', N'hatt@gmail.com', N'Từ Liêm, Hà Nội', N'TT')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF005', N'Ngô Bích Ngọc', 1, CAST(0x03140B00 AS Date), N'0985468125', N'bichngoc@gmail.com', N'Hải Phòng', N'KT')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF006', N'Trần Nam Phương', 1, CAST(0x42140B00 AS Date), N'0908456896', N'namphuong@gmail.com', N'Hà Nội, Cầu Giấy', N'KD')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong]) VALUES (N'DT', N'Đào tạo')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong]) VALUES (N'KD', N'Kinh doanh')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong]) VALUES (N'KT', N'Kế toán')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong]) VALUES (N'TT', N'Truyền thông')

select*from NguoiDung;
