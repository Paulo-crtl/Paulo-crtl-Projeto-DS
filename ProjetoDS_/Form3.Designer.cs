namespace ProjetoDS_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.login = new System.Windows.Forms.Button();
            this.cadastro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.login.Location = new System.Drawing.Point(144, 311);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 43);
            this.login.TabIndex = 18;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cadastro.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cadastro.Location = new System.Drawing.Point(476, 311);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(203, 43);
            this.cadastro.TabIndex = 19;
            this.cadastro.Text = "CADASTRAR";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("NSimSun", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(321, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 34);
            this.label7.TabIndex = 20;
            this.label7.Text = "BEM-VINDO";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.login);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Label label7;
    }
}