namespace ViaCEP
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
            this.btnCEP = new System.Windows.Forms.Button();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtIBGE = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mbxCEP = new System.Windows.Forms.MaskedTextBox();
            this.rbtnLimpar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(406, 12);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(90, 21);
            this.btnCEP.TabIndex = 0;
            this.btnCEP.Text = "Buscar dados";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(185, 66);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(100, 20);
            this.txtLogradouro.TabIndex = 2;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(185, 124);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(185, 183);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtIBGE
            // 
            this.txtIBGE.Location = new System.Drawing.Point(475, 184);
            this.txtIBGE.Name = "txtIBGE";
            this.txtIBGE.Size = new System.Drawing.Size(100, 20);
            this.txtIBGE.TabIndex = 8;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(475, 124);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtUnidade.TabIndex = 7;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(475, 66);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 6;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(185, 234);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidade.TabIndex = 5;
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(475, 234);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(100, 20);
            this.txtGIA.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Complemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Localidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Logradouro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Unidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IBGE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "GIA";
            // 
            // mbxCEP
            // 
            this.mbxCEP.CausesValidation = false;
            this.mbxCEP.Location = new System.Drawing.Point(322, 12);
            this.mbxCEP.Mask = "99999-999";
            this.mbxCEP.Name = "mbxCEP";
            this.mbxCEP.Size = new System.Drawing.Size(64, 20);
            this.mbxCEP.TabIndex = 19;
            // 
            // rbtnLimpar
            // 
            this.rbtnLimpar.AutoSize = true;
            this.rbtnLimpar.Location = new System.Drawing.Point(524, 14);
            this.rbtnLimpar.Name = "rbtnLimpar";
            this.rbtnLimpar.Size = new System.Drawing.Size(96, 17);
            this.rbtnLimpar.TabIndex = 21;
            this.rbtnLimpar.TabStop = true;
            this.rbtnLimpar.Text = "Limpar campos";
            this.rbtnLimpar.UseVisualStyleBackColor = true;
            this.rbtnLimpar.CheckedChanged += new System.EventHandler(this.rbtnLimpar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnLimpar);
            this.Controls.Add(this.mbxCEP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGIA);
            this.Controls.Add(this.txtIBGE);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.btnCEP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtIBGE;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mbxCEP;
        private System.Windows.Forms.RadioButton rbtnLimpar;
    }
}

