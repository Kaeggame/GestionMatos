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
    public partial class FormulaireModifierMateriel : Form
    {
        public string DateMateriel;
        public string CommentaireMateriel;
        public string ClientMateriel;
        //public string SiteMateriel;
        public string NomMateriel;
        public string TypeMateriel;
        public string NserieMateriel;

        public FormulaireModifierMateriel()
        {
            InitializeComponent();
        }

        private void buttonMModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
