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
	(1,'Uptown','Bali','Asia','Indonesia','active',3,'mild','mountain',120),
	(2,'Relaxamax','NewOrleans','NorthAmerica','USA','lazy',4,'mild','city',28),
	(3,'WindyBeach','Ventry','Europe','Ireland','active',3,'mild','sea',42),
	(4,'Twighlight','Marrakech','Africa','Morocco','lazy',5,'cold','mountain',50),
	(5,'TooHot','Sydney','Australia','Australia','lazy',5,'hot','sea',67),
	(6,'Castaway','','Africa','TheMaldives','lazy',3,'mild','sea',120),
	(7,'EiffelPark','Paris','Europe','France','active',4,'mild','city',45),
	(8,'TheCape','CapeTown','Africa','SouthAfrica','active',4,'mild','sea',78),
	(9,'DesertDreams','Dubai','Asia','U.A.E','active',4,'hot','mountain',67),
	(10,'SeaViews','BoraBora','Australia','FrenchPolynesia','active',3,'mild','sea',54),
	(11,'AppleCity','NewYork','NorthAmerica','USA','active',3,'mild','city',27),
	(12,'IslandHopper','Dubrovnik','Europe','Croatia','active',5,'mild','sea',78),
	(13,'CastleTown','Edinburgh','Europe','Scotland','lazy',3,'mild','city',53),
	(14,'WineValley','Rome','Europe','Italy','lazy',5,'mild','city',25),
	(15,'WearyTraveller','ParoValley','Asia','Bhutan','active',5,'mild','mountain',54),
	(16,'HotTimes','Jaipur','Asia','India','lazy',4,'hot','sea',67),
	(17,'ForestRetreat','Waikato','Australia','NewZealand','active',4,'mild','mountain',89),
	(18,'Casablanca','Havana','NorthAmerica','Cuba','lazy',5,'mild','city',29),
	(19,'TechCity','Tokyo','Asia','Japan','active',3,'mild','city',71),
	(20,'IceHotel',	'BaseMarambio','Antarctica','Antartica','active',5,'cold','mountain',270),
	(21,'NorthStar','','Arctic','Greenland','active',5,'cold','mountain',250);

end