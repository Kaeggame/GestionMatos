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
    public partial class FormulaireListeClient : System.Windows.Forms.Form
    {

        public FormulaireListeClient()
        {
            InitializeComponent();
        }

        // bon...
        private void buttonListeCRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // bouton qui permet de créer un nouveau Client
        // (en cours)
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            FormulaireNewClient ChildForm = new FormulaireNewClient();

            ChildForm.ShowDialog();
        }


        private void FormulaireListeClient_Load(object sender, EventArgs e)
        {
            buttonModifierClient.Enabled = false;

            string s = "select * from Client";

            Requete(s);
        }

        // Requette de la Barre de recherche 
        private void Requete(string strsql)
        {
            listBoxClient.Items.Clear();

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();

            SqlCommand com = new SqlCommand(strsql, cn);

            SqlDataReader sqr = com.ExecuteReader();

            while (sqr.Read() != false)
            {
                int id = Convert.ToInt32(sqr["ClientID"]);
                string lenom = sqr["NomClient"].ToString();
                string email = sqr["Mail"].ToString();
                string tel = sqr["NumTel"].ToString();
                IdClient Client = new IdClient(id, lenom, email, tel);

                listBoxClient.Items.Add(Client);
            }

            sqr.Close();
            cn.Close();
        }

        // Affiche les infos de l'élément selectionné 
        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonModifierClient.Enabled = true;

            IdClient truc = (IdClient)(listBoxClient.SelectedItem);
            if (truc == null)
                return;
            int id = truc.id;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "select * from Client where ClientID = " + id.ToString();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader sqr = com.ExecuteReader();
            sqr.Read();
            textBoxCNom.Text = sqr["NomClient"].ToString();
            textBoxCMail.Text = sqr["Mail"].ToString();
            textBoxCTel.Text = sqr["NumTel"].ToString();
            cn.Close();
        }

        // Bouton pour modifier les infos du client sélectionné (enfin ça renvoi sur la page modifier quoi)
        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            FormulaireModifierClient ChildForm = new FormulaireModifierClient();

            ChildForm.NomClient = textBoxCNom.Text;
            ChildForm.MailClient = textBoxCMail.Text;
            ChildForm.TelClient = textBoxCTel.Text;

            ChildForm.ShowDialog();
        }

        // Barre de recherche
        private void textBoxCRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            string str = textBoxCRecherche.Text;
            string sql = "select * from Client where NomClient like '" + str + "%'";
            Requete(sql);
        }

        private void buttonCActualiser_Click(object sender, EventArgs e)
        {
            string s = "select * from Client";

            Requete(s); // Permet au bouton "Actualiser" d'actualiser la liste de client.
        }
    }
}
