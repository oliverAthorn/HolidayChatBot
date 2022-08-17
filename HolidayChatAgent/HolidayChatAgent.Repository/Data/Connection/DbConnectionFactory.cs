using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HolidayChatAgent.Repository.Data.Connection
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _config;

        public DbConnectionFactory(IConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public IDbConnection Create()
        {
            return new SqlConnection(_config.GetConnectionString("Default"));
        }
    }
}
