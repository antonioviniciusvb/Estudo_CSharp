namespace WindowsFormsApp_Hotel
{
    partial class FrmHotel
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
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTipoD = new System.Windows.Forms.RadioButton();
            this.rbtTipoA = new System.Windows.Forms.RadioButton();
            this.rbtTipoC = new System.Windows.Forms.RadioButton();
            this.rbtTipoB = new System.Windows.Forms.RadioButton();
            this.lstQuantidadeDiarias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTaxaServico = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblConsumoInterno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalDiárias = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuantidadeDiaria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHospede
            // 
            this.txtHospede.Location = new System.Drawing.Point(96, 19);
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(264, 20);
            this.txtHospede.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospede";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(96, 55);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(74, 20);
            this.txtConsumo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbtTipoD);
            this.groupBox1.Controls.Add(this.rbtTipoA);
            this.groupBox1.Controls.Add(this.rbtTipoC);
            this.groupBox1.Controls.Add(this.rbtTipoB);
            this.groupBox1.Location = new System.Drawing.Point(373, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Apartamento";
            // 
            // rbtTipoD
            // 
            this.rbtTipoD.AutoSize = true;
            this.rbtTipoD.Location = new System.Drawing.Point(120, 19);
            this.rbtTipoD.Name = "rbtTipoD";
            this.rbtTipoD.Size = new System.Drawing.Size(33, 17);
            this.rbtTipoD.TabIndex = 8;
            this.rbtTipoD.TabStop = true;
            this.rbtTipoD.Text = "D";
            this.rbtTipoD.UseVisualStyleBackColor = true;
            // 
            // rbtTipoA
            // 
            this.rbtTipoA.AutoSize = true;
            this.rbtTipoA.Location = new System.Drawing.Point(6, 19);
            this.rbtTipoA.Name = "rbtTipoA";
            this.rbtTipoA.Size = new System.Drawing.Size(32, 17);
            this.rbtTipoA.TabIndex = 5;
            this.rbtTipoA.TabStop = true;
            this.rbtTipoA.Text = "A";
            this.rbtTipoA.UseVisualStyleBackColor = true;
            this.rbtTipoA.CheckedChanged += new System.EventHandler(this.rbtTipoA_CheckedChanged);
            // 
            // rbtTipoC
            // 
            this.rbtTipoC.AutoSize = true;
            this.rbtTipoC.Location = new System.Drawing.Point(82, 19);
            this.rbtTipoC.Name = "rbtTipoC";
            this.rbtTipoC.Size = new System.Drawing.Size(32, 17);
            this.rbtTipoC.TabIndex = 7;
            this.rbtTipoC.TabStop = true;
            this.rbtTipoC.Text = "C";
            this.rbtTipoC.UseVisualStyleBackColor = true;
            // 
            // rbtTipoB
            // 
            this.rbtTipoB.AutoSize = true;
            this.rbtTipoB.Location = new System.Drawing.Point(44, 19);
            this.rbtTipoB.Name = "rbtTipoB";
            this.rbtTipoB.Size = new System.Drawing.Size(32, 17);
            this.rbtTipoB.TabIndex = 6;
            this.rbtTipoB.TabStop = true;
            this.rbtTipoB.Text = "B";
            this.rbtTipoB.UseVisualStyleBackColor = true;
            // 
            // lstQuantidadeDiarias
            // 
            this.lstQuantidadeDiarias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstQuantidadeDiarias.FormattingEnabled = true;
            this.lstQuantidadeDiarias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstQuantidadeDiarias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.lstQuantidadeDiarias.Location = new System.Drawing.Point(161, 96);
            this.lstQuantidadeDiarias.Name = "lstQuantidadeDiarias";
            this.lstQuantidadeDiarias.Size = new System.Drawing.Size(85, 56);
            this.lstQuantidadeDiarias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade de Diárias";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.lblTotalPagar);
            this.groupBox2.Controls.Add(this.lblTaxaServico);
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.lblConsumoInterno);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalDiárias);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblQuantidadeDiaria);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHECK OUT";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(285, 53);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 28);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoEllipsis = true;
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(132, 121);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPagar.TabIndex = 18;
            this.lblTotalPagar.Text = "0";
            // 
            // lblTaxaServico
            // 
            this.lblTaxaServico.AutoEllipsis = true;
            this.lblTaxaServico.AutoSize = true;
            this.lblTaxaServico.Location = new System.Drawing.Point(132, 101);
            this.lblTaxaServico.Name = "lblTaxaServico";
            this.lblTaxaServico.Size = new System.Drawing.Size(13, 13);
            this.lblTaxaServico.TabIndex = 17;
            this.lblTaxaServico.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoEllipsis = true;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(132, 81);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "0";
            // 
            // lblConsumoInterno
            // 
            this.lblConsumoInterno.AutoEllipsis = true;
            this.lblConsumoInterno.AutoSize = true;
            this.lblConsumoInterno.Location = new System.Drawing.Point(132, 61);
            this.lblConsumoInterno.Name = "lblConsumoInterno";
            this.lblConsumoInterno.Size = new System.Drawing.Size(13, 13);
            this.lblConsumoInterno.TabIndex = 15;
            this.lblConsumoInterno.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total a pagar:      R$";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Taxa de Serviço: R$";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sub Total:            R$";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consumo Interno: R$";
            // 
            // lblTotalDiárias
            // 
            this.lblTotalDiárias.AutoSize = true;
            this.lblTotalDiárias.Location = new System.Drawing.Point(132, 41);
            this.lblTotalDiárias.Name = "lblTotalDiárias";
            this.lblTotalDiárias.Size = new System.Drawing.Size(13, 13);
            this.lblTotalDiárias.TabIndex = 10;
            this.lblTotalDiárias.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total de Diárias:   R$";
            // 
            // lblQuantidadeDiaria
            // 
            this.lblQuantidadeDiaria.AutoSize = true;
            this.lblQuantidadeDiaria.Location = new System.Drawing.Point(132, 21);
            this.lblQuantidadeDiaria.Name = "lblQuantidadeDiaria";
            this.lblQuantidadeDiaria.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidadeDiaria.TabIndex = 8;
            this.lblQuantidadeDiaria.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade de Diárias";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCalcular.Location = new System.Drawing.Point(373, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 25);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(373, 135);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(153, 26);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 329);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstQuantidadeDiarias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHospede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHotel";
            this.RightToLeftLayout = true;
            this.Text = "Hotel C Sharp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTipoD;
        private System.Windows.Forms.RadioButton rbtTipoA;
        private System.Windows.Forms.RadioButton rbtTipoC;
        private System.Windows.Forms.RadioButton rbtTipoB;
        private System.Windows.Forms.ListBox lstQuantidadeDiarias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTaxaServico;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblConsumoInterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalDiárias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuantidadeDiaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

