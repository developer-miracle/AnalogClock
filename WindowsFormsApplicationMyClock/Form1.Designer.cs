﻿namespace WindowsFormsApplicationMyClock
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
            this.startPauseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startPauseButton
            // 
            this.startPauseButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPauseButton.Location = new System.Drawing.Point(12, 76);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(75, 43);
            this.startPauseButton.TabIndex = 0;
            this.startPauseButton.Text = "start";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.startPauseButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "resset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSec.Location = new System.Drawing.Point(12, 32);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(20, 24);
            this.labelSec.TabIndex = 2;
            this.labelSec.Text = "0";
            this.labelSec.Click += new System.EventHandler(this.labelSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startPauseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label label1;
    }
}

