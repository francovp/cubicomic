using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace cubicomic.DAL
{
    public class CubicomicConfiguration : DbConfiguration
    {
        public CubicomicConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}