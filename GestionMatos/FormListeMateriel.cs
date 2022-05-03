using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionMatos
{
    public partial class FormulaireListeMateriel : System.Windows.Forms.Form
    {

        // Pour récup l'ID du materiel
        private string IDMateriel;
        public string GetTheIDPlease()
        {
            return this.IDMateriel;
        }

        public FormulaireListeMateriel()
        {
            InitializeComponent();
        }

        // Le premier qui me demande ce que ça fait, je lui NuclearGandhi la gueule !!!
        private void buttonListeMRetour_Click(object sender, EventArgs e)
        {
            this.Close(); // Je suis sérieux !!!
        }

        // Bouton pour créer un nouveau materiel, enfin ça ouvre la fenêtre pour quoi
        // (en cours)
        private void buttonNewMateriel_Click(object sender, EventArgs e)
        {
            FormulaireNewMateriel ChildForm = new FormulaireNewMateriel();

            ChildForm.ShowDialog();
        }

        // Bouton pour modifier les infos de l'élément sélectionné, enfin ça ouvre la fenêtre pour quoi
        protected void buttonModifierMateriel_Click(object sender, EventArgs e)
        {
            FormulaireModifierMateriel ChildForm = new FormulaireModifierMateriel();

            ChildForm.DateMateriel = textBoxMDate.Text;
            ChildForm.CommentaireMateriel = textBoxMDescription.Text;
            ChildForm.ClientMateriel = textBoxMClient.Text;
            ChildForm.NomMateriel = textBoxMNom.Text;
            ChildForm.TypeMateriel = textBoxMType.Text;
            ChildForm.NserieMateriel = textBoxMNserie.Text;
            ChildForm.IdTest = GetTheIDPlease(); // on utilise le getteur du début pour récup l'ID... comment ça "c'est quoi un getteur" ?

            ChildForm.ShowDialog();
        }

        // tiens c'est marrant que ça soit pas en haut du code... bah tant pis
        private void FormulaireListeMateriel_Load(object sender, EventArgs e)
        {
            buttonModifierMateriel.Enabled = false;
            buttonMSupprimer.Enabled = false;

            string s = "SELECT * FROM Materiel INNER JOIN Client ON Materiel.ClientID = Client.ClientID";

            Requete(s);
        }

        // Requette de la barre de recherche
        private void Requete(string strsql)
        {
            listBoxMateriel.Items.Clear();

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();

            SqlCommand com = new SqlCommand(strsql, cn);

            SqlDataReader sqr = com.ExecuteReader();


            while (sqr.Read() != false)
            {
                int id = Convert.ToInt32(sqr["MatID"]);

                string lenommat = sqr["Nom"].ToString();
                string lenumserie = sqr["NumSerie"].ToString();
                string letypemat = sqr["TypeMat"].ToString();
                string ladateinstall = sqr["DateInstallation"].ToString();
                string ladesc = sqr["Description"].ToString();
                string lemtbf = sqr["MTBF"].ToString();
                string lenomclient = sqr["NomClient"].ToString();
                IdMat Mat = new IdMat(id, lenommat, lenumserie, letypemat, ladateinstall, ladesc, lemtbf, lenomclient);

                listBoxMateriel.Items.Add(Mat);
            }

            sqr.Close();
            cn.Close();
        }

        // Affiche les infos de l'élément sélectionné 
        private void listBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonModifierMateriel.Enabled = true;
            buttonMSupprimer.Enabled = true;

            IdMat truc = (IdMat)(listBoxMateriel.SelectedItem);
            if (truc == null)
                return;
            int id = truc.id;
            IDMateriel = id.ToString();

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "SELECT * FROM Materiel INNER JOIN Client ON Materiel.ClientID = Client.ClientID WHERE MatID = " + id.ToString();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader sqr = com.ExecuteReader();
            sqr.Read();
            textBoxMNom.Text = sqr["Nom"].ToString();
            textBoxMNserie.Text = sqr["NumSerie"].ToString();
            textBoxMType.Text = sqr["TypeMat"].ToString();
            textBoxMDate.Text = sqr["DateInstallation"].ToString();
            textBoxMmtbf.Text = sqr["MTBF"].ToString() + " ans";
            textBoxMDescription.Text = sqr["Description"].ToString();
            textBoxMClient.Text = sqr["NomClient"].ToString();

            sqr.Close();

          
            cn.Close();
        }

        // Barre de recherche
        private void textBoxMRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            string str = textBoxMRecherche.Text;
            string sql = "SELECT * FROM Materiel INNER JOIN Client ON Materiel.ClientID = Client.ClientID WHERE Nom like '" + str + "%'";
            Requete(sql);
        }

        private void buttonMActualiser_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM Materiel INNER JOIN Client ON Materiel.ClientID = Client.ClientID";

            textBoxMNom.Clear();
            textBoxMNserie.Clear();
            textBoxMType.Clear();
            textBoxMDate.Clear();
            textBoxMmtbf.Clear();
            textBoxMDescription.Clear();
            textBoxMClient.Clear();

            Requete(s); // Permet au bouton "Actualiser" d'actualiser la liste de materiel.
        }

        private void buttonMSupprimer_Click(object sender, EventArgs e)
        {
            /* à tester */
            const string message1 = "Cette action suprimera l'intervention rataché à ce materiel, continuer ?";
            const string caption1 = "Attention Supression";
            var result1 = MessageBox.Show(message1, caption1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                const string message2 = "La supression sera deffinitive, voulez-vous toujours continuer ?";
                const string caption2 = "Attention Supression";
                var result2 = MessageBox.Show(message2, caption2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
                    SqlConnection sqlConn = new SqlConnection(cnsql);

                    string query = "DELETE from Materiel where MatID = " + IDMateriel.ToString();
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    cmd.Connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error " + ex.Message);
                    }

                    MessageBox.Show("Suppression Confirmée !");
                    sqlConn.Close();
                }
            }
        }
    }
}
