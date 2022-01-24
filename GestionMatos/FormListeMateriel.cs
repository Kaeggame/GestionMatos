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

        private void FormulaireListeMateriel_Load(object sender, EventArgs e)
        {
            string s = "select * from Materiel";

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
                IdMat Mat = new IdMat(id, lenommat, lenumserie, letypemat, ladateinstall, ladesc, lemtbf);

                listBoxMateriel.Items.Add(Mat);
            }

            sqr.Close();
            cn.Close();
        }

        private void listBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdMat truc = (IdMat)(listBoxMateriel.SelectedItem);
            int id = truc.id;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            string sql = "select * from Materiel where MatID = " + id.ToString();
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader sqr = com.ExecuteReader();
            sqr.Read();
            textBoxMNom.Text = sqr["Nom"].ToString();
            textBoxMNserie.Text = sqr["NumSerie"].ToString();
            textBoxMType.Text = sqr["TypeMat"].ToString();
            textBoxMClient.Text = "badaboup";
            textBoxMDate.Text = sqr["DateInstallation"].ToString();
            textBoxMmtbf.Text = sqr["MTBF"].ToString() + " ans";
            textBoxMDescription.Text = sqr["Description"].ToString();
            cn.Close();
        }

    }
}
