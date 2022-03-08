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

        private string IDCrashTest;
        public string GetTheFuckingID()
        {
            return this.IDCrashTest;
        }

        public FormulaireListeMateriel()
        {
            InitializeComponent();
        }

        private void buttonListeMRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewMateriel_Click(object sender, EventArgs e)
        {
            FormulaireNewMateriel ChildForm = new FormulaireNewMateriel();

            ChildForm.ShowDialog();
        }

        protected void buttonModifierMateriel_Click(object sender, EventArgs e)
        {
            FormulaireModifierMateriel ChildForm = new FormulaireModifierMateriel();

            ChildForm.DateMateriel = textBoxMDate.Text;
            ChildForm.CommentaireMateriel = textBoxMDescription.Text;
            ChildForm.ClientMateriel = textBoxMClient.Text;
            ChildForm.NomMateriel = textBoxMNom.Text;
            ChildForm.TypeMateriel = textBoxMType.Text;
            ChildForm.NserieMateriel = textBoxMNserie.Text;
            ChildForm.IdTest = GetTheFuckingID();

            ChildForm.ShowDialog();
        }

        private void FormulaireListeMateriel_Load(object sender, EventArgs e)
        {
            buttonModifierMateriel.Enabled = false;

            string s = "SELECT * FROM Materiel INNER JOIN Client ON Materiel.ClientID = Client.ClientID";

            Requete(s);
        }

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

        private void listBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonModifierMateriel.Enabled = true;

            IdMat truc = (IdMat)(listBoxMateriel.SelectedItem);
            if (truc == null)
                return;
            int id = truc.id;
            IDCrashTest = id.ToString();

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

        private void textBoxMRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            string str = textBoxMRecherche.Text;
            string sql = "select * from Materiel where Nom like '" + str + "%'";
            Requete(sql);
        }
    }
}
