USE [master]
GO
/****** Object:  Table [dbo].[proje]    Script Date: 22.10.2022 14:29:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proje](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[re_password] [varchar](50) NULL,
	[e_mail] [varchar](50) NULL,
	[phone] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[proje] ([username], [password], [re_password], [e_mail], [phone]) VALUES (N'admin          ', N'pass           ', N'pass           ', N'email                              ', N'55555          ')
INSERT [dbo].[proje] ([username], [password], [re_password], [e_mail], [phone]) VALUES (N'cngzhnclskn    ', N'107530c        ', N'107530c        ', N'cngzhnc06@gmail.com                ', N'5519714577     ')
INSERT [dbo].[proje] ([username], [password], [re_password], [e_mail], [phone]) VALUES (N'cengizcaliskan ', N'060606         ', N'060606         ', N'hccoptikaraclar@gmail.com          ', N'5444526686     ')
INSERT [dbo].[proje] ([username], [password], [re_password], [e_mail], [phone]) VALUES (N'mustafa', N'mustafa', N'mustafa', N'mustafakacar48@outlook.com.tr', N'5555555555')
INSERT [dbo].[proje] ([username], [password], [re_password], [e_mail], [phone]) VALUES (N'cengizhan', N'123456', N'123456', N'cngzhnmt3@gmail.com', N'5555154545')
GO
