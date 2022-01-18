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

            ChildForm.Show();
        }

        private void buttonModifierMateriel_Click(object sender, EventArgs e)
        {
            FormulaireModifierMateriel ChildForm = new FormulaireModifierMateriel();

            ChildForm.Show();
        }
    }
}
