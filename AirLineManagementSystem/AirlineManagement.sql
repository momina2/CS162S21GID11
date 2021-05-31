USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 31/05/2021 9:17:06 am ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 31/05/2021 9:17:07 am ******/
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
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Kazakhstan', N'Pakistan  ', N'PIA       ', N'          ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Karachi   ', N'Lahore    ', N'PIA       ', N'PIA       ')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123      ', N'Karachi   ', N'Lahore    ', N'IDK       ', N'Domestic  ')
GO
