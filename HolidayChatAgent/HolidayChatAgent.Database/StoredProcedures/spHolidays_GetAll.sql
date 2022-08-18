CREATE PROCEDURE dbo.[spHolidays_GetAll]
AS
begin
	SELECT HolidayReference, HotelName, City, Continent, Country, Category, StarRating, TempRating, Location, PricePerNight
	FROM dbo.Holidays;
end
