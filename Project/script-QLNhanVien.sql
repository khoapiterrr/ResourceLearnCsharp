USE [CS051801CB]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 08/06/2018 4:24:39 PM ******/
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
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF001', N'Đồng Văn Thư', 0, CAST(0x781B0B00 AS Date), N'0988235689', N'thudv@gmail.com', N'Hà Nội', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF002', N'Nguyễn Ngọc Nam', 0, CAST(0x611D0B00 AS Date), N'0982456890', N'namnn@gmail.com', N'Hải Dương', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF003', N'Nguyễn Trần An', 1, CAST(0x811D0B00 AS Date), N'0904567892', N'annt@gmail.com', N'Nam Định', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF004', N'Trần Thanh Hà', 1, CAST(0x9E160B00 AS Date), N'0904235689', N'hatt@gmail.com', N'Từ Liêm, Hà Nội', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF005', N'Ngô Bích Ngọc', 1, CAST(0x03140B00 AS Date), N'0985468125', N'bichngoc@gmail.com', N'Hải Phòng', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF006', N'Trần Nam Phương', 1, CAST(0x42140B00 AS Date), N'0908456896', N'namphuong@gmail.com', N'Hà Nội, Cầu Giấy', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [MaPhong]) VALUES (N'SF007', N'Phạm Kim Chi', 0, CAST(0xAC100B00 AS Date), N'0988235689', N'kimchi1@gmail.com', N'Hà Nội 1', NULL)
