using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class Produit : Form
    {
        Connexion C = new Connexion();
        public Produit()
        {
            InitializeComponent();
        }
     

     
        private void Produit_Load(object sender, EventArgs e)
        {
            C.Connecter();
            C.Datadaber = new SqlDataAdapter("select * from Produit", C.Con);
            C.Dtset = new DataSet();
            C.Datadaber.Fill(C.Dtset, "Produit");
            List_Produit.DataSource = C.Dtset.Tables["Produit"];




            /////////////////               DataGridView Design          ///////////////////
            List_Produit.BorderStyle = BorderStyle.None;
            List_Produit.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238,239,249);
            List_Produit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            List_Produit.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            List_Produit.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            List_Produit.EnableHeadersVisualStyles = false;
            List_Produit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            List_Produit.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20,25,72);
            List_Produit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modifier();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Supprimer();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Recherche();
        }
        public void Recherche()
        {
            int sw = 0, ligne;
            if (Search.Text == "")
            {
                MessageBox.Show("SVP Romplair Cin Pour Supprimer");
                return;
            }
            for (ligne = 0; ligne <= this.List_Produit.RowCount - 2; ligne++)
            {
                if (Search.Text == this.List_Produit.Rows[ligne].Cells[0].Value.ToString())
                {
                    sw = 1;
                    ID_Produit.Text = this.List_Produit.Rows[ligne].Cells[0].Value.ToString();
                    Nom_Produit.Text = this.List_Produit.Rows[ligne].Cells[1].Value.ToString();
                    Prix.Text = this.List_Produit.Rows[ligne].Cells[2].Value.ToString();
                    Description.Text = this.List_Produit.Rows[ligne].Cells[3].Value.ToString();
                    MemoryStream ms = new MemoryStream((byte[])this.List_Produit.Rows[ligne].Cells[4].Value);
                    Photo.Image = Image.FromStream(ms);
                    break;

                }
            }
            if (sw == 0)
            {
                MessageBox.Show("Cin Non Valide");
                return;
            }
        }

        public void Supprimer()
        {
            int sw = 0, s;
            if (ID_Produit.Text == "")
            {
                MessageBox.Show("SVP Romplair Cin Pour Supprimer");
                return;
            }
            for (s = 0; s <= this.List_Produit.RowCount - 2; s++)
            {
                if (ID_Produit.Text == this.List_Produit.Rows[s].Cells[0].Value.ToString())
                {
                    sw = 1;
                    C.Dtset.Tables["Produit"].Rows[s].Delete();
                    C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                    C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                    C.Datadaber.Update(C.Dtset, "Produit");
                    MessageBox.Show("Employé Supprimer Avec Succès");
                    break;

                }
            }
            if (sw == 0)
            {
                MessageBox.Show("ID Produit Non Valide");
                return;
            }
        }

        public void Ajouter()
        {
            int sw = 0, s;
            if (ID_Produit.Text == "" || Nom_Produit.Text == "" || Description.Text==""|| Prix.Text=="")
            {
                MessageBox.Show("SVP Romplair Tout Les Champs");
                return;
            }
            for (s = 0; s <= this.List_Produit.RowCount - 2; s++)
            {
                if (ID_Produit.Text == this.List_Produit.Rows[s].Cells[0].Value.ToString())
                {
                    sw = 1;
                    MessageBox.Show("Produit Existe Déjà");
                    return;
                }
            }
          
            if (sw == 0)
            {
                C.NewLigne = C.Dtset.Tables["Produit"].NewRow();
                C.NewLigne[0] = ID_Produit.Text;
                C.NewLigne[1] = Nom_Produit.Text;
                C.NewLigne[2] = Prix.Text;
                C.NewLigne[3] = Description.Text;
                C.NewLigne[4] = imageToByteArray(this.Photo.Image);
                C.Dtset.Tables["Produit"].Rows.Add(C.NewLigne);
                C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                C.Datadaber.Update(C.Dtset, "Produit");
                MessageBox.Show("Ajout Avec Succes");

                C.Deconnecter();
            }
        }

     
       
        public void Modifier()
        {
            int sw = 0, s;
            if (ID_Produit.Text == "" || Nom_Produit.Text == "" || Description.Text == "" || Prix.Text == "")
            {
                MessageBox.Show("SVP Romplair Tout Les Champs");
                return;
            }
            for (s = 0; s <= this.List_Produit.RowCount - 2; s++)
            {
                if (ID_Produit.Text == this.List_Produit.Rows[s].Cells[0].Value.ToString())
                {
                    sw = 1;
                    C.Dtset.Tables["Produit"].Rows[s][1] = Nom_Produit.Text;
                    C.Dtset.Tables["Produit"].Rows[s][2] = Prix.Text;
                    C.Dtset.Tables["Produit"].Rows[s][3] = Description.Text;
                    C.Dtset.Tables["Produit"].Rows[s][4] = imageToByteArray(this.Photo.Image);
                  
                    C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                    C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                    C.Datadaber.Update(C.Dtset, "Produit");
                    MessageBox.Show("Employé Modifié Avec Succès");
                    return;
                }
            }
            if (sw == 0)
            {

                MessageBox.Show("ID NON VALIDE");

            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
                this.Photo.ImageLocation = this.openFileDialog1.FileName;
        }

        private void List_Produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne;
            ligne = this.List_Produit.CurrentRow.Index;
            ID_Produit.Text = this.List_Produit.Rows[ligne].Cells[0].Value.ToString();
            Nom_Produit.Text = this.List_Produit.Rows[ligne].Cells[1].Value.ToString();
            Prix.Text = this.List_Produit.Rows[ligne].Cells[2].Value.ToString();
            Description.Text = this.List_Produit.Rows[ligne].Cells[3].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])this.List_Produit.Rows[ligne].Cells[4].Value);
            Photo.Image = Image.FromStream(ms);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ID_Produit.ResetText();
            Nom_Produit.ResetText();
            Description.ResetText();
            Prix.ResetText();
        }

       

    }
}
