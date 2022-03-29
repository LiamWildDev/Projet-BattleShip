namespace BattleShip
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxAdversiare = new System.Windows.Forms.PictureBox();
            this.pictureBoxJoueur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdversiare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoueur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(124, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "vos tirs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(86, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "les tirs adversaires";
            // 
            // pictureBoxAdversiare
            // 
            this.pictureBoxAdversiare.Location = new System.Drawing.Point(63, 25);
            this.pictureBoxAdversiare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAdversiare.Name = "pictureBoxAdversiare";
            this.pictureBoxAdversiare.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAdversiare.TabIndex = 2;
            this.pictureBoxAdversiare.TabStop = false;
            this.pictureBoxAdversiare.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxAdversiare_Paint);
            this.pictureBoxAdversiare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAdversiare_MouseUp);
            // 
            // pictureBoxJoueur
            // 
            this.pictureBoxJoueur.Location = new System.Drawing.Point(63, 255);
            this.pictureBoxJoueur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxJoueur.Name = "pictureBoxJoueur";
            this.pictureBoxJoueur.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxJoueur.TabIndex = 3;
            this.pictureBoxJoueur.TabStop = false;
            this.pictureBoxJoueur.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxJoueur_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 471);
            this.Controls.Add(this.pictureBoxJoueur);
            this.Controls.Add(this.pictureBoxAdversiare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdversiare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxAdversiare;
        private System.Windows.Forms.PictureBox pictureBoxJoueur;
    }
}

