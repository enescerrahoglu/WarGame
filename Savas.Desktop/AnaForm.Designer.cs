﻿
namespace Savas.Desktop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.ucaksavarPanel = new System.Windows.Forms.Panel();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1010, 100);
            this.bilgiPanel.TabIndex = 0;
            // 
            // ucaksavarPanel
            // 
            this.ucaksavarPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ucaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavarPanel.Location = new System.Drawing.Point(0, 509);
            this.ucaksavarPanel.Name = "ucaksavarPanel";
            this.ucaksavarPanel.Size = new System.Drawing.Size(1010, 50);
            this.ucaksavarPanel.TabIndex = 1;
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.Turquoise;
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 100);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(1010, 409);
            this.savasAlaniPanel.TabIndex = 2;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bilgiLabel.Location = new System.Drawing.Point(3, 13);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(613, 69);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L yön tuşlarına basın.\r\nAteş etmek için SPACE tuşuna basın.";
            this.bilgiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.sureLabel.Location = new System.Drawing.Point(740, 16);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(267, 73);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 559);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.ucaksavarPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "  Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel ucaksavarPanel;
        private System.Windows.Forms.Panel savasAlaniPanel;
        private System.Windows.Forms.Label sureLabel;
    }
}

