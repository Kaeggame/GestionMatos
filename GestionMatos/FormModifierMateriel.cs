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
    public partial class FormulaireModifierMateriel : Form
    {
        public string DateMateriel;
        public string CommentaireMateriel;
        public string ClientMateriel;
        //public string SiteMateriel;
        public string NomMateriel;
        public string TypeMateriel;
        public string NserieMateriel;
        public string IdTest; 

        public FormulaireModifierMateriel()
        {
            InitializeComponent();
        }

        // la blague commence à être lourde non ?
        private void buttonMModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // ...meh
        }

        private void FormulaireModifierMateriel_Load(object sender, EventArgs e)
        {
            this.textBoxMModifierDate.Text = this.DateMateriel;
            this.textBoxMModifierCommentaire.Text = this.CommentaireMateriel;
            this.textBoxMModifierClient.Text = this.ClientMateriel;
            //this.textBoxMModifierSite.Text = this.SiteMateriel;
            this.textBoxMModifierNomMateriel.Text = this.NomMateriel;
            this.textBoxMModifierTypeMateriel.Text = this.TypeMateriel;
            this.textBoxMModifierNserie.Text = this.NserieMateriel;
        }

        // Boutton qui remplace les infos de la base de données avec ce qui est écrits dans les champs (Vraiment faites gaffes avec ça, c'est pas un jouet)
        private void buttonMModifier_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);
            
            string query = "UPDATE Materiel SET Nom = @Nom,NumSerie = @NumSerie,Description = @Description,TypeMat = @TypeMat,DateInstallation = @DateInstallation where MatID = " + IdTest.ToString();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.Parameters.AddWithValue("@Nom", textBoxMModifierNomMateriel.Text);
            cmd.Parameters.AddWithValue("@NumSerie", textBoxMModifierNserie.Text);
            cmd.Parameters.AddWithValue("@Description", textBoxMModifierCommentaire.Text);
            cmd.Parameters.AddWithValue("@TypeMat", textBoxMModifierTypeMateriel.Text);
            cmd.Parameters.AddWithValue("@DateInstallation", textBoxMModifierDate.Text);
            cmd.Connection.Open();
            try
            {              
               cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            Form.ActiveForm.Close(); // Ferme la fenetre actuelle apres la confirmation de la modification
            MessageBox.Show("Modification enregistrée");
            sqlConn.Close();
            
        }
    }
}
