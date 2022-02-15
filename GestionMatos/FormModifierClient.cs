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
    public partial class FormulaireModifierClient : Form
    {
        public string NomClient;
        public string MailClient;
        public string TelClient;
        public string DescriptionClient;


        public FormulaireModifierClient()
        {
            InitializeComponent();
        }

        private void buttonCModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormulaireModifierClient_Load(object sender, EventArgs e)
        {
            this.textBoxCModifierNom.Text = this.NomClient;
            this.textBoxCModifierMail.Text = this.MailClient;
            this.textBoxCModifierTel.Text = this.TelClient;
            this.textBoxCModifierDescription.Text = this.DescriptionClient;

        }
    }
}
