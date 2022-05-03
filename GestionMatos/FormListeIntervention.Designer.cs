
namespace GestionMatos
{
    partial class FormulaireListeIntervention
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
            this.groupBoxIntervention = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelIChercher = new System.Windows.Forms.Label();
            this.buttonModifierIntervention = new System.Windows.Forms.Button();
            this.groupBoxIInfos = new System.Windows.Forms.GroupBox();
            this.textBoxIDate = new System.Windows.Forms.TextBox();
            this.labelIDate = new System.Windows.Forms.Label();
            this.textBoxISite = new System.Windows.Forms.TextBox();
            this.labelISite = new System.Windows.Forms.Label();
            this.textBoxIClient = new System.Windows.Forms.TextBox();
            this.labelIClient = new System.Windows.Forms.Label();
            this.textBoxIType = new System.Windows.Forms.TextBox();
            this.labelIType = new System.Windows.Forms.Label();
            this.textBoxICommentaire = new System.Windows.Forms.TextBox();
            this.labelICommentaire = new System.Windows.Forms.Label();
            this.textBoxIMateriel = new System.Windows.Forms.TextBox();
            this.labelIMateriel = new System.Windows.Forms.Label();
            this.textBoxINom = new System.Windows.Forms.TextBox();
            this.labelINom = new System.Windows.Forms.Label();
            this.textBoxIRecherche = new System.Windows.Forms.TextBox();
            this.buttonListeIClient = new System.Windows.Forms.Button();
            this.buttonListeIMateriel = new System.Windows.Forms.Button();
            this.listBoxIntervention = new System.Windows.Forms.ListBox();
            this.buttonNewIntervention = new System.Windows.Forms.Button();
            this.groupBoxIntervention.SuspendLayout();
            this.groupBoxIInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIntervention
            // 
            this.groupBoxIntervention.Controls.Add(this.button1);
            this.groupBoxIntervention.Controls.Add(this.labelIChercher);
            this.groupBoxIntervention.Controls.Add(this.buttonModifierIntervention);
            this.groupBoxIntervention.Controls.Add(this.groupBoxIInfos);
            this.groupBoxIntervention.Controls.Add(this.textBoxIRecherche);
            this.groupBoxIntervention.Controls.Add(this.buttonListeIClient);
            this.groupBoxIntervention.Controls.Add(this.buttonListeIMateriel);
            this.groupBoxIntervention.Controls.Add(this.listBoxIntervention);
            this.groupBoxIntervention.Controls.Add(this.buttonNewIntervention);
            this.groupBoxIntervention.Location = new System.Drawing.Point(18, 18);
            this.groupBoxIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIntervention.Name = "groupBoxIntervention";
            this.groupBoxIntervention.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIntervention.Size = new System.Drawing.Size(736, 454);
            this.groupBoxIntervention.TabIndex = 0;
            this.groupBoxIntervention.TabStop = false;
            this.groupBoxIntervention.Text = "Interventions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIChercher
            // 
            this.labelIChercher.AutoSize = true;
            this.labelIChercher.Location = new System.Drawing.Point(12, 31);
            this.labelIChercher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIChercher.Name = "labelIChercher";
            this.labelIChercher.Size = new System.Drawing.Size(50, 13);
            this.labelIChercher.TabIndex = 1;
            this.labelIChercher.Text = "Chercher";
            // 
            // buttonModifierIntervention
            // 
            this.buttonModifierIntervention.Location = new System.Drawing.Point(473, 398);
            this.buttonModifierIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierIntervention.Name = "buttonModifierIntervention";
            this.buttonModifierIntervention.Size = new System.Drawing.Size(121, 45);
            this.buttonModifierIntervention.TabIndex = 29;
            this.buttonModifierIntervention.Text = "Modifier";
            this.buttonModifierIntervention.UseVisualStyleBackColor = true;
            this.buttonModifierIntervention.Click += new System.EventHandler(this.buttonModifierIntervention_Click);
            // 
            // groupBoxIInfos
            // 
            this.groupBoxIInfos.Controls.Add(this.textBoxIDate);
            this.groupBoxIInfos.Controls.Add(this.labelIDate);
            this.groupBoxIInfos.Controls.Add(this.textBoxISite);
            this.groupBoxIInfos.Controls.Add(this.labelISite);
            this.groupBoxIInfos.Controls.Add(this.textBoxIClient);
            this.groupBoxIInfos.Controls.Add(this.labelIClient);
            this.groupBoxIInfos.Controls.Add(this.textBoxIType);
            this.groupBoxIInfos.Controls.Add(this.labelIType);
            this.groupBoxIInfos.Controls.Add(this.textBoxICommentaire);
            this.groupBoxIInfos.Controls.Add(this.labelICommentaire);
            this.groupBoxIInfos.Controls.Add(this.textBoxIMateriel);
            this.groupBoxIInfos.Controls.Add(this.labelIMateriel);
            this.groupBoxIInfos.Controls.Add(this.textBoxINom);
            this.groupBoxIInfos.Controls.Add(this.labelINom);
            this.groupBoxIInfos.Location = new System.Drawing.Point(210, 115);
            this.groupBoxIInfos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIInfos.Name = "groupBoxIInfos";
            this.groupBoxIInfos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIInfos.Size = new System.Drawing.Size(517, 262);
            this.groupBoxIInfos.TabIndex = 30;
            this.groupBoxIInfos.TabStop = false;
            this.groupBoxIInfos.Text = "Informations";
            // 
            // textBoxIDate
            // 
            this.textBoxIDate.Location = new System.Drawing.Point(363, 23);
            this.textBoxIDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDate.Name = "textBoxIDate";
            this.textBoxIDate.ReadOnly = true;
            this.textBoxIDate.Size = new System.Drawing.Size(145, 20);
            this.textBoxIDate.TabIndex = 28;
            // 
            // labelIDate
            // 
            this.labelIDate.AutoSize = true;
            this.labelIDate.Location = new System.Drawing.Point(257, 25);
            this.labelIDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDate.Name = "labelIDate";
            this.labelIDate.Size = new System.Drawing.Size(97, 13);
            this.labelIDate.TabIndex = 27;
            this.labelIDate.Text = "Date d\'Intervention";
            // 
            // textBoxISite
            // 
            this.textBoxISite.Location = new System.Drawing.Point(363, 154);
            this.textBoxISite.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxISite.Name = "textBoxISite";
            this.textBoxISite.ReadOnly = true;
            this.textBoxISite.Size = new System.Drawing.Size(145, 20);
            this.textBoxISite.TabIndex = 26;
            // 
            // labelISite
            // 
            this.labelISite.AutoSize = true;
            this.labelISite.Location = new System.Drawing.Point(328, 156);
            this.labelISite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelISite.Name = "labelISite";
            this.labelISite.Size = new System.Drawing.Size(25, 13);
            this.labelISite.TabIndex = 25;
            this.labelISite.Text = "Site";
            // 
            // textBoxIClient
            // 
            this.textBoxIClient.Location = new System.Drawing.Point(363, 89);
            this.textBoxIClient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIClient.Name = "textBoxIClient";
            this.textBoxIClient.ReadOnly = true;
            this.textBoxIClient.Size = new System.Drawing.Size(145, 20);
            this.textBoxIClient.TabIndex = 24;
            // 
            // labelIClient
            // 
            this.labelIClient.AutoSize = true;
            this.labelIClient.Location = new System.Drawing.Point(319, 90);
            this.labelIClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIClient.Name = "labelIClient";
            this.labelIClient.Size = new System.Drawing.Size(33, 13);
            this.labelIClient.TabIndex = 23;
            this.labelIClient.Text = "Client";
            // 
            // textBoxIType
            // 
            this.textBoxIType.Location = new System.Drawing.Point(99, 154);
            this.textBoxIType.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIType.Name = "textBoxIType";
            this.textBoxIType.ReadOnly = true;
            this.textBoxIType.Size = new System.Drawing.Size(145, 20);
            this.textBoxIType.TabIndex = 22;
            // 
            // labelIType
            // 
            this.labelIType.AutoSize = true;
            this.labelIType.Location = new System.Drawing.Point(3, 154);
            this.labelIType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIType.Name = "labelIType";
            this.labelIType.Size = new System.Drawing.Size(86, 13);
            this.labelIType.TabIndex = 21;
            this.labelIType.Text = "Type de Materiel";
            // 
            // textBoxICommentaire
            // 
            this.textBoxICommentaire.Location = new System.Drawing.Point(99, 219);
            this.textBoxICommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxICommentaire.Name = "textBoxICommentaire";
            this.textBoxICommentaire.ReadOnly = true;
            this.textBoxICommentaire.Size = new System.Drawing.Size(409, 20);
            this.textBoxICommentaire.TabIndex = 20;
            // 
            // labelICommentaire
            // 
            this.labelICommentaire.AutoSize = true;
            this.labelICommentaire.Location = new System.Drawing.Point(20, 219);
            this.labelICommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelICommentaire.Name = "labelICommentaire";
            this.labelICommentaire.Size = new System.Drawing.Size(68, 13);
            this.labelICommentaire.TabIndex = 19;
            this.labelICommentaire.Text = "Commentaire";
            // 
            // textBoxIMateriel
            // 
            this.textBoxIMateriel.Location = new System.Drawing.Point(99, 89);
            this.textBoxIMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIMateriel.Name = "textBoxIMateriel";
            this.textBoxIMateriel.ReadOnly = true;
            this.textBoxIMateriel.Size = new System.Drawing.Size(145, 20);
            this.textBoxIMateriel.TabIndex = 18;
            // 
            // labelIMateriel
            // 
            this.labelIMateriel.AutoSize = true;
            this.labelIMateriel.Location = new System.Drawing.Point(45, 90);
            this.labelIMateriel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIMateriel.Name = "labelIMateriel";
            this.labelIMateriel.Size = new System.Drawing.Size(44, 13);
            this.labelIMateriel.TabIndex = 17;
            this.labelIMateriel.Text = "Materiel";
            // 
            // textBoxINom
            // 
            this.textBoxINom.Location = new System.Drawing.Point(99, 23);
            this.textBoxINom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxINom.Name = "textBoxINom";
            this.textBoxINom.ReadOnly = true;
            this.textBoxINom.Size = new System.Drawing.Size(145, 20);
            this.textBoxINom.TabIndex = 16;
            // 
            // labelINom
            // 
            this.labelINom.AutoSize = true;
            this.labelINom.Location = new System.Drawing.Point(62, 27);
            this.labelINom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelINom.Name = "labelINom";
            this.labelINom.Size = new System.Drawing.Size(29, 13);
            this.labelINom.TabIndex = 15;
            this.labelINom.Text = "Nom";
            // 
            // textBoxIRecherche
            // 
            this.textBoxIRecherche.Location = new System.Drawing.Point(71, 29);
            this.textBoxIRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIRecherche.Name = "textBoxIRecherche";
            this.textBoxIRecherche.Size = new System.Drawing.Size(658, 20);
            this.textBoxIRecherche.TabIndex = 11;
            this.textBoxIRecherche.Tag = "";
            this.textBoxIRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIRecherche_KeyUp);
            // 
            // buttonListeIClient
            // 
            this.buttonListeIClient.Location = new System.Drawing.Point(210, 398);
            this.buttonListeIClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListeIClient.Name = "buttonListeIClient";
            this.buttonListeIClient.Size = new System.Drawing.Size(121, 45);
            this.buttonListeIClient.TabIndex = 7;
            this.buttonListeIClient.Text = "Liste Client";
            this.buttonListeIClient.UseVisualStyleBackColor = true;
            this.buttonListeIClient.Click += new System.EventHandler(this.buttonListeIClient_Click);
            // 
            // buttonListeIMateriel
            // 
            this.buttonListeIMateriel.Location = new System.Drawing.Point(342, 398);
            this.buttonListeIMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListeIMateriel.Name = "buttonListeIMateriel";
            this.buttonListeIMateriel.Size = new System.Drawing.Size(121, 45);
            this.buttonListeIMateriel.TabIndex = 6;
            this.buttonListeIMateriel.Text = "Liste Materiel";
            this.buttonListeIMateriel.UseVisualStyleBackColor = true;
            this.buttonListeIMateriel.Click += new System.EventHandler(this.buttonListeIMateriel_Click);
            // 
            // listBoxIntervention
            // 
            this.listBoxIntervention.FormattingEnabled = true;
            this.listBoxIntervention.Location = new System.Drawing.Point(15, 64);
            this.listBoxIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIntervention.Name = "listBoxIntervention";
            this.listBoxIntervention.Size = new System.Drawing.Size(171, 381);
            this.listBoxIntervention.TabIndex = 5;
            this.listBoxIntervention.SelectedIndexChanged += new System.EventHandler(this.listBoxIntervention_SelectedIndexChanged);
            // 
            // buttonNewIntervention
            // 
            this.buttonNewIntervention.Location = new System.Drawing.Point(606, 398);
            this.buttonNewIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewIntervention.Name = "buttonNewIntervention";
            this.buttonNewIntervention.Size = new System.Drawing.Size(121, 45);
            this.buttonNewIntervention.TabIndex = 0;
            this.buttonNewIntervention.Text = "Nouvelle Intervention";
            this.buttonNewIntervention.UseVisualStyleBackColor = true;
            this.buttonNewIntervention.Click += new System.EventHandler(this.buttonNewIntervention_Click);
            // 
            // FormulaireListeIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 487);
            this.Controls.Add(this.groupBoxIntervention);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormulaireListeIntervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Intervention";
            this.Load += new System.EventHandler(this.FormulaireListeIntervention_Load);
            this.groupBoxIntervention.ResumeLayout(false);
            this.groupBoxIntervention.PerformLayout();
            this.groupBoxIInfos.ResumeLayout(false);
            this.groupBoxIInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIntervention;
        private System.Windows.Forms.Button buttonListeIClient;
        private System.Windows.Forms.Button buttonListeIMateriel;
        private System.Windows.Forms.ListBox listBoxIntervention;
        private System.Windows.Forms.Button buttonNewIntervention;
        private System.Windows.Forms.TextBox textBoxIRecherche;
        private System.Windows.Forms.GroupBox groupBoxIInfos;
        private System.Windows.Forms.TextBox textBoxIDate;
        private System.Windows.Forms.Label labelIDate;
        private System.Windows.Forms.TextBox textBoxISite;
        private System.Windows.Forms.Label labelISite;
        private System.Windows.Forms.TextBox textBoxIClient;
        private System.Windows.Forms.Label labelIClient;
        private System.Windows.Forms.TextBox textBoxIType;
        private System.Windows.Forms.Label labelIType;
        private System.Windows.Forms.TextBox textBoxICommentaire;
        private System.Windows.Forms.Label labelICommentaire;
        private System.Windows.Forms.TextBox textBoxIMateriel;
        private System.Windows.Forms.Label labelIMateriel;
        private System.Windows.Forms.TextBox textBoxINom;
        private System.Windows.Forms.Label labelINom;
        private System.Windows.Forms.Button buttonModifierIntervention;
        private System.Windows.Forms.Label labelIChercher;
        private System.Windows.Forms.Button button1;
    }
}