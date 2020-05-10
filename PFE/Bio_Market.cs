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
       

        public Bio_Market()
        {
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

   
    }
}
