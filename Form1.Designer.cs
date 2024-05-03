namespace monthCalendar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.btnPegarData_Click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDataInicialAuto = new System.Windows.Forms.TextBox();
            this.textBoxDataFinalAuto = new System.Windows.Forms.TextBox();
            this.textBoxDataAtualAuto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(30, 29);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual :";
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Location = new System.Drawing.Point(498, 29);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(117, 26);
            this.textBoxDataInicial.TabIndex = 4;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Location = new System.Drawing.Point(498, 80);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(117, 26);
            this.textBoxDataFinal.TabIndex = 5;
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Location = new System.Drawing.Point(498, 135);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.Size = new System.Drawing.Size(117, 26);
            this.textBoxDataAtual.TabIndex = 6;
            // 
            // btnPegarData_Click
            // 
            this.btnPegarData_Click.Location = new System.Drawing.Point(419, 227);
            this.btnPegarData_Click.Name = "btnPegarData_Click";
            this.btnPegarData_Click.Size = new System.Drawing.Size(152, 36);
            this.btnPegarData_Click.TabIndex = 7;
            this.btnPegarData_Click.Text = "Pegar Data";
            this.btnPegarData_Click.UseVisualStyleBackColor = true;
            this.btnPegarData_Click.Click += new System.EventHandler(this.btnPegarData_Click_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Inicial :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Final :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Atual :";
            // 
            // textBoxDataInicialAuto
            // 
            this.textBoxDataInicialAuto.Location = new System.Drawing.Point(132, 305);
            this.textBoxDataInicialAuto.Name = "textBoxDataInicialAuto";
            this.textBoxDataInicialAuto.Size = new System.Drawing.Size(100, 26);
            this.textBoxDataInicialAuto.TabIndex = 11;
            // 
            // textBoxDataFinalAuto
            // 
            this.textBoxDataFinalAuto.Location = new System.Drawing.Point(132, 349);
            this.textBoxDataFinalAuto.Name = "textBoxDataFinalAuto";
            this.textBoxDataFinalAuto.Size = new System.Drawing.Size(100, 26);
            this.textBoxDataFinalAuto.TabIndex = 12;
            // 
            // textBoxDataAtualAuto
            // 
            this.textBoxDataAtualAuto.Location = new System.Drawing.Point(132, 398);
            this.textBoxDataAtualAuto.Name = "textBoxDataAtualAuto";
            this.textBoxDataAtualAuto.Size = new System.Drawing.Size(100, 26);
            this.textBoxDataAtualAuto.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDataAtualAuto);
            this.Controls.Add(this.textBoxDataFinalAuto);
            this.Controls.Add(this.textBoxDataInicialAuto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPegarData_Click);
            this.Controls.Add(this.textBoxDataAtual);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDataInicial;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.Button btnPegarData_Click;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDataInicialAuto;
        private System.Windows.Forms.TextBox textBoxDataFinalAuto;
        private System.Windows.Forms.TextBox textBoxDataAtualAuto;
    }
}

