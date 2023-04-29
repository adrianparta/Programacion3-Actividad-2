using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AccessData
    {
        private readonly SqlConnection connection;
        private readonly SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public AccessData()
        {
            this.connection = new SqlConnection(@"Server=.;Database=CATALOGO_P3_DB;Trusted_Connection=True;");
            this.command = new SqlCommand();
        }

        public void SetQuery(string query, SqlParameterCollection parameters)
        {
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = query;
            foreach (var parameter in parameters)
            {
                this.command.Parameters.Add(parameter);
            }
        }

        public bool ExecuteQuery()
        {
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = this.command.ExecuteReader();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int ExecuteNonQuery()
        {
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                return this.command.ExecuteNonQuery();   
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public void Close()
        {
            if (this.reader != null)
            {
                this.reader.Close();
            }
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }


    }
}
