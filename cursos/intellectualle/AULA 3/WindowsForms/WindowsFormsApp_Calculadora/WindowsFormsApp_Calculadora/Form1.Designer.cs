namespace WindowsFormsApp_Calculadora
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
            this.txtCalculadora = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btMultipicacao = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalculadora
            // 
            this.txtCalculadora.Location = new System.Drawing.Point(12, 12);
            this.txtCalculadora.Name = "txtCalculadora";
            this.txtCalculadora.Size = new System.Drawing.Size(213, 20);
            this.txtCalculadora.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 51);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(53, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(71, 51);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(53, 23);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(130, 51);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(53, 23);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_numero);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(189, 51);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(36, 23);
            this.btSoma.TabIndex = 4;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btOperador);
            // 
            // btSubtracao
            // 
            this.btSubtracao.Location = new System.Drawing.Point(189, 80);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(36, 23);
            this.btSubtracao.TabIndex = 8;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = true;
            this.btSubtracao.Click += new System.EventHandler(this.btOperador);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(130, 80);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(53, 23);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(71, 80);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(53, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 80);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(53, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_numero);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(189, 109);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(36, 23);
            this.btDivisao.TabIndex = 12;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btOperador);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(130, 109);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(53, 23);
            this.bt9.TabIndex = 11;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(71, 109);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(53, 23);
            this.bt8.TabIndex = 10;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_numero);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 109);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(53, 23);
            this.bt7.TabIndex = 9;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_numero);
            // 
            // btMultipicacao
            // 
            this.btMultipicacao.Location = new System.Drawing.Point(189, 138);
            this.btMultipicacao.Name = "btMultipicacao";
            this.btMultipicacao.Size = new System.Drawing.Size(36, 23);
            this.btMultipicacao.TabIndex = 16;
            this.btMultipicacao.Text = "x";
            this.btMultipicacao.UseVisualStyleBackColor = true;
            this.btMultipicacao.Click += new System.EventHandler(this.btOperador);
            // 
            // btResultado
            // 
            this.btResultado.Location = new System.Drawing.Point(130, 138);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(53, 23);
            this.btResultado.TabIndex = 15;
            this.btResultado.Text = "=";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(71, 138);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(53, 23);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_numero);
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(12, 138);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(53, 23);
            this.btLimpa.TabIndex = 13;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 175);
            this.Controls.Add(this.btMultipicacao);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txtCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalculadora;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btMultipicacao;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btLimpa;
    }
}

