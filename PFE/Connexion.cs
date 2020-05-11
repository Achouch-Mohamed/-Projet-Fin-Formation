using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PFE
{
    class Connexion
    {
        public SqlConnection Con = new SqlConnection();
        public SqlDataAdapter Datadaber = new SqlDataAdapter();
        public DataSet Dtset = new DataSet();
        public DataRow NewLigne;
        public SqlCommandBuilder CmdBuild;
        public DataTable dt = new DataTable();
        public SqlCommand cmd = new SqlCommand();


        public void Connecter()
        {
            if (Con.State==ConnectionState.Closed || Con.State==ConnectionState.Broken)
            {
                Con.ConnectionString =@"Data Source=(LocalDB)\v11.0;Initial Catalog=Bio_Market;Integrated Security=True";
                Con.Open();
            }
        }
        public void Deconnecter()
        {
            if (Con.State == ConnectionState.Open)
            {  
                Con.Close();
            }
        }

       
    }
 
}
