
namespace GestionMatos
{
    partial class FormulaireListeMateriel
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
            this.groupBoxMateriel = new System.Windows.Forms.GroupBox();
            this.buttonListeMRetour = new System.Windows.Forms.Button();
            this.listBoxMateriel = new System.Windows.Forms.ListBox();
            this.textBoxMRecherche = new System.Windows.Forms.TextBox();
            this.buttonMFiltre = new System.Windows.Forms.Button();
            this.buttonNewMateriel = new System.Windows.Forms.Button();
            this.comboBoxMFiltre = new System.Windows.Forms.ComboBox();
            this.labelMNom = new System.Windows.Forms.Label();
            this.textBoxMNom = new System.Windows.Forms.TextBox();
            this.textBoxMNserie = new System.Windows.Forms.TextBox();
            this.labelMNserie = new System.Windows.Forms.Label();
            this.textBoxMDescription = new System.Windows.Forms.TextBox();
            this.labelMDescription = new System.Windows.Forms.Label();
            this.textBoxMType = new System.Windows.Forms.TextBox();
            this.labelMType = new System.Windows.Forms.Label();
            this.textBoxMClient = new System.Windows.Forms.TextBox();
            this.labelMClient = new System.Windows.Forms.Label();
            this.textBoxMmtbf = new System.Windows.Forms.TextBox();
            this.labelMmtbf = new System.Windows.Forms.Label();
            this.textBoxMDate = new System.Windows.Forms.TextBox();
            this.labelMDate = new System.Windows.Forms.Label();
            this.groupBoxMInfos = new System.Windows.Forms.GroupBox();
            this.groupBoxMateriel.SuspendLayout();
            this.groupBoxMInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMateriel
            // 
            this.groupBoxMateriel.Controls.Add(this.groupBoxMInfos);
            this.groupBoxMateriel.Controls.Add(this.comboBoxMFiltre);
            this.groupBoxMateriel.Controls.Add(this.buttonListeMRetour);
            this.groupBoxMateriel.Controls.Add(this.listBoxMateriel);
            this.groupBoxMateriel.Controls.Add(this.textBoxMRecherche);
            this.groupBoxMateriel.Controls.Add(this.buttonMFiltre);
            this.groupBoxMateriel.Controls.Add(this.buttonNewMateriel);
            this.groupBoxMateriel.Location = new System.Drawing.Point(32, 31);
            this.groupBoxMateriel.Name = "groupBoxMateriel";
            this.groupBoxMateriel.Size = new System.Drawing.Size(1478, 869);
            this.groupBoxMateriel.TabIndex = 0;
            this.groupBoxMateriel.TabStop = false;
            this.groupBoxMateriel.Text = "Materiels";
            // 
            // buttonListeMRetour
            // 
            this.buttonListeMRetour.Location = new System.Drawing.Point(905, 769);
            this.buttonListeMRetour.Name = "buttonListeMRetour";
            this.buttonListeMRetour.Size = new System.Drawing.Size(242, 86);
            this.buttonListeMRetour.TabIndex = 13;
            this.buttonListeMRetour.Text = "Retour";
            this.buttonListeMRetour.UseVisualStyleBackColor = true;
            this.buttonListeMRetour.Click += new System.EventHandler(this.buttonListeMRetour_Click);
            // 
            // listBoxMateriel
            // 
            this.listBoxMateriel.FormattingEnabled = true;
            this.listBoxMateriel.ItemHeight = 25;
            this.listBoxMateriel.Location = new System.Drawing.Point(24, 126);
            this.listBoxMateriel.Name = "listBoxMateriel";
            this.listBoxMateriel.Size = new System.Drawing.Size(351, 729);
            this.listBoxMateriel.TabIndex = 11;
            // 
            // textBoxMRecherche
            // 
            this.textBoxMRecherche.Location = new System.Drawing.Point(24, 53);
            this.textBoxMRecherche.Name = "textBoxMRecherche";
            this.textBoxMRecherche.Size = new System.Drawing.Size(1424, 31);
            this.textBoxMRecherche.TabIndex = 10;
            this.textBoxMRecherche.Text = "Chercher...";
            // 
            // buttonMFiltre
            // 
            this.buttonMFiltre.Location = new System.Drawing.Point(450, 126);
            this.buttonMFiltre.Name = "buttonMFiltre";
            this.buttonMFiltre.Size = new System.Drawing.Size(209, 60);
            this.buttonMFiltre.TabIndex = 9;
            this.buttonMFiltre.Text = "Filtre";
            this.buttonMFiltre.UseVisualStyleBackColor = true;
            // 
            // buttonNewMateriel
            // 
            this.buttonNewMateriel.Location = new System.Drawing.Point(1206, 769);
            this.buttonNewMateriel.Name = "buttonNewMateriel";
            this.buttonNewMateriel.Size = new System.Drawing.Size(242, 86);
            this.buttonNewMateriel.TabIndex = 8;
            this.buttonNewMateriel.Text = "Nouveau Materiel";
            this.buttonNewMateriel.UseVisualStyleBackColor = true;
            this.buttonNewMateriel.Click += new System.EventHandler(this.buttonNewMateriel_Click);
            // 
            // comboBoxMFiltre
            // 
            this.comboBoxMFiltre.FormattingEnabled = true;
            this.comboBoxMFiltre.Location = new System.Drawing.Point(677, 141);
            this.comboBoxMFiltre.Name = "comboBoxMFiltre";
            this.comboBoxMFiltre.Size = new System.Drawing.Size(771, 33);
            this.comboBoxMFiltre.TabIndex = 14;
            this.comboBoxMFiltre.Text = "Filtres";
            // 
            // labelMNom
            // 
            this.labelMNom.AutoSize = true;
            this.labelMNom.Location = new System.Drawing.Point(123, 51);
            this.labelMNom.Name = "labelMNom";
            this.labelMNom.Size = new System.Drawing.Size(56, 25);
            this.labelMNom.TabIndex = 15;
            this.labelMNom.Text = "Nom";
            // 
            // textBoxMNom
            // 
            this.textBoxMNom.Location = new System.Drawing.Point(198, 45);
            this.textBoxMNom.Name = "textBoxMNom";
            this.textBoxMNom.Size = new System.Drawing.Size(286, 31);
            this.textBoxMNom.TabIndex = 16;
            // 
            // textBoxMNserie
            // 
            this.textBoxMNserie.Location = new System.Drawing.Point(198, 168);
            this.textBoxMNserie.Name = "textBoxMNserie";
            this.textBoxMNserie.Size = new System.Drawing.Size(286, 31);
            this.textBoxMNserie.TabIndex = 18;
            // 
            // labelMNserie
            // 
            this.labelMNserie.AutoSize = true;
            this.labelMNserie.Location = new System.Drawing.Point(58, 171);
            this.labelMNserie.Name = "labelMNserie";
            this.labelMNserie.Size = new System.Drawing.Size(121, 25);
            this.labelMNserie.TabIndex = 17;
            this.labelMNserie.Text = "N° de Série";
            // 
            // textBoxMDescription
            // 
            this.textBoxMDescription.Location = new System.Drawing.Point(198, 422);
            this.textBoxMDescription.Name = "textBoxMDescription";
            this.textBoxMDescription.Size = new System.Drawing.Size(806, 31);
            this.textBoxMDescription.TabIndex = 20;
            // 
            // labelMDescription
            // 
            this.labelMDescription.AutoSize = true;
            this.labelMDescription.Location = new System.Drawing.Point(59, 422);
            this.labelMDescription.Name = "labelMDescription";
            this.labelMDescription.Size = new System.Drawing.Size(120, 25);
            this.labelMDescription.TabIndex = 19;
            this.labelMDescription.Text = "Description";
            // 
            // textBoxMType
            // 
            this.textBoxMType.Location = new System.Drawing.Point(198, 300);
            this.textBoxMType.Name = "textBoxMType";
            this.textBoxMType.Size = new System.Drawing.Size(286, 31);
            this.textBoxMType.TabIndex = 22;
            // 
            // labelMType
            // 
            this.labelMType.AutoSize = true;
            this.labelMType.Location = new System.Drawing.Point(6, 300);
            this.labelMType.Name = "labelMType";
            this.labelMType.Size = new System.Drawing.Size(173, 25);
            this.labelMType.TabIndex = 21;
            this.labelMType.Text = "Type de Materiel";
            // 
            // textBoxMClient
            // 
            this.textBoxMClient.Location = new System.Drawing.Point(718, 48);
            this.textBoxMClient.Name = "textBoxMClient";
            this.textBoxMClient.Size = new System.Drawing.Size(286, 31);
            this.textBoxMClient.TabIndex = 24;
            // 
            // labelMClient
            // 
            this.labelMClient.AutoSize = true;
            this.labelMClient.Location = new System.Drawing.Point(632, 51);
            this.labelMClient.Name = "labelMClient";
            this.labelMClient.Size = new System.Drawing.Size(67, 25);
            this.labelMClient.TabIndex = 23;
            this.labelMClient.Text = "Client";
            // 
            // textBoxMmtbf
            // 
            this.textBoxMmtbf.Location = new System.Drawing.Point(718, 300);
            this.textBoxMmtbf.Name = "textBoxMmtbf";
            this.textBoxMmtbf.Size = new System.Drawing.Size(286, 31);
            this.textBoxMmtbf.TabIndex = 26;
            // 
            // labelMmtbf
            // 
            this.labelMmtbf.AutoSize = true;
            this.labelMmtbf.Location = new System.Drawing.Point(629, 303);
            this.labelMmtbf.Name = "labelMmtbf";
            this.labelMmtbf.Size = new System.Drawing.Size(70, 25);
            this.labelMmtbf.TabIndex = 25;
            this.labelMmtbf.Text = "MTBF";
            // 
            // textBoxMDate
            // 
            this.textBoxMDate.Location = new System.Drawing.Point(718, 165);
            this.textBoxMDate.Name = "textBoxMDate";
            this.textBoxMDate.Size = new System.Drawing.Size(286, 31);
            this.textBoxMDate.TabIndex = 28;
            // 
            // labelMDate
            // 
            this.labelMDate.AutoSize = true;
            this.labelMDate.Location = new System.Drawing.Point(522, 168);
            this.labelMDate.Name = "labelMDate";
            this.labelMDate.Size = new System.Drawing.Size(177, 25);
            this.labelMDate.TabIndex = 27;
            this.labelMDate.Text = "Date d\'Instalation";
            // 
            // groupBoxMInfos
            // 
            this.groupBoxMInfos.Controls.Add(this.textBoxMDate);
            this.groupBoxMInfos.Controls.Add(this.labelMDate);
            this.groupBoxMInfos.Controls.Add(this.textBoxMmtbf);
            this.groupBoxMInfos.Controls.Add(this.labelMmtbf);
            this.groupBoxMInfos.Controls.Add(this.textBoxMClient);
            this.groupBoxMInfos.Controls.Add(this.labelMClient);
            this.groupBoxMInfos.Controls.Add(this.textBoxMType);
            this.groupBoxMInfos.Controls.Add(this.labelMType);
            this.groupBoxMInfos.Controls.Add(this.textBoxMDescription);
            this.groupBoxMInfos.Controls.Add(this.labelMDescription);
            this.groupBoxMInfos.Controls.Add(this.textBoxMNserie);
            this.groupBoxMInfos.Controls.Add(this.labelMNserie);
            this.groupBoxMInfos.Controls.Add(this.textBoxMNom);
            this.groupBoxMInfos.Controls.Add(this.labelMNom);
            this.groupBoxMInfos.Location = new System.Drawing.Point(414, 242);
            this.groupBoxMInfos.Name = "groupBoxMInfos";
            this.groupBoxMInfos.Size = new System.Drawing.Size(1034, 503);
            this.groupBoxMInfos.TabIndex = 29;
            this.groupBoxMInfos.TabStop = false;
            this.groupBoxMInfos.Text = "Informations";
            // 
            // FormulaireListeMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1545, 938);
            this.Controls.Add(this.groupBoxMateriel);
            this.Name = "FormulaireListeMateriel";
            this.Text = "Liste Materiel";
            this.groupBoxMateriel.ResumeLayout(false);
            this.groupBoxMateriel.PerformLayout();
            this.groupBoxMInfos.ResumeLayout(false);
            this.groupBoxMInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMateriel;
        private System.Windows.Forms.Button buttonListeMRetour;
        private System.Windows.Forms.ListBox listBoxMateriel;
        private System.Windows.Forms.TextBox textBoxMRecherche;
        private System.Windows.Forms.Button buttonMFiltre;
        private System.Windows.Forms.Button buttonNewMateriel;
        private System.Windows.Forms.ComboBox comboBoxMFiltre;
        private System.Windows.Forms.GroupBox groupBoxMInfos;
        private System.Windows.Forms.TextBox textBoxMDate;
        private System.Windows.Forms.Label labelMDate;
        private System.Windows.Forms.TextBox textBoxMmtbf;
        private System.Windows.Forms.Label labelMmtbf;
        private System.Windows.Forms.TextBox textBoxMClient;
        private System.Windows.Forms.Label labelMClient;
        private System.Windows.Forms.TextBox textBoxMType;
        private System.Windows.Forms.Label labelMType;
        private System.Windows.Forms.TextBox textBoxMDescription;
        private System.Windows.Forms.Label labelMDescription;
        private System.Windows.Forms.TextBox textBoxMNserie;
        private System.Windows.Forms.Label labelMNserie;
        private System.Windows.Forms.TextBox textBoxMNom;
        private System.Windows.Forms.Label labelMNom;
    }
}