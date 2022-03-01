using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class FormulaireModifierIntervention : Form
    {
        public string NomIntervention;
        public string CommentaireIntervention;
        //public string ClientIntervention;
        //public string SiteIntervention;
        //public string MaterielIntervention;
        //public string TypeMaterielIntervention;
        public string DateIntervention;

        public FormulaireModifierIntervention()
        {
            InitializeComponent();
        }

        // vraiment besoin d'explications ?
        private void buttonIModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Je veux dire, VRAIMENT ?
        }

        private void FormulaireModifierIntervention_Load(object sender, EventArgs e)
        {
            this.textBoxIModifierNom.Text = this.NomIntervention;
            this.textBoxIModifierCommentaire.Text = this.CommentaireIntervention;
            //this.textBoxIModifierClient.Text = this.ClientIntervention;
            //this.textBoxIModifierSite.Text = this.SiteIntervention;
            //this.textBoxIModifierMateriel.Text = this.MaterielIntervention;
            //this.textBoxIModifierTypeMateriel.Text = this.TypeMaterielIntervention;
            this.textBoxIModifierDate.Text = this.DateIntervention;
        }
    }
}
