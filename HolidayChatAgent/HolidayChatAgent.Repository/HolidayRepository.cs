using System.Data;
using Dapper;
using HolidayChatAgent.Repository.Data.Connection;
using HolidayChatAgent.Repository.Models;

namespace HolidayChatAgent.Repository;

public class HolidayRepository : IHolidayRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public HolidayRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
    }

    public async Task<List<Holiday>> GetAllHolidaysAsync()
    {
        using var connection = _connectionFactory.Create();

        var results = await connection.QueryAsync<Holiday>(
            "dbo.spHolidays_GetAll", commandType: CommandType.StoredProcedure);

        return results.ToList();
    }

    //public async Task UpsertHolidaysAsync(
    //    int HolidayReference,
    //    string HotelName,
    //    string City,
    //    string Continent,
    //    string Country,
    //    string Category,
    //    int StarRating,
    //    string TempRating,
    //    string Location,
    //    decimal PricePerNight)
    //{
    //    throw new NotImplementedException();
    //}
}

