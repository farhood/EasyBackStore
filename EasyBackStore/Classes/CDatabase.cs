using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBackStore.Classes
{
    internal class CDatabase
    {
        private string _connectionString;

        public CDatabase(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public DataTable? LoadDatatTable(string tableName, string query, CommandType commandType)
        {
            using SqlConnection connection = new(_connectionString);

            try
            {
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 0;

                DataTable dt = new(tableName);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                //dt.Load(sqlCommand.ExecuteReader());

                using (SqlDataAdapter adapter = new(sqlCommand))
                {
                    adapter.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                CException.ExceptionHandler(ex, "LoadDatatTable");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public int? ExecuteQuery(string query, CommandType commandType)
        {
            using SqlConnection connection = new(_connectionString);

            try
            {
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 0;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                CException.ExceptionHandler(ex, "LoadDatatTable");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
