using System.Data.SqlClient;

namespace CRUD_MVC_ASP.Data
{
    public class ConnectionSQL
    {
        private string _connectionString = string.Empty;

        public ConnectionSQL()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _connectionString = builder.GetConnectionString("Connection");
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
