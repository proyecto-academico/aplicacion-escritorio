﻿namespace PRUEAS
{
    partial class Eventos
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
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(16, 46);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 531);
            Controls.Add(monthCalendar1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Eventos";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
    }
}