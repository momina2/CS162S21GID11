USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 01/06/2021 10:54:48 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirlineData](
	[AirlineCode] [nchar](10) NULL,
	[AirlineName] [nchar](10) NULL,
	[Status] [nchar](10) NULL,
	[Description] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[allFlights]    Script Date: 01/06/2021 10:54:49 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allFlights](
	[FlightCode] [nchar](10) NOT NULL,
	[Source] [nchar](10) NOT NULL,
	[Destination] [nchar](10) NOT NULL,
	[AirLine] [nchar](10) NOT NULL,
	[FlightType] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeData]    Script Date: 01/06/2021 10:54:49 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeData](
	[ID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Phone#] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123A339  ', N'Khuzdar   ', N'Peshawar  ', N'IDK       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123325   ', N'Lahore    ', N'Karachi   ', N'IDK       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123D124  ', N'faisalabad', N'islamabad ', N'PIA       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123H436  ', N'Skardu    ', N'Rawalpindi', N'PIA       ', N'Domestic  ')
GO
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (123344, N'Momina', N'03330605515', N'3456', N'mmkmk')
GO
