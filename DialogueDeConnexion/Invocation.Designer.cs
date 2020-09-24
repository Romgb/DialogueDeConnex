namespace DialogueDeConnexion
{
    partial class Invocation
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
            this.zoneSaisie = new System.Windows.Forms.TextBox();
            this.btnAppel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zoneSaisie
            // 
            this.zoneSaisie.Location = new System.Drawing.Point(398, 216);
            this.zoneSaisie.Name = "zoneSaisie";
            this.zoneSaisie.Size = new System.Drawing.Size(249, 20);
            this.zoneSaisie.TabIndex = 3;
            this.zoneSaisie.TextChanged += new System.EventHandler(this.zoneSaisie_TextChanged);
            // 
            // btnAppel
            // 
            this.btnAppel.Location = new System.Drawing.Point(154, 205);
            this.btnAppel.Name = "btnAppel";
            this.btnAppel.Size = new System.Drawing.Size(203, 40);
            this.btnAppel.TabIndex = 2;
            this.btnAppel.Text = "Appel Dialogue Modal";
            this.btnAppel.UseVisualStyleBackColor = true;
            this.btnAppel.Click += new System.EventHandler(this.btnAppel_Click);
            // 
            // Invocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zoneSaisie);
            this.Controls.Add(this.btnAppel);
            this.Name = "Invocation";
            this.Text = "Invocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zoneSaisie;
        private System.Windows.Forms.Button btnAppel;
    }
}

