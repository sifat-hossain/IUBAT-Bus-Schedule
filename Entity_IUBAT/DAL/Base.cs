using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Base
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-4PR2IUA\\SQL;Initial Catalog=iubat_bus;Integrated Security=True");

        protected bool Connection()
        {
            if (Reader != null && !Reader.IsClosed)
                Reader.Close();

            if (cn.State == ConnectionState.Open)
                return true;
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return false;
        }

        protected bool Execute(SqlCommand cmd)
        {
            if (!Connection())
            {
                return false;
            }
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        protected SqlCommand Command { get; set; }
        protected SqlCommand CommandBuilder(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = SQL;
            return cmd;
        }

        protected SqlDataReader Reader { get; set; }

        protected SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            if (!Connection())
                return null;

            return cmd.ExecuteReader();

        }

        protected DataSet ExecuteDataSet(SqlCommand cmd)
        {

            if (!Connection())
                return null;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(ds);
            return ds;
        }

        public string Error { get; set; }
    }
}