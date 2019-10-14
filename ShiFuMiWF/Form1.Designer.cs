namespace ShiFuMiWF
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
            this.components = new System.ComponentModel.Container();
            this.btnPierre = new System.Windows.Forms.Button();
            this.btnFeuille = new System.Windows.Forms.Button();
            this.btnCiseaux = new System.Windows.Forms.Button();
            this.labelIA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScoreJoueur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelVicDef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScoreIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPierre
            // 
            this.btnPierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPierre.Image = global::ShiFuMiWF.Properties.Resources.pierre;
            this.btnPierre.Location = new System.Drawing.Point(12, 266);
            this.btnPierre.Name = "btnPierre";
            this.btnPierre.Size = new System.Drawing.Size(200, 200);
            this.btnPierre.TabIndex = 0;
            this.btnPierre.UseVisualStyleBackColor = true;
            this.btnPierre.Click += new System.EventHandler(this.btnPierre_Click);
            // 
            // btnFeuille
            // 
            this.btnFeuille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeuille.Image = global::ShiFuMiWF.Properties.Resources.feuille;
            this.btnFeuille.Location = new System.Drawing.Point(238, 266);
            this.btnFeuille.Name = "btnFeuille";
            this.btnFeuille.Size = new System.Drawing.Size(200, 200);
            this.btnFeuille.TabIndex = 0;
            this.btnFeuille.UseVisualStyleBackColor = true;
            this.btnFeuille.Click += new System.EventHandler(this.btnFeuille_Click);
            // 
            // btnCiseaux
            // 
            this.btnCiseaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiseaux.Image = global::ShiFuMiWF.Properties.Resources.ciseaux;
            this.btnCiseaux.Location = new System.Drawing.Point(466, 266);
            this.btnCiseaux.Name = "btnCiseaux";
            this.btnCiseaux.Size = new System.Drawing.Size(200, 200);
            this.btnCiseaux.TabIndex = 0;
            this.btnCiseaux.UseVisualStyleBackColor = true;
            this.btnCiseaux.Click += new System.EventHandler(this.btnCiseaux_Click);
            // 
            // labelIA
            // 
            this.labelIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelIA.Location = new System.Drawing.Point(238, 9);
            this.labelIA.Name = "labelIA";
            this.labelIA.Size = new System.Drawing.Size(200, 200);
            this.labelIA.TabIndex = 2;
            this.labelIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score joueur";
            // 
            // labelScoreJoueur
            // 
            this.labelScoreJoueur.AutoSize = true;
            this.labelScoreJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreJoueur.Location = new System.Drawing.Point(102, 117);
            this.labelScoreJoueur.Name = "labelScoreJoueur";
            this.labelScoreJoueur.Size = new System.Drawing.Size(25, 25);
            this.labelScoreJoueur.TabIndex = 4;
            this.labelScoreJoueur.Text = "0";
            this.labelScoreJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // labelVicDef
            // 
            this.labelVicDef.AutoSize = true;
            this.labelVicDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVicDef.Location = new System.Drawing.Point(300, 222);
            this.labelVicDef.Name = "labelVicDef";
            this.labelVicDef.Size = new System.Drawing.Size(0, 25);
            this.labelVicDef.TabIndex = 5;
            this.labelVicDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score IA";
            // 
            // labelScoreIA
            // 
            this.labelScoreIA.AutoSize = true;
            this.labelScoreIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreIA.Location = new System.Drawing.Point(554, 121);
            this.labelScoreIA.Name = "labelScoreIA";
            this.labelScoreIA.Size = new System.Drawing.Size(25, 25);
            this.labelScoreIA.TabIndex = 4;
            this.labelScoreIA.Text = "0";
            this.labelScoreIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 492);
            this.Controls.Add(this.labelVicDef);
            this.Controls.Add(this.labelScoreIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScoreJoueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIA);
            this.Controls.Add(this.btnCiseaux);
            this.Controls.Add(this.btnFeuille);
            this.Controls.Add(this.btnPierre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiFuMi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPierre;
        private System.Windows.Forms.Button btnFeuille;
        private System.Windows.Forms.Button btnCiseaux;
        private System.Windows.Forms.Label labelIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScoreJoueur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelVicDef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScoreIA;
    }
}

