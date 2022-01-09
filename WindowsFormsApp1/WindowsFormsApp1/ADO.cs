using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace WindowsFormsApp1
{
    class ADO
    {
        // Declaration des objets sql
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // declaration de la methode connecter
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=LENOVOPC;Initial Catalog=TDI;Integrated Security=True";
                con.Open();
            }
        }

        // declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {

                con.Close();
            }
        }

    }
}