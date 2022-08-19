using HolidayChatAgent.Repository;
using Moq;
using Moq.AutoMock;
using Xunit;
using HolidayChatAgent.Services.Concrete;

namespace HolidayChatAgent.Tests;

public class HolidayServiceTests
{
    private readonly Mock<IHolidayRepository> _repository;
    private readonly HolidayService _sut;
    private readonly AutoMocker _autoMocker;

    public HolidayServiceTests()
    {
        _autoMocker = new AutoMocker();
        _repository = _autoMocker.GetMock<IHolidayRepository>();
        _sut = new HolidayService(_repository.Object);
    }

    [Fact]
    public async Task GetAllHolidaysAsync_CallsHolidayRepository()
    {
        await _sut.GetAllHolidaysAsync();

        _repository
            .Verify(x => x.GetAllHolidaysAsync(), Times.Once());
    }
}
