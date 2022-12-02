using SQLManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManager.Dal
{
    public interface IRepository
    {
        IEnumerable<Database> GetDatabases();
        void Login(string serverName, string login, string password);
        SqlQueryResultMessage ExecuteInsertedQuery(string databaseName,string querytext);
    }
}
