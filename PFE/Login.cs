using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class Login : Form
    {
        Connexion c = new Connexion();
        Utilisateur u = new Utilisateur();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vollez Vous Vraiment Quitter", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (Cin.Text == "" || Code.Text == "" )
            {
                MessageBox.Show("SVP Remplair Tout Les Chemps");
                return;
            }
            c.Connecter();
            SqlCommand cmd = new SqlCommand("Utilisateur_Login", c.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cin", Cin.Text.Trim());
            cmd.Parameters.AddWithValue("@Code", Code.Text.Trim());
            c.Datadaber.SelectCommand = cmd;
            c.Datadaber.Fill(c.dt);
            cmd.Dispose();
            if (c.dt.Rows.Count > 0)
            {
                Bio_Market.getBio_Market.Utilisateur.Enabled = true;
                Bio_Market.getBio_Market.utili_management.Enabled = true;
                Bio_Market.getBio_Market.Produit.Enabled=true;
                Bio_Market.getBio_Market.produitManagement.Enabled = true;
                Bio_Market.getBio_Market.Connecter.Enabled = false;
                Bio_Market.getBio_Market.Deconnecter.Enabled = true;
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Login Failed");
                Oublie_Mot_De_Passe.Visible = true;
                return;
            }  
           
           
        }
    }
}
