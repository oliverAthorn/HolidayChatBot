using HolidayChatAgent.Repository;
using HolidayChatAgent.Repository.Models;
using HolidayChatAgent.Services.Interfaces;

namespace HolidayChatAgent.Services.Concrete;

public class HolidayService : IHolidayService
{
    private readonly IHolidayRepository _holidayRepository;

    public HolidayService(IHolidayRepository holidayRepository)
    {
        _holidayRepository = holidayRepository ?? throw new ArgumentNullException(nameof(holidayRepository));
    }

    public async Task<List<Holiday>> GetAllHolidaysAsync()
    {
        return await _holidayRepository.GetAllHolidaysAsync();
    }
}
