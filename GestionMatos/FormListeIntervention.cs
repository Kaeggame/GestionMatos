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

        }
    }
}
