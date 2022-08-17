CREATE TABLE [dbo].[Holidays]
(
	[HolidayReference] INT NOT NULL PRIMARY KEY, 
    [HotelName] VARCHAR(60) NOT NULL, 
    [City] VARCHAR(60) NULL, 
    [Continent] VARCHAR(20) NOT NULL, 
    [Country] VARCHAR(60) NOT NULL, 
    [Category] VARCHAR(20) NOT NULL, 
    [StarRating] INT NULL, 
    [TempRating] VARCHAR(10) NOT NULL, 
    [Location] VARCHAR(10) NOT NULL, 
    [PricePerNight] MONEY NOT NULL
)