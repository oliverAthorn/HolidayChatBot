CREATE PROCEDURE [dbo].[spHolidays_Insert]
	@HolidayReference INT,
	@HotelName VARCHAR(60),
	@City VARCHAR(60),
	@Continent VARCHAR(20),
	@Country VARCHAR(60), 
	@Category VARCHAR(20),
	@StarRating INT NULL,
	@TempRating VARCHAR(20),
	@Location VARCHAR(10),
	@PricePerNight MONEY 

AS
BEGIN
	INSERT INTO dbo.Holidays (
	HolidayReference,
	HotelName,
	City,
	Continent,
	Country,
	Category,
	StarRating,
	TempRating,
	Location,
	PricePerNight)

	VALUES (
	@HolidayReference,
	@HotelName,
	@City,
	@Continent,
	@Country,
	@Category,
	@StarRating,
	@TempRating,
	@Location,
	@PricePerNight);
END