using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int sw = 0, s;

            if (Email.Text == "" || Code.Text == "" )
            {
                MessageBox.Show("SVP Remplair Tout Les Chemps");
                return;
            }

         
            for (s = 0; s <= u.List_Utilisateur.RowCount - 2; s++)
            {
                if (Email.Text == u.List_Utilisateur.Rows[s].Cells[8].Value.ToString() && Code.Text == u.List_Utilisateur.Rows[s].Cells[6].Value.ToString())
                {
                    sw = 1;
                }
               
            }
            if (sw== 1)
            {
                MessageBox.Show("OUI");
            }
            if (sw == 0)
            {
                MessageBox.Show("Non");
            }
        }
    }
}
