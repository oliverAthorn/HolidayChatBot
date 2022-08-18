using HolidayChatAgent.Repository.Models;

namespace HolidayChatAgent.Services.Interfaces;

public interface IHolidayService
{
    Task<List<Holiday>> GetAllHolidaysAsync();
}
