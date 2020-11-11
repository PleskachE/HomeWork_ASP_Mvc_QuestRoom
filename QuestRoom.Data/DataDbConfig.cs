using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace QuestRoom.Data
{
    public class DataDbConfig : DbConfiguration
    {
        public DataDbConfig()
        {
            SetProviderServices("System.data.SqlClient", SqlProviderServices.Instance);
        }
    }
}
