namespace TestForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.lb_informations = new System.Windows.Forms.Label();
            this.erreur_prenom = new System.Windows.Forms.Label();
            this.erreur_nom = new System.Windows.Forms.Label();
            this.erreur_prenom_deux = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom";
            this.label1.UseMnemonic = false;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_prenom.Location = new System.Drawing.Point(13, 29);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(331, 20);
            this.tb_prenom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de famille";
            // 
            // tb_nom
            // 
            this.tb_nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nom.Location = new System.Drawing.Point(13, 86);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(331, 20);
            this.tb_nom.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_envoyer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_supprimer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_envoyer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_envoyer.Location = new System.Drawing.Point(3, 3);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(159, 24);
            this.btn_envoyer.TabIndex = 0;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = false;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_supprimer.Location = new System.Drawing.Point(168, 3);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(160, 24);
            this.btn_supprimer.TabIndex = 1;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // lb_informations
            // 
            this.lb_informations.AutoSize = true;
            this.lb_informations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_informations.Location = new System.Drawing.Point(19, 127);
            this.lb_informations.Name = "lb_informations";
            this.lb_informations.Size = new System.Drawing.Size(0, 13);
            this.lb_informations.TabIndex = 5;
            // 
            // erreur_prenom
            // 
            this.erreur_prenom.AutoSize = true;
            this.erreur_prenom.Location = new System.Drawing.Point(19, 32);
            this.erreur_prenom.Name = "erreur_prenom";
            this.erreur_prenom.Size = new System.Drawing.Size(0, 13);
            this.erreur_prenom.TabIndex = 6;
            // 
            // erreur_nom
            // 
            this.erreur_nom.AutoSize = true;
            this.erreur_nom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.erreur_nom.Location = new System.Drawing.Point(15, 109);
            this.erreur_nom.Name = "erreur_nom";
            this.erreur_nom.Size = new System.Drawing.Size(0, 13);
            this.erreur_nom.TabIndex = 7;
            // 
            // erreur_prenom_deux
            // 
            this.erreur_prenom_deux.AutoSize = true;
            this.erreur_prenom_deux.Location = new System.Drawing.Point(15, 52);
            this.erreur_prenom_deux.Name = "erreur_prenom_deux";
            this.erreur_prenom_deux.Size = new System.Drawing.Size(0, 13);
            this.erreur_prenom_deux.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.erreur_prenom_deux);
            this.Controls.Add(this.erreur_nom);
            this.Controls.Add(this.erreur_prenom);
            this.Controls.Add(this.lb_informations);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimumSize = new System.Drawing.Size(372, 489);
            this.Name = "Form1";
            this.Text = "Formulaire d\'envoyer sans BDD (ni requête POST)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_envoyer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label lb_informations;
        private System.Windows.Forms.Label erreur_prenom;
        private System.Windows.Forms.Label erreur_nom;
        private System.Windows.Forms.Label erreur_prenom_deux;
    }
}

