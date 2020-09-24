namespace DialogueDeConnexion
{
    partial class form1
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
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneSaisieMDP = new System.Windows.Forms.TextBox();
            this.zoneSaisieID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Location = new System.Drawing.Point(43, 236);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(126, 24);
            this.btnSeConnecter.TabIndex = 1;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(227, 236);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(133, 24);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneSaisieMDP);
            this.groupBox1.Controls.Add(this.zoneSaisieID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(43, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres d\'authentification";
            // 
            // zoneSaisieMDP
            // 
            this.zoneSaisieMDP.Location = new System.Drawing.Point(137, 98);
            this.zoneSaisieMDP.Name = "zoneSaisieMDP";
            this.zoneSaisieMDP.Size = new System.Drawing.Size(153, 20);
            this.zoneSaisieMDP.TabIndex = 3;
            this.zoneSaisieMDP.Validating += new System.ComponentModel.CancelEventHandler(this.zoneSaisieMDP_Validating);
            // 
            // zoneSaisieID
            // 
            this.zoneSaisieID.Location = new System.Drawing.Point(137, 40);
            this.zoneSaisieID.Name = "zoneSaisieID";
            this.zoneSaisieID.Size = new System.Drawing.Size(153, 20);
            this.zoneSaisieID.TabIndex = 2;
            this.zoneSaisieID.TextChanged += new System.EventHandler(this.zoneSaisieID_TextChanged);
            this.zoneSaisieID.Validating += new System.ComponentModel.CancelEventHandler(this.zoneSaisieID_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID utilisateur";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSeConnecter);
            this.Name = "form1";
            this.Text = "Identifiez-vous";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox zoneSaisieMDP;
        private System.Windows.Forms.TextBox zoneSaisieID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}