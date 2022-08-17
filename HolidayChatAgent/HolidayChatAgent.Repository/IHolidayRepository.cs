using HolidayChatAgent.Repository.Models;

namespace HolidayChatAgent.Repository
{
    public interface IHolidayRepository
    {
        Task<IEnumerable<Holiday>> GetAllHolidaysAsync();
    }
}
