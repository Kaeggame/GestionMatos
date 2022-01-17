
namespace GestionMatos
{
    partial class FormulaireNewIntervention
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
            this.labelIDate = new System.Windows.Forms.Label();
            this.labelINserieMateriel = new System.Windows.Forms.Label();
            this.labelICommentaire = new System.Windows.Forms.Label();
            this.textBoxIDate = new System.Windows.Forms.TextBox();
            this.textBoxIComentaire = new System.Windows.Forms.TextBox();
            this.textBoxINserieMateriel = new System.Windows.Forms.TextBox();
            this.groupBoxNewIntervention = new System.Windows.Forms.GroupBox();
            this.buttonICreer = new System.Windows.Forms.Button();
            this.buttonIAnnuler = new System.Windows.Forms.Button();
            this.textBoxINom = new System.Windows.Forms.TextBox();
            this.labelINom = new System.Windows.Forms.Label();
            this.groupBoxNewIntervention.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIDate
            // 
            this.labelIDate.AutoSize = true;
            this.labelIDate.Location = new System.Drawing.Point(169, 86);
            this.labelIDate.Name = "labelIDate";
            this.labelIDate.Size = new System.Drawing.Size(57, 25);
            this.labelIDate.TabIndex = 0;
            this.labelIDate.Text = "Date";
            // 
            // labelINserieMateriel
            // 
            this.labelINserieMateriel.AutoSize = true;
            this.labelINserieMateriel.Location = new System.Drawing.Point(169, 260);
            this.labelINserieMateriel.Name = "labelINserieMateriel";
            this.labelINserieMateriel.Size = new System.Drawing.Size(174, 25);
            this.labelINserieMateriel.TabIndex = 2;
            this.labelINserieMateriel.Text = "N° Série Materiel";
            // 
            // labelICommentaire
            // 
            this.labelICommentaire.AutoSize = true;
            this.labelICommentaire.Location = new System.Drawing.Point(819, 257);
            this.labelICommentaire.Name = "labelICommentaire";
            this.labelICommentaire.Size = new System.Drawing.Size(139, 25);
            this.labelICommentaire.TabIndex = 3;
            this.labelICommentaire.Text = "Commentaire";
            // 
            // textBoxIDate
            // 
            this.textBoxIDate.Location = new System.Drawing.Point(361, 86);
            this.textBoxIDate.Name = "textBoxIDate";
            this.textBoxIDate.Size = new System.Drawing.Size(260, 31);
            this.textBoxIDate.TabIndex = 6;
            // 
            // textBoxIComentaire
            // 
            this.textBoxIComentaire.Location = new System.Drawing.Point(999, 257);
            this.textBoxIComentaire.Name = "textBoxIComentaire";
            this.textBoxIComentaire.Size = new System.Drawing.Size(260, 31);
            this.textBoxIComentaire.TabIndex = 7;
            // 
            // textBoxINserieMateriel
            // 
            this.textBoxINserieMateriel.Location = new System.Drawing.Point(361, 260);
            this.textBoxINserieMateriel.Name = "textBoxINserieMateriel";
            this.textBoxINserieMateriel.Size = new System.Drawing.Size(260, 31);
            this.textBoxINserieMateriel.TabIndex = 10;
            // 
            // groupBoxNewIntervention
            // 
            this.groupBoxNewIntervention.Controls.Add(this.textBoxINom);
            this.groupBoxNewIntervention.Controls.Add(this.labelINom);
            this.groupBoxNewIntervention.Controls.Add(this.buttonICreer);
            this.groupBoxNewIntervention.Controls.Add(this.buttonIAnnuler);
            this.groupBoxNewIntervention.Controls.Add(this.textBoxINserieMateriel);
            this.groupBoxNewIntervention.Controls.Add(this.textBoxIComentaire);
            this.groupBoxNewIntervention.Controls.Add(this.textBoxIDate);
            this.groupBoxNewIntervention.Controls.Add(this.labelICommentaire);
            this.groupBoxNewIntervention.Controls.Add(this.labelINserieMateriel);
            this.groupBoxNewIntervention.Controls.Add(this.labelIDate);
            this.groupBoxNewIntervention.Location = new System.Drawing.Point(45, 44);
            this.groupBoxNewIntervention.Name = "groupBoxNewIntervention";
            this.groupBoxNewIntervention.Size = new System.Drawing.Size(1461, 679);
            this.groupBoxNewIntervention.TabIndex = 12;
            this.groupBoxNewIntervention.TabStop = false;
            this.groupBoxNewIntervention.Text = "Intervention";
            // 
            // buttonICreer
            // 
            this.buttonICreer.Location = new System.Drawing.Point(828, 524);
            this.buttonICreer.Name = "buttonICreer";
            this.buttonICreer.Size = new System.Drawing.Size(259, 62);
            this.buttonICreer.TabIndex = 13;
            this.buttonICreer.Text = "Créer";
            this.buttonICreer.UseVisualStyleBackColor = true;
            // 
            // buttonIAnnuler
            // 
            this.buttonIAnnuler.Location = new System.Drawing.Point(361, 524);
            this.buttonIAnnuler.Name = "buttonIAnnuler";
            this.buttonIAnnuler.Size = new System.Drawing.Size(259, 62);
            this.buttonIAnnuler.TabIndex = 12;
            this.buttonIAnnuler.Text = "Annuler";
            this.buttonIAnnuler.UseVisualStyleBackColor = true;
            this.buttonIAnnuler.Click += new System.EventHandler(this.buttonIAnnuler_Click);
            // 
            // textBoxINom
            // 
            this.textBoxINom.Location = new System.Drawing.Point(999, 86);
            this.textBoxINom.Name = "textBoxINom";
            this.textBoxINom.Size = new System.Drawing.Size(260, 31);
            this.textBoxINom.TabIndex = 15;
            // 
            // labelINom
            // 
            this.labelINom.AutoSize = true;
            this.labelINom.Location = new System.Drawing.Point(819, 86);
            this.labelINom.Name = "labelINom";
            this.labelINom.Size = new System.Drawing.Size(174, 25);
            this.labelINom.TabIndex = 14;
            this.labelINom.Text = "Nom Intervention";
            // 
            // FormulaireNewIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1548, 768);
            this.Controls.Add(this.groupBoxNewIntervention);
            this.Name = "FormulaireNewIntervention";
            this.Text = "Nouvelle Intervention";
            this.groupBoxNewIntervention.ResumeLayout(false);
            this.groupBoxNewIntervention.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIDate;
        private System.Windows.Forms.Label labelINserieMateriel;
        private System.Windows.Forms.Label labelICommentaire;
        private System.Windows.Forms.TextBox textBoxIDate;
        private System.Windows.Forms.TextBox textBoxIComentaire;
        private System.Windows.Forms.TextBox textBoxINserieMateriel;
        private System.Windows.Forms.GroupBox groupBoxNewIntervention;
        private System.Windows.Forms.Button buttonICreer;
        private System.Windows.Forms.Button buttonIAnnuler;
        private System.Windows.Forms.TextBox textBoxINom;
        private System.Windows.Forms.Label labelINom;
    }
}