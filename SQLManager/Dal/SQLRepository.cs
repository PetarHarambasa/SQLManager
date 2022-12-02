using SQLManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManager.Dal
{
    public class SQLRepository : IRepository
    {
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";
        private const string SelectDatabases = "SELECT name As Name FROM sys.databases";
        private string cs;


        public void Login(string serverName, string login, string password)
        {
            string css = string.Format(ConnectionString, serverName, login, password);
            using (SqlConnection con = new SqlConnection(css))
            {
                con.Open();
                cs = css;
            }
        }
        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public SqlQueryResultMessage ExecuteInsertedQuery(string databaseName, string querytext)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "use " + databaseName + " " + querytext;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    int recordsAffected = dr.RecordsAffected;

                    dr.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(querytext,con);
                    da.Fill(dt);

                    return new SqlQueryResultMessage
                    {
                        RecordsAffected = recordsAffected,
                        CompletionTime = DateTime.Now,
                        Table = dt
                    };
                }
            }
        }
    }
}
