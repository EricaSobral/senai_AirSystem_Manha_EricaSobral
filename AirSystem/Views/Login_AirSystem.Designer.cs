namespace AirSystem.Views
{
    partial class Login_AirSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_AirSystem));
            this.loginbtnSair = new System.Windows.Forms.Button();
            this.loginbtnNU = new System.Windows.Forms.Button();
            this.loginbtnEntrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginList = new System.Windows.Forms.ListBox();
            this.loginUsuario = new System.Windows.Forms.TextBox();
            this.loginSenha = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbtnSair
            // 
            this.loginbtnSair.Location = new System.Drawing.Point(420, 270);
            this.loginbtnSair.Name = "loginbtnSair";
            this.loginbtnSair.Size = new System.Drawing.Size(48, 23);
            this.loginbtnSair.TabIndex = 35;
            this.loginbtnSair.Text = "Sair";
            this.loginbtnSair.UseVisualStyleBackColor = true;
            this.loginbtnSair.Click += new System.EventHandler(this.loginbtnSair_Click);
            // 
            // loginbtnNU
            // 
            this.loginbtnNU.Location = new System.Drawing.Point(483, 270);
            this.loginbtnNU.Name = "loginbtnNU";
            this.loginbtnNU.Size = new System.Drawing.Size(84, 23);
            this.loginbtnNU.TabIndex = 34;
            this.loginbtnNU.Text = "Novo Usuario";
            this.loginbtnNU.UseVisualStyleBackColor = true;
            this.loginbtnNU.Click += new System.EventHandler(this.loginbtnNU_Click);
            // 
            // loginbtnEntrar
            // 
            this.loginbtnEntrar.AutoEllipsis = true;
            this.loginbtnEntrar.Location = new System.Drawing.Point(348, 270);
            this.loginbtnEntrar.Name = "loginbtnEntrar";
            this.loginbtnEntrar.Size = new System.Drawing.Size(57, 23);
            this.loginbtnEntrar.TabIndex = 33;
            this.loginbtnEntrar.Text = "Entrar";
            this.loginbtnEntrar.UseVisualStyleBackColor = true;
            this.loginbtnEntrar.Click += new System.EventHandler(this.loginbtnEntrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(345, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Idioma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(345, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(345, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Usuário";
            // 
            // loginList
            // 
            this.loginList.FormattingEnabled = true;
            this.loginList.Items.AddRange(new object[] {
            "Português PT-BR",
            "Inglês EN-EN"});
            this.loginList.Location = new System.Drawing.Point(348, 243);
            this.loginList.Name = "loginList";
            this.loginList.Size = new System.Drawing.Size(120, 17);
            this.loginList.TabIndex = 29;
            this.loginList.SelectedIndexChanged += new System.EventHandler(this.loginList_SelectedIndexChanged);
            // 
            // loginUsuario
            // 
            this.loginUsuario.Location = new System.Drawing.Point(348, 141);
            this.loginUsuario.Name = "loginUsuario";
            this.loginUsuario.Size = new System.Drawing.Size(191, 20);
            this.loginUsuario.TabIndex = 28;
            this.loginUsuario.TextChanged += new System.EventHandler(this.loginUsuario_TextChanged);
            // 
            // loginSenha
            // 
            this.loginSenha.Location = new System.Drawing.Point(348, 186);
            this.loginSenha.Name = "loginSenha";
            this.loginSenha.Size = new System.Drawing.Size(191, 20);
            this.loginSenha.TabIndex = 27;
            this.loginSenha.TextChanged += new System.EventHandler(this.loginSenha_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(348, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(191, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(253, 268);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Login_AirSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(609, 325);
            this.Controls.Add(this.loginbtnSair);
            this.Controls.Add(this.loginbtnNU);
            this.Controls.Add(this.loginbtnEntrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginList);
            this.Controls.Add(this.loginUsuario);
            this.Controls.Add(this.loginSenha);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_AirSystem";
            this.Text = "Login_AirSystem";
            this.Load += new System.EventHandler(this.Login_AirSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtnSair;
        private System.Windows.Forms.Button loginbtnNU;
        private System.Windows.Forms.Button loginbtnEntrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox loginList;
        private System.Windows.Forms.TextBox loginUsuario;
        private System.Windows.Forms.TextBox loginSenha;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}