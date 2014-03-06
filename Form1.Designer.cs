namespace Кредитный_калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Payment2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.Payment3 = new System.Windows.Forms.Label();
            this.Payment4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(21, 25);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(115, 20);
            this.Sum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма кредита (руб.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процентная ставка";
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(21, 76);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(115, 20);
            this.Percent.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(21, 127);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 20);
            this.Date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок средита (мес)";
            // 
            // Calculation
            // 
            this.Calculation.Location = new System.Drawing.Point(21, 168);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(75, 23);
            this.Calculation.TabIndex = 6;
            this.Calculation.Text = "Расчитать";
            this.Calculation.UseVisualStyleBackColor = true;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Возраст";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(417, 25);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(49, 20);
            this.Age.TabIndex = 7;
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(192, 32);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(0, 13);
            this.Payment.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ежемесячный платеж (руб.)";
            // 
            // Payment2
            // 
            this.Payment2.AutoSize = true;
            this.Payment2.Location = new System.Drawing.Point(192, 83);
            this.Payment2.Name = "Payment2";
            this.Payment2.Size = new System.Drawing.Size(0, 13);
            this.Payment2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Полная стоимость кредита (руб.)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(417, 287);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Справка";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Переплата составит (руб.)";
            // 
            // Payment3
            // 
            this.Payment3.AutoSize = true;
            this.Payment3.Location = new System.Drawing.Point(192, 134);
            this.Payment3.Name = "Payment3";
            this.Payment3.Size = new System.Drawing.Size(0, 13);
            this.Payment3.TabIndex = 20;
            // 
            // Payment4
            // 
            this.Payment4.Location = new System.Drawing.Point(195, 173);
            this.Payment4.Name = "Payment4";
            this.Payment4.Size = new System.Drawing.Size(145, 144);
            this.Payment4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 332);
            this.Controls.Add(this.Payment4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Payment3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Payment2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Payment2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Payment3;
        private System.Windows.Forms.Label Payment4;
    }
}

