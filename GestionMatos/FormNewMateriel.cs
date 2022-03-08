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
    }
}
