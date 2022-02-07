
namespace GestionMatos
{
    partial class FormulaireListeClient
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
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.labelCChercher = new System.Windows.Forms.Label();
            this.groupBoxMInfos = new System.Windows.Forms.GroupBox();
            this.textBoxCTel = new System.Windows.Forms.TextBox();
            this.labelCTel = new System.Windows.Forms.Label();
            this.textBoxCDescription = new System.Windows.Forms.TextBox();
            this.labelCDescription = new System.Windows.Forms.Label();
            this.textBoxCMail = new System.Windows.Forms.TextBox();
            this.labelCMail = new System.Windows.Forms.Label();
            this.textBoxCNom = new System.Windows.Forms.TextBox();
            this.labelCNom = new System.Windows.Forms.Label();
            this.comboBoxCFiltre = new System.Windows.Forms.ComboBox();
            this.textBoxCRecherche = new System.Windows.Forms.TextBox();
            this.buttonListeCRetour = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.buttonCFiltre = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxMInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonModifierClient);
            this.groupBoxClient.Controls.Add(this.labelCChercher);
            this.groupBoxClient.Controls.Add(this.groupBoxMInfos);
            this.groupBoxClient.Controls.Add(this.comboBoxCFiltre);
            this.groupBoxClient.Controls.Add(this.textBoxCRecherche);
            this.groupBoxClient.Controls.Add(this.buttonListeCRetour);
            this.groupBoxClient.Controls.Add(this.listBoxClient);
            this.groupBoxClient.Controls.Add(this.buttonCFiltre);
            this.groupBoxClient.Controls.Add(this.buttonNewClient);
            this.groupBoxClient.Location = new System.Drawing.Point(16, 18);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxClient.Size = new System.Drawing.Size(739, 455);
            this.groupBoxClient.TabIndex = 1;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Clients";
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Location = new System.Drawing.Point(456, 400);
            this.buttonModifierClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(121, 45);
            this.buttonModifierClient.TabIndex = 32;
            this.buttonModifierClient.Text = "Modifer";
            this.buttonModifierClient.UseVisualStyleBackColor = true;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // labelCChercher
            // 
            this.labelCChercher.AutoSize = true;
            this.labelCChercher.Location = new System.Drawing.Point(8, 27);
            this.labelCChercher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCChercher.Name = "labelCChercher";
            this.labelCChercher.Size = new System.Drawing.Size(50, 13);
            this.labelCChercher.TabIndex = 31;
            this.labelCChercher.Text = "Chercher";
            // 
            // groupBoxMInfos
            // 
            this.groupBoxMInfos.Controls.Add(this.textBoxCTel);
            this.groupBoxMInfos.Controls.Add(this.labelCTel);
            this.groupBoxMInfos.Controls.Add(this.textBoxCDescription);
            this.groupBoxMInfos.Controls.Add(this.labelCDescription);
            this.groupBoxMInfos.Controls.Add(this.textBoxCMail);
            this.groupBoxMInfos.Controls.Add(this.labelCMail);
            this.groupBoxMInfos.Controls.Add(this.textBoxCNom);
            this.groupBoxMInfos.Controls.Add(this.labelCNom);
            this.groupBoxMInfos.Location = new System.Drawing.Point(206, 108);
            this.groupBoxMInfos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMInfos.Name = "groupBoxMInfos";
            this.groupBoxMInfos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMInfos.Size = new System.Drawing.Size(517, 262);
            this.groupBoxMInfos.TabIndex = 30;
            this.groupBoxMInfos.TabStop = false;
            this.groupBoxMInfos.Text = "Informations";
            // 
            // textBoxCTel
            // 
            this.textBoxCTel.Location = new System.Drawing.Point(99, 156);
            this.textBoxCTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCTel.Name = "textBoxCTel";
            this.textBoxCTel.ReadOnly = true;
            this.textBoxCTel.Size = new System.Drawing.Size(145, 20);
            this.textBoxCTel.TabIndex = 22;
            // 
            // labelCTel
            // 
            this.labelCTel.AutoSize = true;
            this.labelCTel.Location = new System.Drawing.Point(3, 156);
            this.labelCTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCTel.Name = "labelCTel";
            this.labelCTel.Size = new System.Drawing.Size(88, 13);
            this.labelCTel.TabIndex = 21;
            this.labelCTel.Text = "N° de Téléphone";
            // 
            // textBoxCDescription
            // 
            this.textBoxCDescription.Location = new System.Drawing.Point(99, 219);
            this.textBoxCDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCDescription.Name = "textBoxCDescription";
            this.textBoxCDescription.ReadOnly = true;
            this.textBoxCDescription.Size = new System.Drawing.Size(405, 20);
            this.textBoxCDescription.TabIndex = 20;
            // 
            // labelCDescription
            // 
            this.labelCDescription.AutoSize = true;
            this.labelCDescription.Location = new System.Drawing.Point(30, 219);
            this.labelCDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCDescription.Name = "labelCDescription";
            this.labelCDescription.Size = new System.Drawing.Size(60, 13);
            this.labelCDescription.TabIndex = 19;
            this.labelCDescription.Text = "Description";
            // 
            // textBoxCMail
            // 
            this.textBoxCMail.Location = new System.Drawing.Point(99, 87);
            this.textBoxCMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCMail.Name = "textBoxCMail";
            this.textBoxCMail.ReadOnly = true;
            this.textBoxCMail.Size = new System.Drawing.Size(145, 20);
            this.textBoxCMail.TabIndex = 18;
            // 
            // labelCMail
            // 
            this.labelCMail.AutoSize = true;
            this.labelCMail.Location = new System.Drawing.Point(58, 89);
            this.labelCMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCMail.Name = "labelCMail";
            this.labelCMail.Size = new System.Drawing.Size(32, 13);
            this.labelCMail.TabIndex = 17;
            this.labelCMail.Text = "eMail";
            // 
            // textBoxCNom
            // 
            this.textBoxCNom.Location = new System.Drawing.Point(99, 23);
            this.textBoxCNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCNom.Name = "textBoxCNom";
            this.textBoxCNom.ReadOnly = true;
            this.textBoxCNom.Size = new System.Drawing.Size(145, 20);
            this.textBoxCNom.TabIndex = 16;
            // 
            // labelCNom
            // 
            this.labelCNom.AutoSize = true;
            this.labelCNom.Location = new System.Drawing.Point(62, 27);
            this.labelCNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCNom.Name = "labelCNom";
            this.labelCNom.Size = new System.Drawing.Size(29, 13);
            this.labelCNom.TabIndex = 15;
            this.labelCNom.Text = "Nom";
            // 
            // comboBoxCFiltre
            // 
            this.comboBoxCFiltre.FormattingEnabled = true;
            this.comboBoxCFiltre.Location = new System.Drawing.Point(336, 61);
            this.comboBoxCFiltre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCFiltre.Name = "comboBoxCFiltre";
            this.comboBoxCFiltre.Size = new System.Drawing.Size(388, 21);
            this.comboBoxCFiltre.TabIndex = 15;
            this.comboBoxCFiltre.Text = "Filtres";
            // 
            // textBoxCRecherche
            // 
            this.textBoxCRecherche.Location = new System.Drawing.Point(61, 25);
            this.textBoxCRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCRecherche.Name = "textBoxCRecherche";
            this.textBoxCRecherche.Size = new System.Drawing.Size(663, 20);
            this.textBoxCRecherche.TabIndex = 13;
            this.textBoxCRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCRecherche_KeyUp);
            // 
            // buttonListeCRetour
            // 
            this.buttonListeCRetour.Location = new System.Drawing.Point(305, 400);
            this.buttonListeCRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListeCRetour.Name = "buttonListeCRetour";
            this.buttonListeCRetour.Size = new System.Drawing.Size(121, 45);
            this.buttonListeCRetour.TabIndex = 12;
            this.buttonListeCRetour.Text = "Retour";
            this.buttonListeCRetour.UseVisualStyleBackColor = true;
            this.buttonListeCRetour.Click += new System.EventHandler(this.buttonListeCRetour_Click);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(10, 53);
            this.listBoxClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(178, 394);
            this.listBoxClient.TabIndex = 11;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // buttonCFiltre
            // 
            this.buttonCFiltre.Location = new System.Drawing.Point(220, 53);
            this.buttonCFiltre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCFiltre.Name = "buttonCFiltre";
            this.buttonCFiltre.Size = new System.Drawing.Size(104, 31);
            this.buttonCFiltre.TabIndex = 9;
            this.buttonCFiltre.Text = "Filtre";
            this.buttonCFiltre.UseVisualStyleBackColor = true;
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(602, 400);
            this.buttonNewClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(121, 45);
            this.buttonNewClient.TabIndex = 8;
            this.buttonNewClient.Text = "Nouveau Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // FormulaireListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(773, 487);
            this.Controls.Add(this.groupBoxClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormulaireListeClient";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormulaireListeClient_Load);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxMInfos.ResumeLayout(false);
            this.groupBoxMInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button buttonListeCRetour;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Button buttonCFiltre;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.TextBox textBoxCRecherche;
        private System.Windows.Forms.ComboBox comboBoxCFiltre;
        private System.Windows.Forms.GroupBox groupBoxMInfos;
        private System.Windows.Forms.TextBox textBoxCTel;
        private System.Windows.Forms.Label labelCTel;
        private System.Windows.Forms.TextBox textBoxCDescription;
        private System.Windows.Forms.Label labelCDescription;
        private System.Windows.Forms.TextBox textBoxCMail;
        private System.Windows.Forms.Label labelCMail;
        private System.Windows.Forms.TextBox textBoxCNom;
        private System.Windows.Forms.Label labelCNom;
        private System.Windows.Forms.Label labelCChercher;
        private System.Windows.Forms.Button buttonModifierClient;
    }
}