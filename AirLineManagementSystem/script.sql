USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 6/1/2021 6:11:46 PM ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 6/1/2021 6:11:46 PM ******/
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
/****** Object:  Table [dbo].[EmployeeData]    Script Date: 6/1/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeData](
	[ID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Phone#] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Kazakhstan', N'Pakistan  ', N'PIA       ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Karachi   ', N'Lahore    ', N'PIA       ', N'PIA       ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Karachi   ', N'Lahore    ', N'IDK       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123274   ', N'London    ', N'Lahore    ', N'PIA       ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123325   ', N'Lahore    ', N'Karachi   ', N'IDK       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123D124  ', N'faisalabad', N'islamabad ', N'PIA       ', N'Domestic  ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123H436  ', N'Skardu    ', N'Rawalpindi', N'PIA       ', N'Domestic  ')
GO
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (12, N'as', N'12', N'12')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (123, N'Ali', N'3520283910372', N'03217722573')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (123, N'ali', N'3520265974088', N'03008811400')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (123, N'ali', N'3520252946104', N'03442288166')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (456, N'Muhammad Khan', N'3520262945284', N'03417739204')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (123, N'scd', N'12', N'12')
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC]) VALUES (789, N'momina', N'35202-65974088', N'03008811400')
GO
