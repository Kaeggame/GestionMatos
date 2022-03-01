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
    public partial class FormConnexion : System.Windows.Forms.Form
    {
        
        public FormConnexion()
        {
            InitializeComponent();
            this.Connexion = false; // Quand la fenêtre est ouverte fixe la variable Connexion à "false"
        }

        private string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;"; // On entre dans une variable l'adresse du serveur de la base de données 
        private bool Connexion; // initialisation de la variable Connexion 

        // Quand on clique sur le bouton de connexion...
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            // ...renvoi un message d'erreur si les champs sont vides...
            if (textBoxEmail.Text == "" || textBox_MDP.Text == "")
            {
                MessageBox.Show("Veuillez écrire vos identifiant");
                return;
            }
            // ...ou recherche dans la base de données un utilisateur dont les infos corespond à ceux entrés dans les champs
            try
            {
                SqlConnection con = new SqlConnection(cnsql); // commande qui entre l'address de la base de donnée pour s'y connecter 
                SqlCommand cmd = new SqlCommand("Select * from Utilisateur where Nom_User=@username and Mdp=@password", con); // Requette contenant des "trous"
                cmd.Parameters.AddWithValue("@username", textBoxEmail.Text); // Remplace le "trou" email dans la requette par le texte dans le champ email
                cmd.Parameters.AddWithValue("@password", textBox_MDP.Text); // Remplace le "trou" mot de passe dans la rquette par le texte dans le champ mot de passe
                con.Open(); 
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count; // varriable compteur qui incrémentera en fonction de si il trouve un résultat à la requete (en général 1 ou 0)
               
                // Si Il existe un Utilisateur correspondant aux infos des champs, on autorise la connexion en passant la variable Connexion en "true"
                if (count == 1)
                {
                    this.Connexion = true;
                    this.Close();
                }
                // Sinon on indiquera que l'utilisateur n'existe pas et on bloque la connexion
                else
                {
                    MessageBox.Show("Email ou Mot de Passe erroné");
                }
            }
            // gestion d'erreur
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // inutile pour l'instant -_-
        private void FormConnexion_Load(object sender, EventArgs e)
        {
            // Yep
        }

        // Si on ferme la fenêtre mais que la variable Connexion est toujours "false" (et donc qu'aucune connexion n'a été authorisé), on ferme l'application avec
        private void FormConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Connexion == false)
            {
                Application.Exit();
            }
        }
    }
}
