﻿namespace Renting_Car_Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BorderlessFormMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnLogOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BorderlessFormMain
            // 
            this.BorderlessFormMain.AnimateWindow = true;
            this.BorderlessFormMain.BorderRadius = 35;
            this.BorderlessFormMain.ContainerControl = this;
            this.BorderlessFormMain.DockForm = false;
            this.BorderlessFormMain.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormMain.ResizeForm = false;
            this.BorderlessFormMain.TransparentWhileDrag = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Renting_Car_Project.Properties.Resources.material_symbols__logout__1_;
            this.btnLogOut.Location = new System.Drawing.Point(9, 7);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 65);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 576);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormMain;
        private System.Windows.Forms.Label btnLogOut;
    }
}

