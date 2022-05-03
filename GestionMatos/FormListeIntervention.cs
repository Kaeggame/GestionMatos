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
    public partial class FormulaireListeIntervention : System.Windows.Forms.Form
    {
        public FormulaireListeIntervention()
        {
            InitializeComponent();
        }

        
        private void FormulaireListeIntervention_Load(object sender, EventArgs e)
        {
            FormConnexion fr = new FormConnexion(); // Au lancement de l'application, ouvre la fenêtre de connexion

            buttonModifierIntervention.Enabled = false;

            fr.ShowDialog();
            string s = "SELECT * FROM Intervention INNER JOIN Materiel ON Intervention.MatID = Materiel.MatID INNER JOIN Client ON Materiel.ClientID = Client.ClientID INNER JOIN Site ON Materiel.SiteID = Site.SiteID";

            Requete(s);
        }

        private void buttonIActualiser_Click(object sender, EventArgs e)
        {

            string s = "SELECT * FROM Intervention INNER JOIN Materiel ON Intervention.MatID = Materiel.MatID INNER JOIN Client ON Materiel.ClientID = Client.ClientID INNER JOIN Site ON Materiel.SiteID = Site.SiteID";
           
            Requete(s); // Permet au bouton "Actualiser" d'actualiser la liste d'intervention.
        }

        // Bouton qui affiche la Liste des Materiels
        private void buttonListeIMateriel_Click(object sender, EventArgs e)
        {
            FormulaireListeMateriel ChildForm = new FormulaireListeMateriel();

            ChildForm.ShowDialog();
        }

        // Bouton qui affiche la Liste des Clients
        private void buttonListeIClient_Click(object sender, EventArgs e)
        {
            FormulaireListeClient ChildForm = new FormulaireListeClient();

            ChildForm.ShowDialog();
        }

        // Bouton pour Créer une nouvelle intervention
        // (en cours)
        private void buttonNewIntervention_Click(object sender, EventArgs e)
        {
            FormulaireNewIntervention ChildForm = new FormulaireNewIntervention();

            ChildForm.ShowDialog();
        }

        // Bouton pour modifier une intervention
        private void buttonModifierIntervention_Click(object sender, EventArgs e)
        {
            // Ouvre la page de madification avec les infos affichés par la liste
            FormulaireModifierIntervention ChildForm = new FormulaireModifierIntervention();

            ChildForm.NomIntervention = textBoxINom.Text;
            ChildForm.CommentaireIntervention = textBoxICommentaire.Text;
            //ChildForm.ClientIntervention = textBoxIClient .Text;
            //ChildForm.SiteIntervention = textBoxISite.Text;
            //ChildForm.MaterielIntervention = textBoxIMateriel.Text;
            //ChildForm.TypeMaterielIntervention = textBoxIType.Text;
            ChildForm.DateIntervention = textBoxIDate.Text;
            ChildForm.ShowDialog();
        }

        // Barre de Recherche
        private void textBoxIRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            string str = textBoxIRecherche.Text;
            string sql = "SELECT * FROM Intervention INNER JOIN Materiel ON Intervention.MatID = Materiel.MatID INNER JOIN Client ON Materiel.ClientID = Client.ClientID INNER JOIN Site ON Materiel.SiteID = Site.SiteID where InterNom like '" + str + "%'";
            Requete(sql);
        }

        // Requette de la barre de recherche 
        private void Requete(string strsql)
        {
            listBoxIntervention.Items.Clear();

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();

            SqlCommand com = new SqlCommand(strsql, cn);

            SqlDataReader sqr = com.ExecuteReader();

            while (sqr.Read() != false)
            {
                int id = Convert.ToInt32(sqr["InterID"]);
                string lenominter = sqr["InterNom"].ToString();
                string lainterdate = sqr["InterDate"].ToString();
                string lecommentaire = sqr["Commentaire"].ToString();
                string lenommat = sqr["Nom"].ToString();
                string letypemat = sqr["TypeMat"].ToString();
                string lenomclient = sqr["NomClient"].ToString();
                string lesite = sqr["SiteNom"].ToString();

                IdInter Inter = new IdInter(id, lenominter, lainterdate, lecommentaire, lenommat, letypemat, lenomclient, lesite);

                listBoxIntervention.Items.Add(Inter);
            }

            sqr.Close();
            cn.Close();
        }

        // Affiche les infos de l'élément sectionné 
        private void listBoxIntervention_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonModifierIntervention.Enabled = true;

            IdInter truc = (IdInter)(listBoxIntervention.SelectedItem);
            if (truc == null)
                return;
            int id = truc.id;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "SELECT * FROM Intervention INNER JOIN Materiel ON Intervention.MatID = Materiel.MatID INNER JOIN Client ON Materiel.ClientID = Client.ClientID INNER JOIN Site ON Materiel.SiteID = Site.SiteID where InterID = " + id.ToString();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader sqr = com.ExecuteReader();
            sqr.Read();
            textBoxINom.Text = sqr["InterNom"].ToString();
            textBoxIDate.Text = sqr["InterDate"].ToString();
            textBoxICommentaire.Text = sqr["Commentaire"].ToString();
            textBoxIMateriel.Text = sqr["Nom"].ToString();
            textBoxIType.Text = sqr["TypeMat"].ToString();
            textBoxIClient.Text = sqr["NomClient"].ToString();
            textBoxISite.Text = sqr["Commentaire"].ToString();

            cn.Close();
        }
    }
}
