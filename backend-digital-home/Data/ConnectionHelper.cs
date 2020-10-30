using backend_digital_home.Core;

namespace backend_digital_home.Data
{
    public class ConnectionHelper : IConnectionHelper
    {
        // Get connection string to database
        public string GetConnectionString()
        {
            return @"Data Source=ALEX-LENOVO\SQLEXPRESS;Initial Catalog=DigitalHome;Integrated Security=True";
        }
    }
}
