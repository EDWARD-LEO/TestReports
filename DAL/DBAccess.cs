using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace DAL
{
    public class DBAccess
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sisreports"].ConnectionString);

        public SqlConnection getConexion()
        {
            return this.conn;
        }

        public void conectar()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        public void desconectar()
        {
            if (this.conn.State == ConnectionState.Open)
            {
                this.conn.Close();
            }
        }

        public DataTable getDataFrom(string spu, int estado)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@estado", estado);
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }

        public DataTable getDataWithCondition(string spu, string key, string value)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue(key, value);
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }
    }
}
