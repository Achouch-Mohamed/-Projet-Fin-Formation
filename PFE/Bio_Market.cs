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
    public partial class Bio_Market : Form
    {
        private static Bio_Market BM;
     
        static void Form_Closed(object sender ,FormClosedEventArgs e)
        {
            BM = null;
        }

        public static Bio_Market getBio_Market
        {
            get
            {
                if (BM==null)
                {
                    BM = new Bio_Market();
                    BM.FormClosed += new FormClosedEventHandler(Form_Closed);
                }
                return BM;
            }
        }

        public Bio_Market ()
        {
            if (BM == null)
            {
                BM = this;
            }

            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            l.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vollez Vous Vraiment Quitter","Quitter",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateur u = new Utilisateur();
            u.MdiParent = this;
            u.Show();
        }

        private void Bio_Market_Load(object sender, EventArgs e)
        {

        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produit P = new Produit();
            P.Show();
            P.MdiParent = this;
            return;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vollez Vous Vraiment Deconnecter C'est Compte", "Deconnecter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Bio_Market.getBio_Market.Utilisateur.Enabled = false;
                Bio_Market.getBio_Market.utili_management.Enabled = false;
                Bio_Market.getBio_Market.Produit.Enabled = false;
                Bio_Market.getBio_Market.produitManagement.Enabled = false;
                Connecter.Enabled = true;
                Deconnecter.Enabled = false;
            }
        
         

        }

        

   
    }
}
