﻿namespace AirSystem.Views
{
    partial class Novo_Usuario___AirSystem
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nuConfSenha = new System.Windows.Forms.TextBox();
            this.nuUsuario = new System.Windows.Forms.TextBox();
            this.nuSenha = new System.Windows.Forms.TextBox();
            this.nuRua = new System.Windows.Forms.TextBox();
            this.nuNumero = new System.Windows.Forms.TextBox();
            this.nuNome = new System.Windows.Forms.TextBox();
            this.nuSobrenome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nubtnAlterar = new System.Windows.Forms.Button();
            this.nubtnDeletar = new System.Windows.Forms.Button();
            this.nubtnCadastro = new System.Windows.Forms.Button();
            this.nuAdm = new System.Windows.Forms.CheckBox();
            this.nuData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nome.Location = new System.Drawing.Point(33, 45);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(54, 19);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirmar Senha";
            // 
            // nuConfSenha
            // 
            this.nuConfSenha.Location = new System.Drawing.Point(192, 295);
            this.nuConfSenha.Name = "nuConfSenha";
            this.nuConfSenha.Size = new System.Drawing.Size(134, 20);
            this.nuConfSenha.TabIndex = 7;
            this.nuConfSenha.TextChanged += new System.EventHandler(this.texUsuario_TextChanged);
            // 
            // nuUsuario
            // 
            this.nuUsuario.Location = new System.Drawing.Point(192, 189);
            this.nuUsuario.Name = "nuUsuario";
            this.nuUsuario.Size = new System.Drawing.Size(134, 20);
            this.nuUsuario.TabIndex = 8;
            this.nuUsuario.TextChanged += new System.EventHandler(this.nuUsuario_TextChanged);
            // 
            // nuSenha
            // 
            this.nuSenha.Location = new System.Drawing.Point(192, 242);
            this.nuSenha.Name = "nuSenha";
            this.nuSenha.Size = new System.Drawing.Size(134, 20);
            this.nuSenha.TabIndex = 9;
            // 
            // nuRua
            // 
            this.nuRua.Location = new System.Drawing.Point(192, 89);
            this.nuRua.Name = "nuRua";
            this.nuRua.Size = new System.Drawing.Size(173, 20);
            this.nuRua.TabIndex = 10;
            this.nuRua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nuNumero
            // 
            this.nuNumero.Location = new System.Drawing.Point(397, 90);
            this.nuNumero.Name = "nuNumero";
            this.nuNumero.Size = new System.Drawing.Size(59, 20);
            this.nuNumero.TabIndex = 11;
            // 
            // nuNome
            // 
            this.nuNome.Location = new System.Drawing.Point(192, 46);
            this.nuNome.Name = "nuNome";
            this.nuNome.Size = new System.Drawing.Size(119, 20);
            this.nuNome.TabIndex = 12;
            this.nuNome.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // nuSobrenome
            // 
            this.nuSobrenome.Location = new System.Drawing.Point(332, 46);
            this.nuSobrenome.Name = "nuSobrenome";
            this.nuSobrenome.Size = new System.Drawing.Size(124, 20);
            this.nuSobrenome.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(541, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 105);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // nubtnAlterar
            // 
            this.nubtnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubtnAlterar.Location = new System.Drawing.Point(541, 157);
            this.nubtnAlterar.Name = "nubtnAlterar";
            this.nubtnAlterar.Size = new System.Drawing.Size(59, 23);
            this.nubtnAlterar.TabIndex = 15;
            this.nubtnAlterar.Text = "Alterar";
            this.nubtnAlterar.UseVisualStyleBackColor = true;
            // 
            // nubtnDeletar
            // 
            this.nubtnDeletar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubtnDeletar.Location = new System.Drawing.Point(602, 157);
            this.nubtnDeletar.Name = "nubtnDeletar";
            this.nubtnDeletar.Size = new System.Drawing.Size(67, 23);
            this.nubtnDeletar.TabIndex = 16;
            this.nubtnDeletar.Text = "Deletar";
            this.nubtnDeletar.UseVisualStyleBackColor = true;
            this.nubtnDeletar.Click += new System.EventHandler(this.button2_Click);
            // 
            // nubtnCadastro
            // 
            this.nubtnCadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubtnCadastro.Location = new System.Drawing.Point(192, 348);
            this.nubtnCadastro.Name = "nubtnCadastro";
            this.nubtnCadastro.Size = new System.Drawing.Size(123, 30);
            this.nubtnCadastro.TabIndex = 17;
            this.nubtnCadastro.Text = "Cadastrar";
            this.nubtnCadastro.UseVisualStyleBackColor = true;
            this.nubtnCadastro.Click += new System.EventHandler(this.nubtnCadastro_Click);
            // 
            // nuAdm
            // 
            this.nuAdm.AutoSize = true;
            this.nuAdm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuAdm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuAdm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuAdm.Location = new System.Drawing.Point(548, 205);
            this.nuAdm.Name = "nuAdm";
            this.nuAdm.Size = new System.Drawing.Size(84, 20);
            this.nuAdm.TabIndex = 18;
            this.nuAdm.Text = "É  Admin";
            this.nuAdm.UseVisualStyleBackColor = false;
            this.nuAdm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nuData
            // 
            this.nuData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nuData.Location = new System.Drawing.Point(192, 143);
            this.nuData.Name = "nuData";
            this.nuData.Size = new System.Drawing.Size(200, 20);
            this.nuData.TabIndex = 19;
            this.nuData.TabStop = false;
            this.nuData.Value = new System.DateTime(2020, 6, 16, 17, 33, 4, 0);
            this.nuData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Novo_Usuario___AirSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.nuData);
            this.Controls.Add(this.nuAdm);
            this.Controls.Add(this.nubtnCadastro);
            this.Controls.Add(this.nubtnDeletar);
            this.Controls.Add(this.nubtnAlterar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nuSobrenome);
            this.Controls.Add(this.nuNome);
            this.Controls.Add(this.nuNumero);
            this.Controls.Add(this.nuRua);
            this.Controls.Add(this.nuSenha);
            this.Controls.Add(this.nuUsuario);
            this.Controls.Add(this.nuConfSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Novo_Usuario___AirSystem";
            this.Text = "NovoUsuario_AirSystem";
            this.Load += new System.EventHandler(this.Novo_Usuario___AirSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nuConfSenha;
        private System.Windows.Forms.TextBox nuUsuario;
        private System.Windows.Forms.TextBox nuSenha;
        private System.Windows.Forms.TextBox nuRua;
        private System.Windows.Forms.TextBox nuNumero;
        private System.Windows.Forms.TextBox nuNome;
        private System.Windows.Forms.TextBox nuSobrenome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nubtnAlterar;
        private System.Windows.Forms.Button nubtnDeletar;
        private System.Windows.Forms.Button nubtnCadastro;
        private System.Windows.Forms.CheckBox nuAdm;
        private System.Windows.Forms.DateTimePicker nuData;
    }
}