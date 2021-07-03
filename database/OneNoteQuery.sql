USE [one_NoteDataSet]
GO

/****** Object:  Table [dbo].[OneTab]    Script Date: 7/3/2021 9:26:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OneTab](
	[Title] [varchar](50) NOT NULL,
	[Message] [varchar](500) NOT NULL,
	[Time_date] [varchar](50) NULL,
	[Last_Modified] [varchar](50) NULL
) ON [PRIMARY]
GO


