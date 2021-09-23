
namespace TrocoCaixa
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl050 = new System.Windows.Forms.Label();
            this.lbl025 = new System.Windows.Forms.Label();
            this.lbl010 = new System.Windows.Forms.Label();
            this.lbl005 = new System.Windows.Forms.Label();
            this.lbl001 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(215, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Size = new System.Drawing.Size(257, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Troco no Caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da Compra ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor em dinheiro ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Troco ";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(306, 117);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(114, 23);
            this.txtCompra.TabIndex = 4;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(306, 156);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(114, 23);
            this.txtDinheiro.TabIndex = 5;
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(306, 199);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(114, 23);
            this.txtTroco.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(113, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(307, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(547, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Moedas R$ 1,00";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(547, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moedas R$ 0,50";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(547, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Moedas R$ 0,25";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(547, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Moedas R$ 0,10";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(547, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Moedas R$ 0,05";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(547, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Moedas R$ 0,01";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl100
            // 
            this.lbl100.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl100.Location = new System.Drawing.Point(473, 117);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(68, 23);
            this.lbl100.TabIndex = 14;
            // 
            // lbl050
            // 
            this.lbl050.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl050.Location = new System.Drawing.Point(473, 145);
            this.lbl050.Name = "lbl050";
            this.lbl050.Size = new System.Drawing.Size(68, 23);
            this.lbl050.TabIndex = 15;
            // 
            // lbl025
            // 
            this.lbl025.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl025.Location = new System.Drawing.Point(473, 177);
            this.lbl025.Name = "lbl025";
            this.lbl025.Size = new System.Drawing.Size(68, 23);
            this.lbl025.TabIndex = 16;
            // 
            // lbl010
            // 
            this.lbl010.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl010.Location = new System.Drawing.Point(473, 209);
            this.lbl010.Name = "lbl010";
            this.lbl010.Size = new System.Drawing.Size(68, 23);
            this.lbl010.TabIndex = 17;
            // 
            // lbl005
            // 
            this.lbl005.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl005.Location = new System.Drawing.Point(473, 241);
            this.lbl005.Name = "lbl005";
            this.lbl005.Size = new System.Drawing.Size(68, 23);
            this.lbl005.TabIndex = 18;
            this.lbl005.Click += new System.EventHandler(this.label14_Click);
            // 
            // lbl001
            // 
            this.lbl001.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl001.Location = new System.Drawing.Point(473, 275);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(68, 23);
            this.lbl001.TabIndex = 19;
            // 
            // TelaPrincipal
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 349);
            this.Controls.Add(this.lbl001);
            this.Controls.Add(this.lbl005);
            this.Controls.Add(this.lbl010);
            this.Controls.Add(this.lbl025);
            this.Controls.Add(this.lbl050);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa :: Troco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl050;
        private System.Windows.Forms.Label lbl025;
        private System.Windows.Forms.Label lbl010;
        private System.Windows.Forms.Label lbl005;
        private System.Windows.Forms.Label lbl001;
    }
}