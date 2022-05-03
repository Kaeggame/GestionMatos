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
    public partial class FormulaireNewIntervention : System.Windows.Forms.Form
    {
        public FormulaireNewIntervention()
        {
            InitializeComponent();
        }

        private void buttonIAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormulaireNewIntervention_Load(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            SqlConnection cn = new SqlConnection(cnsql);
            cn.Open();
            SqlCommand cm = new SqlCommand("select Nom from Materiel", cn);
            SqlDataReader dr = cm.ExecuteReader();
            comboBoxInter.Items.Clear();
            while (dr.Read())
            {
                comboBoxInter.Items.Add(dr["Nom"].ToString());
            }

            dr.Close();
        }

        private int getMaterielId(string nom)
        {
            int res = 0;

            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("select MatID from Materiel where Nom = '" + nom + "'", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            res = Convert.ToInt32(dr["MatID"]);
            dr.Close();
            sqlConn.Close();

            return res;
        }

        private void buttonICreer_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);

            //Query pour Créer un nouveau Materiel
            // string query = "INSERT INTO Materiel(NumSerie, TypeMat, MTBF, Description, Nom, DateInstallation, ClientID, SiteID) VALUES (@NumSerie, @TypeMat, @MTBF, @Description, @Nom, @DateInstallation)";
            string query = "INSERT INTO Intervention(InterDate, InterNom, Commentaire, MatID)" +
                " VALUES (@InterDate,  @InterNom, @Commentaire, @MatID)";

            string getIDClient = "Select ClientID FROM Client where NomClient = " + comboBoxInter.Text;

            SqlCommand cmd = new SqlCommand(query, sqlConn);

            int idmat = this.getMaterielId(comboBoxInter.Text);

            cmd.Parameters.AddWithValue("@InterDate", dateTimePickerInter.Value);
            cmd.Parameters.AddWithValue("@InterNom", textBoxINom.Text);
            cmd.Parameters.AddWithValue("@Commentaire", textBoxIComentaire.Text);
            cmd.Parameters.AddWithValue("@MatID", idmat);

            cmd.Connection.Open();

            bool Error = false; //Créer la valeur booléen pour une erreur
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) //Grab l'erreur
            {
                Error = true;
                MessageBox.Show("Création Impossible, une intervention est déjà prévu sur ce materiel"); // Affiche un message d'erreur

            }
            //Fin de la query
            Form.ActiveForm.Close(); // Ferme la fenetre actuelle apres la confirmation de la modification

            if (Error == false) //Vérifie si il y a eu une erreur dans la création d'intervention, si non, execute le code ci dessous
            {
                MessageBox.Show("Création éffectuée");
                sqlConn.Close();
            }
        }
    }
}
