using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPostgreSQLClient
{
    class BusinessLayer
    {
        private string m_connectionString = string.Empty;
        internal BusinessLayer(string connectionString)
        {
            m_connectionString = connectionString;
        }

        internal DataTable GetDatabases()
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection con = new NpgsqlConnection(m_connectionString))
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM pg_database WHERE datistemplate = false", con);
                adapter.Fill(dataTable);
                con.Close();
            }
            return dataTable;
        }

        internal object ExecuteBatch(string sqlCommand)
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection con = new NpgsqlConnection(m_connectionString))
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlCommand, con);
                adapter.Fill(dataTable);
                con.Close();
            }
            return dataTable;
        }
    }
}
