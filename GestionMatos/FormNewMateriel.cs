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
    public partial class FormulaireNewMateriel : Form
    {
        public FormulaireNewMateriel()
        {
            InitializeComponent();
        }

        // prout
        private void buttonMAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // quoi ?
        }

        private void FormulaireNewMateriel_Load(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            SqlCommand cm = new SqlCommand("select NomClient from Client", cn);
            SqlDataReader dr = cm.ExecuteReader();
            comboBoxClient.Items.Clear();
            while (dr.Read())
            {
                comboBoxClient.Items.Add(dr["NomClient"].ToString());
            }

            dr.Close();

            SqlCommand cp = new SqlCommand("select SiteNom from Site", cn);
            SqlDataReader dra = cp.ExecuteReader();
            comboBoxSite.Items.Clear();
            while (dra.Read())
            {
                comboBoxSite.Items.Add(dra["SiteNom"].ToString());
            }

            dra.Close();
            cn.Close();

        }


        private int getClientId(string nom)
        {
            int res = 0;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select ClientID from Client where NomClient = '" + nom + "'", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            res = Convert.ToInt32(dr["ClientID"]);
            dr.Close();
            sqlConn.Close();

            return res;
        }

        private int getSiteId(string nom)
        {
            int res = 0;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select SiteID from Site where SiteNom = '" + nom + "'", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            res = Convert.ToInt32(dr["SiteID"]);
            dr.Close();
            sqlConn.Close();

            return res;
        }



        private void buttonMCreer_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);

            //Query pour Créer un nouveau Materiel
            // string query = "INSERT INTO Materiel(NumSerie, TypeMat, MTBF, Description, Nom, DateInstallation, ClientID, SiteID) VALUES (@NumSerie, @TypeMat, @MTBF, @Description, @Nom, @DateInstallation)";
            string query = "INSERT INTO Materiel(NumSerie, TypeMat, MTBF, Description, Nom, DateInstallation, ClientID, SiteID)" +
                " VALUES (@NumSerie, @TypeMat, @MTBF, @Description, @Nom, @DateInstallation, @ClientID, @SiteID)";

            string getIDClient = "Select ClientID FROM Client where NomClient = " + comboBoxClient.Text;
            string getIDSite = "Select SiteID FROM Site where SiteNom = " + comboBoxSite.Text;

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlCommand testchouette = new SqlCommand(getIDClient, sqlConn);
            SqlCommand testhibou = new SqlCommand(getIDSite, sqlConn);

            int idclient = this.getClientId(comboBoxClient.Text);
            int idsite = this.getSiteId(comboBoxSite.Text);


            cmd.Parameters.AddWithValue("@NumSerie", textBoxMNserie.Text);
            cmd.Parameters.AddWithValue("@TypeMat", textBoxMTypeMateriel.Text);
            cmd.Parameters.AddWithValue("@MTBF", textBoxNMmtbf.Text);
            cmd.Parameters.AddWithValue("@Description", textBoxMCommentaire.Text);
            cmd.Parameters.AddWithValue("@Nom", textBoxMNomMateriel.Text);
            cmd.Parameters.AddWithValue("@DateInstallation", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@ClientID", idclient);
            cmd.Parameters.AddWithValue("@SiteID", idsite);


            string query22 = cmd.CommandText;

            foreach (SqlParameter p in cmd.Parameters)
            {
                query22 = query22.Replace(p.ParameterName, p.Value.ToString());
            }




            // cmd.Parameters.AddWithValue("@ClientID", comboBoxClient.Text);
            // cmd.Parameters.AddWithValue("@SiteID", comboBoxSite.Text);

            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            //Fin de la query
            Form.ActiveForm.Close(); // Ferme la fenetre actuelle apres la confirmation de la modification
            MessageBox.Show("Création éffectuée");
            sqlConn.Close();
        }
    }
}
