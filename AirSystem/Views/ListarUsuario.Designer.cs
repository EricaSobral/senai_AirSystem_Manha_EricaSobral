﻿namespace AirSystem.Views
{
    partial class ListarUsuario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LuNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.luDadosU = new System.Windows.Forms.Label();
            this.lubtnAlterar = new System.Windows.Forms.Button();
            this.lubtnDeletar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.luSenha = new System.Windows.Forms.Label();
            this.luUsuario = new System.Windows.Forms.Label();
            this.luNumero = new System.Windows.Forms.Label();
            this.luNascimento = new System.Windows.Forms.Label();
            this.luEndereco = new System.Windows.Forms.Label();
            this.luSobrenome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lubtnEditar = new System.Windows.Forms.Button();
            this.lubtnVoltar = new System.Windows.Forms.Button();
            this.lubtnNovo = new System.Windows.Forms.Button();
            this.lubtnDeletarDd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.25464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.74536F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LuNome
            // 
            this.LuNome.Location = new System.Drawing.Point(77, 399);
            this.LuNome.Name = "LuNome";
            this.LuNome.Size = new System.Drawing.Size(171, 20);
            this.LuNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // luDadosU
            // 
            this.luDadosU.AutoSize = true;
            this.luDadosU.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luDadosU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luDadosU.Location = new System.Drawing.Point(458, 5);
            this.luDadosU.Name = "luDadosU";
            this.luDadosU.Size = new System.Drawing.Size(99, 16);
            this.luDadosU.TabIndex = 5;
            this.luDadosU.Text = "Dados Usuario";
            this.luDadosU.Click += new System.EventHandler(this.label4_Click);
            // 
            // lubtnAlterar
            // 
            this.lubtnAlterar.Location = new System.Drawing.Point(437, 87);
            this.lubtnAlterar.Name = "lubtnAlterar";
            this.lubtnAlterar.Size = new System.Drawing.Size(63, 23);
            this.lubtnAlterar.TabIndex = 6;
            this.lubtnAlterar.Text = "Alterar";
            this.lubtnAlterar.UseVisualStyleBackColor = true;
            this.lubtnAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lubtnDeletar
            // 
            this.lubtnDeletar.Location = new System.Drawing.Point(506, 87);
            this.lubtnDeletar.Name = "lubtnDeletar";
            this.lubtnDeletar.Size = new System.Drawing.Size(64, 23);
            this.lubtnDeletar.TabIndex = 7;
            this.lubtnDeletar.Text = "Deletar";
            this.lubtnDeletar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 286);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(428, 248);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(428, 206);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(428, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(428, 121);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(171, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // luSenha
            // 
            this.luSenha.AutoSize = true;
            this.luSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luSenha.Location = new System.Drawing.Point(323, 362);
            this.luSenha.Name = "luSenha";
            this.luSenha.Size = new System.Drawing.Size(49, 16);
            this.luSenha.TabIndex = 16;
            this.luSenha.Text = "Senha";
            // 
            // luUsuario
            // 
            this.luUsuario.AutoSize = true;
            this.luUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luUsuario.Location = new System.Drawing.Point(323, 326);
            this.luUsuario.Name = "luUsuario";
            this.luUsuario.Size = new System.Drawing.Size(56, 16);
            this.luUsuario.TabIndex = 17;
            this.luUsuario.Text = "Usuário";
            this.luUsuario.UseWaitCursor = true;
            // 
            // luNumero
            // 
            this.luNumero.AutoSize = true;
            this.luNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luNumero.Location = new System.Drawing.Point(323, 290);
            this.luNumero.Name = "luNumero";
            this.luNumero.Size = new System.Drawing.Size(58, 16);
            this.luNumero.TabIndex = 18;
            this.luNumero.Text = "Número";
            // 
            // luNascimento
            // 
            this.luNascimento.AutoSize = true;
            this.luNascimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luNascimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luNascimento.Location = new System.Drawing.Point(323, 248);
            this.luNascimento.Name = "luNascimento";
            this.luNascimento.Size = new System.Drawing.Size(82, 16);
            this.luNascimento.TabIndex = 19;
            this.luNascimento.Text = "Nascimento";
            this.luNascimento.Click += new System.EventHandler(this.label8_Click);
            // 
            // luEndereco
            // 
            this.luEndereco.AutoSize = true;
            this.luEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luEndereco.Location = new System.Drawing.Point(323, 206);
            this.luEndereco.Name = "luEndereco";
            this.luEndereco.Size = new System.Drawing.Size(68, 16);
            this.luEndereco.TabIndex = 20;
            this.luEndereco.Text = "Endereço";
            this.luEndereco.Click += new System.EventHandler(this.label9_Click);
            // 
            // luSobrenome
            // 
            this.luSobrenome.AutoSize = true;
            this.luSobrenome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luSobrenome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luSobrenome.Location = new System.Drawing.Point(323, 165);
            this.luSobrenome.Name = "luSobrenome";
            this.luSobrenome.Size = new System.Drawing.Size(82, 16);
            this.luSobrenome.TabIndex = 21;
            this.luSobrenome.Text = "Sobrenome";
            this.luSobrenome.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(323, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(323, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirmar senha";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(428, 395);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 20);
            this.textBox8.TabIndex = 24;
            // 
            // lubtnEditar
            // 
            this.lubtnEditar.Location = new System.Drawing.Point(482, 423);
            this.lubtnEditar.Name = "lubtnEditar";
            this.lubtnEditar.Size = new System.Drawing.Size(48, 21);
            this.lubtnEditar.TabIndex = 27;
            this.lubtnEditar.Text = "Editar";
            this.lubtnEditar.UseVisualStyleBackColor = true;
            // 
            // lubtnVoltar
            // 
            this.lubtnVoltar.Location = new System.Drawing.Point(333, 423);
            this.lubtnVoltar.Name = "lubtnVoltar";
            this.lubtnVoltar.Size = new System.Drawing.Size(48, 21);
            this.lubtnVoltar.TabIndex = 28;
            this.lubtnVoltar.Text = "Voltar";
            this.lubtnVoltar.UseVisualStyleBackColor = true;
            // 
            // lubtnNovo
            // 
            this.lubtnNovo.Location = new System.Drawing.Point(416, 423);
            this.lubtnNovo.Name = "lubtnNovo";
            this.lubtnNovo.Size = new System.Drawing.Size(48, 21);
            this.lubtnNovo.TabIndex = 29;
            this.lubtnNovo.Text = "Novo";
            this.lubtnNovo.UseVisualStyleBackColor = true;
            // 
            // lubtnDeletarDd
            // 
            this.lubtnDeletarDd.Location = new System.Drawing.Point(543, 423);
            this.lubtnDeletarDd.Name = "lubtnDeletarDd";
            this.lubtnDeletarDd.Size = new System.Drawing.Size(56, 21);
            this.lubtnDeletarDd.TabIndex = 30;
            this.lubtnDeletarDd.Text = "Deletar";
            this.lubtnDeletarDd.UseVisualStyleBackColor = true;
            // 
            // ListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.lubtnDeletarDd);
            this.Controls.Add(this.lubtnNovo);
            this.Controls.Add(this.lubtnVoltar);
            this.Controls.Add(this.lubtnEditar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.luSobrenome);
            this.Controls.Add(this.luEndereco);
            this.Controls.Add(this.luNascimento);
            this.Controls.Add(this.luNumero);
            this.Controls.Add(this.luUsuario);
            this.Controls.Add(this.luSenha);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lubtnDeletar);
            this.Controls.Add(this.lubtnAlterar);
            this.Controls.Add(this.luDadosU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LuNome);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListarUsuario";
            this.Text = "ListarUsuario";
            this.Load += new System.EventHandler(this.ListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LuNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label luDadosU;
        private System.Windows.Forms.Button lubtnAlterar;
        private System.Windows.Forms.Button lubtnDeletar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label luSenha;
        private System.Windows.Forms.Label luUsuario;
        private System.Windows.Forms.Label luNumero;
        private System.Windows.Forms.Label luNascimento;
        private System.Windows.Forms.Label luEndereco;
        private System.Windows.Forms.Label luSobrenome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button lubtnEditar;
        private System.Windows.Forms.Button lubtnVoltar;
        private System.Windows.Forms.Button lubtnNovo;
        private System.Windows.Forms.Button lubtnDeletarDd;
    }
}