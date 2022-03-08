
namespace GestionMatos
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConnexion = new System.Windows.Forms.GroupBox();
            this.labelGestionMatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MDP = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.groupBoxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnexion
            // 
            this.groupBoxConnexion.Controls.Add(this.labelGestionMatos);
            this.groupBoxConnexion.Controls.Add(this.label2);
            this.groupBoxConnexion.Controls.Add(this.label1);
            this.groupBoxConnexion.Controls.Add(this.textBox_MDP);
            this.groupBoxConnexion.Controls.Add(this.textBoxEmail);
            this.groupBoxConnexion.Controls.Add(this.buttonConnexion);
            this.groupBoxConnexion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnexion.Name = "groupBoxConnexion";
            this.groupBoxConnexion.Size = new System.Drawing.Size(776, 426);
            this.groupBoxConnexion.TabIndex = 0;
            this.groupBoxConnexion.TabStop = false;
            this.groupBoxConnexion.Text = "Connexion";
            // 
            // labelGestionMatos
            // 
            this.labelGestionMatos.AutoSize = true;
            this.labelGestionMatos.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionMatos.Location = new System.Drawing.Point(289, 34);
            this.labelGestionMatos.Name = "labelGestionMatos";
            this.labelGestionMatos.Size = new System.Drawing.Size(186, 36);
            this.labelGestionMatos.TabIndex = 3;
            this.labelGestionMatos.Text = "GestionMatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // textBox_MDP
            // 
            this.textBox_MDP.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox_MDP.Location = new System.Drawing.Point(295, 179);
            this.textBox_MDP.Name = "textBox_MDP";
            this.textBox_MDP.PasswordChar = '*';
            this.textBox_MDP.Size = new System.Drawing.Size(168, 20);
            this.textBox_MDP.TabIndex = 1;
            this.textBox_MDP.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxEmail.Location = new System.Drawing.Point(295, 124);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(317, 223);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(126, 37);
            this.buttonConnexion.TabIndex = 0;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.groupBoxConnexion);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnexion_FormClosing);
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.groupBoxConnexion.ResumeLayout(false);
            this.groupBoxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnexion;
        private System.Windows.Forms.TextBox textBox_MDP;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGestionMatos;
        private System.Windows.Forms.Label label2;
    }
}

