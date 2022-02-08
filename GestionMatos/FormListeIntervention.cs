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

        private void buttonListeIMateriel_Click(object sender, EventArgs e)
        {
            FormulaireListeMateriel ChildForm = new FormulaireListeMateriel();

            ChildForm.ShowDialog();
        }

        private void buttonListeIClient_Click(object sender, EventArgs e)
        {
            FormulaireListeClient ChildForm = new FormulaireListeClient();

            ChildForm.ShowDialog();
        }

        private void buttonNewIntervention_Click(object sender, EventArgs e)
        {
            FormulaireNewIntervention ChildForm = new FormulaireNewIntervention();

            ChildForm.ShowDialog();
        }

        private void FormulaireListeIntervention_Load(object sender, EventArgs e)
        {
            FormConnexion fr = new FormConnexion();

            fr.ShowDialog();
        }

        private void buttonModifierIntervention_Click(object sender, EventArgs e)
        {
            FormulaireModifierIntervention ChildForm = new FormulaireModifierIntervention();

            ChildForm.ShowDialog();
        }

        private void textBoxIRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            string str = textBoxIRecherche.Text;
            string sql = "select * from Intervention where NomInter like '" + str + "%'";
            Requete(sql);
        }

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
                string lenominter = sqr["NomInter"].ToString();
                string lainterdate = sqr["InterDate"].ToString();
                string lecommentaire = sqr["Commentaire"].ToString();
                IdInter Inter = new IdInter(id, lenominter, lainterdate, lecommentaire);

                listBoxIntervention.Items.Add(Inter);
            }

            sqr.Close();
            cn.Close();
        }
    }
}
