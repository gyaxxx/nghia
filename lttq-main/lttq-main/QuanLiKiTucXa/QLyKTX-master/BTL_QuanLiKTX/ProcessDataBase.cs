using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    internal class ProcessDataBase
    {
        SqlConnection con;
        string constring;

        public ProcessDataBase()
        {
            constring = "Data Source=gyaxxx;Initial Catalog=QLKyTucXa;User ID=sa;Password=nghia123;Encrypt=False";
            con = new SqlConnection(constring);
        }
        public void KetNoi()
        {
			constring = "Data Source=gyaxxx;Initial Catalog=QLKyTucXa;User ID=sa;Password=nghia123;Encrypt=False";
			con = new SqlConnection(constring);
			if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }

        public void DongKetNoi()
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
            con.Dispose();
        }

        public DataTable DocBang(string sql)
        {
            DataTable tb = new DataTable();
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void openConnect()
        {
            this.con.Open();
        }
        public void CapNhat(string sql)
        {
            KetNoi();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            DongKetNoi();
            cm.Dispose();
        }
    }
}
