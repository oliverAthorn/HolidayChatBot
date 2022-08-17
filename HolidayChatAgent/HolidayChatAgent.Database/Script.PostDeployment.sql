if not exists (select 1 from dbo.Holidays)
begin
	insert into dbo.Holidays(
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

	values 
	(1, 'Uptown', 'Bali', 'Asia', 'Indonesia', 'active', 3, 'mild', 'mountain', 120);
end