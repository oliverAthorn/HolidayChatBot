CREATE PROCEDURE [dbo].[spHolidays_GetAll]
AS
begin
	SELECT *
	from dbo.Holidays;
end
