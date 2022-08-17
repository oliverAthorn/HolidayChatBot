using HolidayChatAgent.Repository.Models;

namespace HolidayChatAgent.Services.Interfaces;

public interface IHolidayService
{
    Task<IEnumerable<Holiday>> GetAllHolidaysAsync();
}
