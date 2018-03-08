using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clientes
{
    public static class DAO
    {
       public static SqlConnection abrir()
        {
            string strcon = @"Data Source = DIEGO\SQLEXPRESS; Initial Catalog = master; Integrated Security = True";
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            return cn;
        }

       public static void gravar(String sql)
        {
                SqlCommand comm = new SqlCommand();
                comm.Connection = abrir();
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                comm.Connection.Close();           
        }

       public static void remover(String sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = abrir();
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                comm.Connection.Close();
            }
            catch
            {
            }           
        }

    }
}
