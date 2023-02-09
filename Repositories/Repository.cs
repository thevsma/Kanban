using KanbanMVP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanMVP.Repositories
{
    public class Repository : DbContext
    {
        private static MySqlConnection _dbConnection;
        public DbSet<KanbanTask> KanbanTask { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository repos = this;

                repos.SaveChanges();
            }
        }

        public static MySqlConnection GetDbConnection()
        {
            if (_dbConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["Kanban"].ConnectionString;
                _dbConnection = new MySqlConnection(connectionString);
            }
            return _dbConnection;
        }
    }
}
