
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
            this.buttonCActualiser = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.labelCChercher = new System.Windows.Forms.Label();
            this.groupBoxMInfos = new System.Windows.Forms.GroupBox();
            this.textBoxCTel = new System.Windows.Forms.TextBox();
            this.labelCTel = new System.Windows.Forms.Label();
            this.textBoxCMail = new System.Windows.Forms.TextBox();
            this.labelCMail = new System.Windows.Forms.Label();
            this.textBoxCNom = new System.Windows.Forms.TextBox();
            this.labelCNom = new System.Windows.Forms.Label();
            this.textBoxCRecherche = new System.Windows.Forms.TextBox();
            this.buttonListeCRetour = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxMInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonCActualiser);
            this.groupBoxClient.Controls.Add(this.buttonModifierClient);
            this.groupBoxClient.Controls.Add(this.labelCChercher);
            this.groupBoxClient.Controls.Add(this.groupBoxMInfos);
            this.groupBoxClient.Controls.Add(this.textBoxCRecherche);
            this.groupBoxClient.Controls.Add(this.buttonListeCRetour);
            this.groupBoxClient.Controls.Add(this.listBoxClient);
            this.groupBoxClient.Controls.Add(this.buttonNewClient);
            this.groupBoxClient.Location = new System.Drawing.Point(32, 35);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClient.Size = new System.Drawing.Size(1478, 875);
            this.groupBoxClient.TabIndex = 1;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Clients";
            // 
            // buttonCActualiser
            // 
            this.buttonCActualiser.Location = new System.Drawing.Point(1204, 33);
            this.buttonCActualiser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCActualiser.Name = "buttonCActualiser";
            this.buttonCActualiser.Size = new System.Drawing.Size(144, 63);
            this.buttonCActualiser.TabIndex = 33;
            this.buttonCActualiser.Text = "Actualiser";
            this.buttonCActualiser.UseVisualStyleBackColor = true;
            this.buttonCActualiser.Click += new System.EventHandler(this.buttonCActualiser_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Location = new System.Drawing.Point(912, 769);
            this.buttonModifierClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(242, 87);
            this.buttonModifierClient.TabIndex = 32;
            this.buttonModifierClient.Text = "Modifer";
            this.buttonModifierClient.UseVisualStyleBackColor = true;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // labelCChercher
            // 
            this.labelCChercher.AutoSize = true;
            this.labelCChercher.Location = new System.Drawing.Point(16, 52);
            this.labelCChercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCChercher.Name = "labelCChercher";
            this.labelCChercher.Size = new System.Drawing.Size(100, 25);
            this.labelCChercher.TabIndex = 31;
            this.labelCChercher.Text = "Chercher";
            // 
            // groupBoxMInfos
            // 
            this.groupBoxMInfos.Controls.Add(this.textBoxCTel);
            this.groupBoxMInfos.Controls.Add(this.labelCTel);
            this.groupBoxMInfos.Controls.Add(this.textBoxCMail);
            this.groupBoxMInfos.Controls.Add(this.labelCMail);
            this.groupBoxMInfos.Controls.Add(this.textBoxCNom);
            this.groupBoxMInfos.Controls.Add(this.labelCNom);
            this.groupBoxMInfos.Location = new System.Drawing.Point(412, 102);
            this.groupBoxMInfos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMInfos.Name = "groupBoxMInfos";
            this.groupBoxMInfos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMInfos.Size = new System.Drawing.Size(1034, 610);
            this.groupBoxMInfos.TabIndex = 30;
            this.groupBoxMInfos.TabStop = false;
            this.groupBoxMInfos.Text = "Informations";
            // 
            // textBoxCTel
            // 
            this.textBoxCTel.Location = new System.Drawing.Point(198, 300);
            this.textBoxCTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCTel.Name = "textBoxCTel";
            this.textBoxCTel.ReadOnly = true;
            this.textBoxCTel.Size = new System.Drawing.Size(286, 31);
            this.textBoxCTel.TabIndex = 22;
            // 
            // labelCTel
            // 
            this.labelCTel.AutoSize = true;
            this.labelCTel.Location = new System.Drawing.Point(6, 300);
            this.labelCTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCTel.Name = "labelCTel";
            this.labelCTel.Size = new System.Drawing.Size(173, 25);
            this.labelCTel.TabIndex = 21;
            this.labelCTel.Text = "N° de Téléphone";
            // 
            // textBoxCMail
            // 
            this.textBoxCMail.Location = new System.Drawing.Point(198, 167);
            this.textBoxCMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCMail.Name = "textBoxCMail";
            this.textBoxCMail.ReadOnly = true;
            this.textBoxCMail.Size = new System.Drawing.Size(286, 31);
            this.textBoxCMail.TabIndex = 18;
            // 
            // labelCMail
            // 
            this.labelCMail.AutoSize = true;
            this.labelCMail.Location = new System.Drawing.Point(116, 171);
            this.labelCMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCMail.Name = "labelCMail";
            this.labelCMail.Size = new System.Drawing.Size(64, 25);
            this.labelCMail.TabIndex = 17;
            this.labelCMail.Text = "eMail";
            // 
            // textBoxCNom
            // 
            this.textBoxCNom.Location = new System.Drawing.Point(198, 44);
            this.textBoxCNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCNom.Name = "textBoxCNom";
            this.textBoxCNom.ReadOnly = true;
            this.textBoxCNom.Size = new System.Drawing.Size(286, 31);
            this.textBoxCNom.TabIndex = 16;
            // 
            // labelCNom
            // 
            this.labelCNom.AutoSize = true;
            this.labelCNom.Location = new System.Drawing.Point(124, 52);
            this.labelCNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNom.Name = "labelCNom";
            this.labelCNom.Size = new System.Drawing.Size(56, 25);
            this.labelCNom.TabIndex = 15;
            this.labelCNom.Text = "Nom";
            // 
            // textBoxCRecherche
            // 
            this.textBoxCRecherche.Location = new System.Drawing.Point(122, 48);
            this.textBoxCRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCRecherche.Name = "textBoxCRecherche";
            this.textBoxCRecherche.Size = new System.Drawing.Size(1032, 31);
            this.textBoxCRecherche.TabIndex = 13;
            this.textBoxCRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCRecherche_KeyUp);
            // 
            // buttonListeCRetour
            // 
            this.buttonListeCRetour.Location = new System.Drawing.Point(610, 769);
            this.buttonListeCRetour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListeCRetour.Name = "buttonListeCRetour";
            this.buttonListeCRetour.Size = new System.Drawing.Size(242, 87);
            this.buttonListeCRetour.TabIndex = 12;
            this.buttonListeCRetour.Text = "Retour";
            this.buttonListeCRetour.UseVisualStyleBackColor = true;
            this.buttonListeCRetour.Click += new System.EventHandler(this.buttonListeCRetour_Click);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 25;
            this.listBoxClient.Location = new System.Drawing.Point(20, 102);
            this.listBoxClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(352, 754);
            this.listBoxClient.TabIndex = 11;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(1204, 769);
            this.buttonNewClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(242, 87);
            this.buttonNewClient.TabIndex = 8;
            this.buttonNewClient.Text = "Nouveau Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // FormulaireListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1546, 937);
            this.Controls.Add(this.groupBoxClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.TextBox textBoxCRecherche;
        private System.Windows.Forms.GroupBox groupBoxMInfos;
        private System.Windows.Forms.TextBox textBoxCTel;
        private System.Windows.Forms.Label labelCTel;
        private System.Windows.Forms.TextBox textBoxCMail;
        private System.Windows.Forms.Label labelCMail;
        private System.Windows.Forms.TextBox textBoxCNom;
        private System.Windows.Forms.Label labelCNom;
        private System.Windows.Forms.Label labelCChercher;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonCActualiser;
    }
}