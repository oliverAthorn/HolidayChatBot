using System.Data;

namespace HolidayChatAgent.Repository.Data.Connection
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}
