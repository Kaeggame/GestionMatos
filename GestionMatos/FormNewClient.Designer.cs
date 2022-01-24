
namespace GestionMatos
{
    partial class FormulaireNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxNewClient = new System.Windows.Forms.GroupBox();
            this.buttonCCreer = new System.Windows.Forms.Button();
            this.buttonCAnnuler = new System.Windows.Forms.Button();
            this.textBoxCTel = new System.Windows.Forms.TextBox();
            this.textBoxCMail = new System.Windows.Forms.TextBox();
            this.textBoxCNom = new System.Windows.Forms.TextBox();
            this.labelCMail = new System.Windows.Forms.Label();
            this.labelCTel = new System.Windows.Forms.Label();
            this.labelCNom = new System.Windows.Forms.Label();
            this.labelCDescription = new System.Windows.Forms.Label();
            this.textBoxCDescription = new System.Windows.Forms.TextBox();
            this.groupBoxNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewClient
            // 
            this.groupBoxNewClient.Controls.Add(this.textBoxCDescription);
            this.groupBoxNewClient.Controls.Add(this.labelCDescription);
            this.groupBoxNewClient.Controls.Add(this.buttonCCreer);
            this.groupBoxNewClient.Controls.Add(this.buttonCAnnuler);
            this.groupBoxNewClient.Controls.Add(this.textBoxCTel);
            this.groupBoxNewClient.Controls.Add(this.textBoxCMail);
            this.groupBoxNewClient.Controls.Add(this.textBoxCNom);
            this.groupBoxNewClient.Controls.Add(this.labelCMail);
            this.groupBoxNewClient.Controls.Add(this.labelCTel);
            this.groupBoxNewClient.Controls.Add(this.labelCNom);
            this.groupBoxNewClient.Location = new System.Drawing.Point(44, 45);
            this.groupBoxNewClient.Name = "groupBoxNewClient";
            this.groupBoxNewClient.Size = new System.Drawing.Size(1461, 679);
            this.groupBoxNewClient.TabIndex = 13;
            this.groupBoxNewClient.TabStop = false;
            this.groupBoxNewClient.Text = "Client";
            // 
            // buttonCCreer
            // 
            this.buttonCCreer.Location = new System.Drawing.Point(828, 524);
            this.buttonCCreer.Name = "buttonCCreer";
            this.buttonCCreer.Size = new System.Drawing.Size(259, 62);
            this.buttonCCreer.TabIndex = 13;
            this.buttonCCreer.Text = "Créer";
            this.buttonCCreer.UseVisualStyleBackColor = true;
            // 
            // buttonCAnnuler
            // 
            this.buttonCAnnuler.Location = new System.Drawing.Point(361, 524);
            this.buttonCAnnuler.Name = "buttonCAnnuler";
            this.buttonCAnnuler.Size = new System.Drawing.Size(259, 62);
            this.buttonCAnnuler.TabIndex = 12;
            this.buttonCAnnuler.Text = "Annuler";
            this.buttonCAnnuler.UseVisualStyleBackColor = true;
            this.buttonCAnnuler.Click += new System.EventHandler(this.buttonCAnnuler_Click);
            // 
            // textBoxCTel
            // 
            this.textBoxCTel.Location = new System.Drawing.Point(361, 220);
            this.textBoxCTel.Name = "textBoxCTel";
            this.textBoxCTel.Size = new System.Drawing.Size(260, 31);
            this.textBoxCTel.TabIndex = 9;
            // 
            // textBoxCMail
            // 
            this.textBoxCMail.Location = new System.Drawing.Point(998, 86);
            this.textBoxCMail.Name = "textBoxCMail";
            this.textBoxCMail.Size = new System.Drawing.Size(260, 31);
            this.textBoxCMail.TabIndex = 7;
            // 
            // textBoxCNom
            // 
            this.textBoxCNom.Location = new System.Drawing.Point(361, 86);
            this.textBoxCNom.Name = "textBoxCNom";
            this.textBoxCNom.Size = new System.Drawing.Size(260, 31);
            this.textBoxCNom.TabIndex = 6;
            // 
            // labelCMail
            // 
            this.labelCMail.AutoSize = true;
            this.labelCMail.Location = new System.Drawing.Point(823, 86);
            this.labelCMail.Name = "labelCMail";
            this.labelCMail.Size = new System.Drawing.Size(52, 25);
            this.labelCMail.TabIndex = 3;
            this.labelCMail.Text = "Mail";
            // 
            // labelCTel
            // 
            this.labelCTel.AutoSize = true;
            this.labelCTel.Location = new System.Drawing.Point(169, 220);
            this.labelCTel.Name = "labelCTel";
            this.labelCTel.Size = new System.Drawing.Size(143, 25);
            this.labelCTel.TabIndex = 1;
            this.labelCTel.Text = "N° Telephone";
            // 
            // labelCNom
            // 
            this.labelCNom.AutoSize = true;
            this.labelCNom.Location = new System.Drawing.Point(169, 86);
            this.labelCNom.Name = "labelCNom";
            this.labelCNom.Size = new System.Drawing.Size(56, 25);
            this.labelCNom.TabIndex = 0;
            this.labelCNom.Text = "Nom";
            // 
            // labelCDescription
            // 
            this.labelCDescription.AutoSize = true;
            this.labelCDescription.Location = new System.Drawing.Point(823, 220);
            this.labelCDescription.Name = "labelCDescription";
            this.labelCDescription.Size = new System.Drawing.Size(120, 25);
            this.labelCDescription.TabIndex = 14;
            this.labelCDescription.Text = "Description";
            // 
            // textBoxCDescription
            // 
            this.textBoxCDescription.Location = new System.Drawing.Point(998, 220);
            this.textBoxCDescription.Name = "textBoxCDescription";
            this.textBoxCDescription.Size = new System.Drawing.Size(260, 31);
            this.textBoxCDescription.TabIndex = 15;
            // 
            // FormulaireNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1548, 768);
            this.Controls.Add(this.groupBoxNewClient);
            this.Name = "FormulaireNewClient";
            this.Text = "Nouveau Client";
            this.groupBoxNewClient.ResumeLayout(false);
            this.groupBoxNewClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewClient;
        private System.Windows.Forms.Button buttonCCreer;
        private System.Windows.Forms.Button buttonCAnnuler;
        private System.Windows.Forms.TextBox textBoxCTel;
        private System.Windows.Forms.TextBox textBoxCMail;
        private System.Windows.Forms.TextBox textBoxCNom;
        private System.Windows.Forms.Label labelCMail;
        private System.Windows.Forms.Label labelCTel;
        private System.Windows.Forms.Label labelCNom;
        private System.Windows.Forms.TextBox textBoxCDescription;
        private System.Windows.Forms.Label labelCDescription;
    }
}