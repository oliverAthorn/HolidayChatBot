using AutoFixture;
using HolidayChatAgent.Repository;
using HolidayChatAgent.Repository.Data.Connection;
using HolidayChatAgent.Repository.Models;
using Moq;
using Moq.AutoMock;
using System.Data;
using Xunit;
using FluentAssertions;
using Moq.Dapper;
using Dapper;

namespace HolidayChatAgent.Tests;

public class HolidayRepositoryTests
{
    private readonly HolidayRepository _sut;
    private readonly Fixture _fixture;
    private readonly Mock<IDbConnection> _dbConnectionMock;
    private readonly Mock<IDbConnectionFactory> _dbConnectionFactoryMock;
    private readonly AutoMocker _autoMocker;

    public HolidayRepositoryTests()
    {
        _fixture = new Fixture();
        _dbConnectionMock = new Mock<IDbConnection>();
        _dbConnectionFactoryMock = new Mock<IDbConnectionFactory>();

        _dbConnectionFactoryMock.Setup(dcf => dcf.Create()).Returns(_dbConnectionMock.Object);

        _sut = new HolidayRepository(_dbConnectionFactoryMock.Object);

        _autoMocker = new AutoMocker();
    }

    [Fact]
    public async Task GetAllHolidaysAsync_ReturnsAllHolidays()
    {
        var expectedHolidayList = _fixture.CreateMany<Holiday>();

        _dbConnectionMock.SetupDapperAsync(db => db.QueryAsync<Holiday>(
            It.IsAny<string>(),
             It.IsAny<object>(),
              It.IsAny<IDbTransaction>(),
              It.IsAny<int>(),
              It.IsAny<CommandType>())).ReturnsAsync(expectedHolidayList);

        var result = await _sut.GetAllHolidaysAsync();

        result.Should().BeEquivalentTo(expectedHolidayList);
    }
}