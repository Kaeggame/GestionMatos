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
    }
}
