namespace WindowsFormsApp_Protocolo
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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.ckbSimples = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbOutros = new System.Windows.Forms.CheckBox();
            this.ckbRegAr = new System.Windows.Forms.CheckBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.btGerador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblpostagem = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbProtocolo = new System.Windows.Forms.GroupBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbProtocolo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(79, 16);
            this.txtEmpresa.Multiline = true;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(247, 20);
            this.txtEmpresa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(79, 39);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(247, 20);
            this.txtObservacao.TabIndex = 2;
            // 
            // ckbSimples
            // 
            this.ckbSimples.AutoSize = true;
            this.ckbSimples.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckbSimples.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbSimples.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ckbSimples.Location = new System.Drawing.Point(6, 19);
            this.ckbSimples.Name = "ckbSimples";
            this.ckbSimples.Size = new System.Drawing.Size(68, 18);
            this.ckbSimples.TabIndex = 5;
            this.ckbSimples.Text = "Simples";
            this.ckbSimples.UseVisualStyleBackColor = true;
            this.ckbSimples.CheckedChanged += new System.EventHandler(this.ckbSimples_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.ckbOutros);
            this.groupBox1.Controls.Add(this.ckbRegAr);
            this.groupBox1.Controls.Add(this.ckbSimples);
            this.groupBox1.Controls.Add(this.txtModalidade);
            this.groupBox1.Location = new System.Drawing.Point(33, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidade de Postagem";
            // 
            // ckbOutros
            // 
            this.ckbOutros.AutoSize = true;
            this.ckbOutros.Location = new System.Drawing.Point(6, 65);
            this.ckbOutros.Name = "ckbOutros";
            this.ckbOutros.Size = new System.Drawing.Size(57, 17);
            this.ckbOutros.TabIndex = 7;
            this.ckbOutros.Text = "Outros";
            this.ckbOutros.UseVisualStyleBackColor = true;
            this.ckbOutros.CheckedChanged += new System.EventHandler(this.ckbOutros_CheckedChanged);
            // 
            // ckbRegAr
            // 
            this.ckbRegAr.AutoSize = true;
            this.ckbRegAr.Location = new System.Drawing.Point(6, 42);
            this.ckbRegAr.Name = "ckbRegAr";
            this.ckbRegAr.Size = new System.Drawing.Size(68, 17);
            this.ckbRegAr.TabIndex = 6;
            this.ckbRegAr.Text = "Reg + Ar";
            this.ckbRegAr.UseVisualStyleBackColor = true;
            this.ckbRegAr.CheckedChanged += new System.EventHandler(this.ckbRegAr_CheckedChanged);
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(6, 85);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(151, 20);
            this.txtModalidade.TabIndex = 10;
            this.txtModalidade.Visible = false;
            this.txtModalidade.TextChanged += new System.EventHandler(this.txtModalidade_TextChanged);
            // 
            // btGerador
            // 
            this.btGerador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGerador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btGerador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGerador.Location = new System.Drawing.Point(258, 149);
            this.btGerador.Name = "btGerador";
            this.btGerador.Size = new System.Drawing.Size(67, 27);
            this.btGerador.TabIndex = 8;
            this.btGerador.Text = "Gerador";
            this.btGerador.UseVisualStyleBackColor = false;
            this.btGerador.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empresa:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade :";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Postagem:";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(258, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Observações";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(79, 65);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(90, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(81, 64);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "0";
            this.lblQuantidade.Visible = false;
            // 
            // lblpostagem
            // 
            this.lblpostagem.AutoSize = true;
            this.lblpostagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpostagem.Location = new System.Drawing.Point(81, 46);
            this.lblpostagem.Name = "lblpostagem";
            this.lblpostagem.Size = new System.Drawing.Size(10, 13);
            this.lblpostagem.TabIndex = 18;
            this.lblpostagem.Text = ".";
            this.lblpostagem.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.TabStop = false;
            // 
            // grbProtocolo
            // 
            this.grbProtocolo.Controls.Add(this.lblObservacao);
            this.grbProtocolo.Controls.Add(this.label7);
            this.grbProtocolo.Controls.Add(this.lblEmpresa);
            this.grbProtocolo.Controls.Add(this.label3);
            this.grbProtocolo.Controls.Add(this.label4);
            this.grbProtocolo.Controls.Add(this.lblpostagem);
            this.grbProtocolo.Controls.Add(this.label5);
            this.grbProtocolo.Controls.Add(this.lblQuantidade);
            this.grbProtocolo.Location = new System.Drawing.Point(94, 293);
            this.grbProtocolo.Name = "grbProtocolo";
            this.grbProtocolo.Size = new System.Drawing.Size(200, 100);
            this.grbProtocolo.TabIndex = 20;
            this.grbProtocolo.TabStop = false;
            this.grbProtocolo.Text = "Protocolo";
            this.grbProtocolo.Visible = false;
            this.grbProtocolo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblObservacao.Location = new System.Drawing.Point(87, 84);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(10, 13);
            this.lblObservacao.TabIndex = 22;
            this.lblObservacao.Text = ".";
            this.lblObservacao.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(15, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Observações :";
            this.label7.Visible = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpresa.Location = new System.Drawing.Point(81, 28);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(10, 13);
            this.lblEmpresa.TabIndex = 20;
            this.lblEmpresa.Text = ".";
            this.lblEmpresa.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtEmpresa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtObservacao);
            this.groupBox3.Controls.Add(this.txtQuantidade);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(22, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 105);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Calendário ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(386, 415);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbProtocolo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btGerador);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protocolo";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbProtocolo.ResumeLayout(false);
            this.grbProtocolo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.CheckBox ckbSimples;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbOutros;
        private System.Windows.Forms.CheckBox ckbRegAr;
        private System.Windows.Forms.Button btGerador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblpostagem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grbProtocolo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label label7;
    }
}

