﻿using System;
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
        public FormulaireModifierIntervention()
        {
            InitializeComponent();
        }

        private void buttonIModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
