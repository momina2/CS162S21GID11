USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 03/06/2021 3:56:30 am ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 03/06/2021 3:56:30 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allFlights](
	[FlightCode] [nchar](10) NOT NULL,
	[Source] [nchar](10) NOT NULL,
	[Destination] [nchar](10) NOT NULL,
	[AirLine] [nchar](10) NOT NULL,
	[FlightType] [nchar](50) NOT NULL,
	[TimeTravel] [nchar](10) NULL,
	[Date] [datetime] NULL,
	[LuggageAllowance] [nchar](10) NULL,
	[LayOver] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeData]    Script Date: 03/06/2021 3:56:30 am ******/
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
/****** Object:  Table [dbo].[PassengerInfo]    Script Date: 03/06/2021 3:56:30 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassengerInfo](
	[Name] [nchar](50) NOT NULL,
	[Passport] [nvarchar](50) NOT NULL,
	[CNIC] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Ticket] [nvarchar](50) NOT NULL,
	[Payment] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#123325   ', N'Lahore    ', N'Karachi   ', N'IDK       ', N'Domestic  ', NULL, NULL, NULL, NULL)
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#C276     ', N'Karachi   ', N'Lahore    ', N'IDK       ', N'Domestic  ', N'12        ', CAST(N'2021-06-24T00:00:00.000' AS DateTime), N'45        ', NULL)
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#D490     ', N'Quetta    ', N'Lahore    ', N'IDK       ', N'Domestic  ', N'12        ', CAST(N'2021-06-24T00:00:00.000' AS DateTime), N'45        ', NULL)
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#A358     ', N'Sialkot   ', N'Skardu    ', N'WTF       ', N'Domestic  ', N'23        ', CAST(N'2021-06-24T00:00:00.000' AS DateTime), N'43        ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#V154     ', N'Karachi   ', N'Khuzdar   ', N'WTF       ', N'Domestic  ', N'98        ', CAST(N'2021-06-17T00:00:00.000' AS DateTime), N'987       ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#A123     ', N'Japan     ', N'Turkey    ', N'WTF       ', N'          ', N'098       ', CAST(N'2021-06-23T00:00:00.000' AS DateTime), N'789       ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#N442     ', N'Karachi   ', N'Peshawar  ', N'PIA       ', N'Domestic  ', N'89        ', CAST(N'2021-06-24T00:00:00.000' AS DateTime), N'89        ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType], [TimeTravel], [Date], [LuggageAllowance], [LayOver]) VALUES (N'#P383     ', N'Lesotho   ', N'Japan     ', N'PIA       ', N'Domestic  ', N'89        ', CAST(N'2021-06-22T00:00:00.000' AS DateTime), N'89        ', N'          ')
GO
INSERT [dbo].[EmployeeData] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (1234, N'khadija', N'khadijadar345@gmail.com', N'098765', N'1234')
GO
INSERT [dbo].[PassengerInfo] ([Name], [Passport], [CNIC], [Phone], [Email], [Ticket], [Payment]) VALUES (N'keeri     ', N'7654', N'876', N'098', N'keeri@gmail.com', N'#A001599', NULL)
INSERT [dbo].[PassengerInfo] ([Name], [Passport], [CNIC], [Phone], [Email], [Ticket], [Payment]) VALUES (N'kjhg      ', N'hgf', N'ffhh', N'jjg', N'jjhgg', N'#A001524', NULL)
GO
