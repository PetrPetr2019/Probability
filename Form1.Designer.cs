namespace CalculateProbability
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxParameterTn = new System.Windows.Forms.TextBox();
            this.textBoxParameterTo = new System.Windows.Forms.TextBox();
            this.textBoxParameterS = new System.Windows.Forms.TextBox();
            this.textBoxParameterF = new System.Windows.Forms.TextBox();
            this.textBoxParameterFv = new System.Windows.Forms.TextBox();
            this.textBoxParameterEps = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameterTn
            // 
            this.textBoxParameterTn.Location = new System.Drawing.Point(6, 22);
            this.textBoxParameterTn.Name = "textBoxParameterTn";
            this.textBoxParameterTn.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterTn.TabIndex = 0;
            // 
            // textBoxParameterTo
            // 
            this.textBoxParameterTo.Location = new System.Drawing.Point(6, 77);
            this.textBoxParameterTo.Name = "textBoxParameterTo";
            this.textBoxParameterTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterTo.TabIndex = 1;
            // 
            // textBoxParameterS
            // 
            this.textBoxParameterS.Location = new System.Drawing.Point(6, 137);
            this.textBoxParameterS.Name = "textBoxParameterS";
            this.textBoxParameterS.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterS.TabIndex = 2;
            // 
            // textBoxParameterF
            // 
            this.textBoxParameterF.Location = new System.Drawing.Point(6, 202);
            this.textBoxParameterF.Name = "textBoxParameterF";
            this.textBoxParameterF.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterF.TabIndex = 3;
            // 
            // textBoxParameterFv
            // 
            this.textBoxParameterFv.Location = new System.Drawing.Point(6, 266);
            this.textBoxParameterFv.Name = "textBoxParameterFv";
            this.textBoxParameterFv.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterFv.TabIndex = 4;
            // 
            // textBoxParameterEps
            // 
            this.textBoxParameterEps.Location = new System.Drawing.Point(6, 332);
            this.textBoxParameterEps.Name = "textBoxParameterEps";
            this.textBoxParameterEps.Size = new System.Drawing.Size(100, 20);
            this.textBoxParameterEps.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(144, 24);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(292, 52);
            this.labelResult.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Условие проверки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(144, 111);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(292, 26);
            this.progressBar.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сохранение расчета в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(151, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вывод результата";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(152, 93);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(277, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Визуализация вывода";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 354);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxParameterEps);
            this.Controls.Add(this.textBoxParameterFv);
            this.Controls.Add(this.textBoxParameterF);
            this.Controls.Add(this.textBoxParameterS);
            this.Controls.Add(this.textBoxParameterTo);
            this.Controls.Add(this.textBoxParameterTn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameterTn;
        private System.Windows.Forms.TextBox textBoxParameterTo;
        private System.Windows.Forms.TextBox textBoxParameterS;
        private System.Windows.Forms.TextBox textBoxParameterF;
        private System.Windows.Forms.TextBox textBoxParameterFv;
        private System.Windows.Forms.TextBox textBoxParameterEps;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

