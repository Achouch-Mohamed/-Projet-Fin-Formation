using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class Utilisateur : Form
    {
        Connexion C = new Connexion();
        public Utilisateur()
        {
            InitializeComponent();
        }
  private void Utilisateur_Load(object sender, EventArgs e)
        {
            C.Connecter();
            C.Datadaber = new SqlDataAdapter("select * from Utilisateur", C.Con);
            C.Dtset = new DataSet();
            C.Datadaber.Fill(C.Dtset, "Utilisateur");
            List_Utilisateur.DataSource = C.Dtset.Tables["Utilisateur"];
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.FileName = "";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
                this.Photo.ImageLocation = this.openFileDialog1.FileName;

        }
        // // // // Images // // // // 
       public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
                          ///
        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void Cin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modifier();
        }

      public void Modifier()
        {
            int sw = 0, s;
            if (Cin.Text == "" || Nom.Text == "" || Prenom.Text == "" || Adresse.Text == "" || Email.Text == "" || Ville.Text == "" || Age.Text == "" || Telephone.Text == "" || Status.Text == "" || Type.Text == "")
            {
                MessageBox.Show("SVP Romplair Tout Les Champs");
                return;
            }
            for (s = 0; s <= this.List_Utilisateur.RowCount - 2; s++)
            {
                if (Cin.Text == this.List_Utilisateur.Rows[s].Cells[0].Value.ToString())
                {
                    sw = 1;
                    C.Dtset.Tables["Utilisateur"].Rows[s][1] = Nom.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][2] = Prenom.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][3] = Adresse.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][4] = Telephone.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][5] = imageToByteArray(this.Photo.Image);
                    C.Dtset.Tables["Utilisateur"].Rows[s][7] = Ville.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][8] = Email.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][9] = Age.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][10] = Date.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][11] = Type.Text;
                    C.Dtset.Tables["Utilisateur"].Rows[s][12] = Status.Text;
                    C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                    C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                    C.Datadaber.Update(C.Dtset, "Utilisateur");
                    MessageBox.Show("Employé Modifié Avec Succès");
                    return;
                }
            }
            if (sw == 0)
            {

                MessageBox.Show("ID NON VALIDE");

            }
        }

      ///////////////////////////////////// Methode Supprimer /////////////////////////////////////
        public void Supprimer()
          {
              int sw = 0, s;
             if (Cin.Text == "")
             {
                 MessageBox.Show("SVP Romplair Cin Pour Supprimer");
                 return;
             }
             for (s = 0; s <= this.List_Utilisateur.RowCount - 2; s++)
             {
                 if (Cin.Text == this.List_Utilisateur.Rows[s].Cells[0].Value.ToString())
                 {
                     sw = 1;
                     C.Dtset.Tables["Utilisateur"].Rows[s].Delete();
                     C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                     C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                     C.Datadaber.Update(C.Dtset, "Utilisateur");
                     MessageBox.Show("Employé Supprimer Avec Succès");
                     break;
                     
                 }
             }
            if (sw==0)
            {
                MessageBox.Show("Cin Non Valide");
                return;
            }
          }
        ///////////////////////////////////// Methode Ajouter /////////////////////////////////////
       public void Ajouter()
        {
            int sw = 0, s;
            if (Cin.Text == "" || Nom.Text == "" || Prenom.Text == "" || Adresse.Text == "" || Email.Text == "" || Ville.Text == "" || Age.Text == "" || Telephone.Text == "" || Status.Text == "" || Type.Text == "")
            {
                MessageBox.Show("SVP Romplair Tout Les Champs");
                return;
            }

            for (s = 0; s <= this.List_Utilisateur.RowCount - 2; s++)
            {
                if (Cin.Text == this.List_Utilisateur.Rows[s].Cells[0].Value.ToString())
                {
                    sw = 1;
                    MessageBox.Show("Référence Existe Déjà");
                    return;
                }
            }
            if (sw == 0)
            {
                C.NewLigne = C.Dtset.Tables["Utilisateur"].NewRow();
                C.NewLigne[0] = Cin.Text;
                C.NewLigne[1] = Nom.Text;
                C.NewLigne[2] = Prenom.Text;
                C.NewLigne[3] = Adresse.Text;
                C.NewLigne[4] = Telephone.Text;
                C.NewLigne[5] = imageToByteArray(this.Photo.Image);
                Random rnd;
                int number;
                rnd = new Random();
                number = rnd.Next(999, 10000);
                C.NewLigne[6] = number.ToString();
                C.NewLigne[7] = Ville.Text;
                C.NewLigne[8] = Email.Text;
                C.NewLigne[9] = Age.Text;
                C.NewLigne[10] = Date.Text;
                C.NewLigne[11] = Type.Text;
                C.NewLigne[12] = Status.Text;
                C.Dtset.Tables["Utilisateur"].Rows.Add(C.NewLigne);
                C.CmdBuild = new SqlCommandBuilder(C.Datadaber);
                C.Datadaber.InsertCommand = C.CmdBuild.GetInsertCommand();
                C.Datadaber.Update(C.Dtset, "Utilisateur");
                MessageBox.Show("Ajout Avec Succes");
                ////////// Mail /////////////////
                //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                //client.EnableSsl = true;
                //client.Timeout = 10000;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("mohamedachouch123@gmail", "simo@1997");
                //MailMessage msg = new MailMessage();
                //msg.To.Add(Email.Text);
                //msg.From = new MailAddress(Email.Text);
                //msg.Body = "un Simple Test" + number;
                //client.Send(msg);
                //MessageBox.Show("Mail Envoyé");

                C.Deconnecter();
            }

           
        }

       private void button3_Click(object sender, EventArgs e)
       {
           Supprimer();
       }

       private void List_Utilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           int ligne;
               ligne = List_Utilisateur.CurrentRow.Index;
               Cin.Text = this.List_Utilisateur.Rows[ligne].Cells[0].Value.ToString();
               Nom.Text = this.List_Utilisateur.Rows[ligne].Cells[1].Value.ToString();
               Prenom.Text =this.List_Utilisateur.Rows[ligne].Cells[2].Value.ToString();
               Adresse.Text =this.List_Utilisateur.Rows[ligne].Cells[3].Value.ToString();
               Telephone.Text = this.List_Utilisateur.Rows[ligne].Cells[4].Value.ToString();
               MemoryStream ms = new MemoryStream((byte[]) this.List_Utilisateur.Rows[ligne].Cells[5].Value);
               Photo.Image= Image.FromStream(ms);         
               Ville.Text = this.List_Utilisateur.Rows[ligne].Cells[7].Value.ToString();
               Email.Text = this.List_Utilisateur.Rows[ligne].Cells[8].Value.ToString();
               Age.Text =  this.List_Utilisateur.Rows[ligne].Cells[9].Value.ToString();
               Status.Text = this.List_Utilisateur.Rows[ligne].Cells[11].Value.ToString();
               Type.Text = this.List_Utilisateur.Rows[ligne].Cells[12].Value.ToString();
         }

      public void Recherche()
      {
          int sw = 0, ligne;
          if (Search.Text == "")
          {
              MessageBox.Show("SVP Romplair Cin Pour Supprimer");
              return;
          }
          for (ligne = 0; ligne <= this.List_Utilisateur.RowCount - 2; ligne++)
          {
              if (Search.Text == this.List_Utilisateur.Rows[ligne].Cells[0].Value.ToString())
              {
                  sw = 1;
                  Nom.Text = this.List_Utilisateur.Rows[ligne].Cells[1].Value.ToString();
                  Prenom.Text = this.List_Utilisateur.Rows[ligne].Cells[2].Value.ToString();
                  Adresse.Text = this.List_Utilisateur.Rows[ligne].Cells[3].Value.ToString();
                  Telephone.Text = this.List_Utilisateur.Rows[ligne].Cells[4].Value.ToString();
                  MemoryStream ms = new MemoryStream((byte[])this.List_Utilisateur.Rows[ligne].Cells[5].Value);
                  Photo.Image = Image.FromStream(ms);
                  Ville.Text = this.List_Utilisateur.Rows[ligne].Cells[7].Value.ToString();
                  Email.Text = this.List_Utilisateur.Rows[ligne].Cells[8].Value.ToString();
                  Age.Text = this.List_Utilisateur.Rows[ligne].Cells[9].Value.ToString();
                  Status.Text = this.List_Utilisateur.Rows[ligne].Cells[11].Value.ToString();
                  Type.Text = this.List_Utilisateur.Rows[ligne].Cells[12].Value.ToString();
                  break;

              }
          }
          if (sw == 0)
          {
              MessageBox.Show("Cin Non Valide");
              return;
          }
      }

      private void button6_Click(object sender, EventArgs e)
      {
          Recherche();
      }

      private void button4_Click(object sender, EventArgs e)
      {
          Nom.ResetText();
          Prenom.ResetText();
          Adresse.ResetText();
          Telephone.ResetText();
          Photo.ResetText();
          Ville.ResetText();
          Email.ResetText();
          Age.ResetText();
          Status.ResetText();
          Type.ResetText();
      }
       
    }
}
