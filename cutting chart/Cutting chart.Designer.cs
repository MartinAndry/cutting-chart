﻿
namespace cutting_chart
{
    partial class Cutting_chart
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseAppButton = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.CuttingChartTitle = new System.Windows.Forms.Label();
            this.BackGroundPic = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.DownBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.TopBorder.SuspendLayout();
            this.BackGroundPic.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.TopBorder.Controls.Add(this.CloseAppButton);
            this.TopBorder.Controls.Add(this.UserName);
            this.TopBorder.Controls.Add(this.CuttingChartTitle);
            this.TopBorder.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(900, 25);
            this.TopBorder.TabIndex = 1;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.AutoSize = true;
            this.CloseAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.CloseAppButton.Location = new System.Drawing.Point(873, 0);
            this.CloseAppButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.CloseAppButton.Size = new System.Drawing.Size(22, 23);
            this.CloseAppButton.TabIndex = 0;
            this.CloseAppButton.Text = "X";
            this.CloseAppButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            this.CloseAppButton.MouseEnter += new System.EventHandler(this.CloseAppButton_MouseEnter);
            this.CloseAppButton.MouseLeave += new System.EventHandler(this.CloseAppButton_MouseLeave);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserName.Location = new System.Drawing.Point(133, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(83, 21);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            // 
            // CuttingChartTitle
            // 
            this.CuttingChartTitle.AutoSize = true;
            this.CuttingChartTitle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CuttingChartTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CuttingChartTitle.Location = new System.Drawing.Point(3, 4);
            this.CuttingChartTitle.Name = "CuttingChartTitle";
            this.CuttingChartTitle.Size = new System.Drawing.Size(101, 21);
            this.CuttingChartTitle.TabIndex = 1;
            this.CuttingChartTitle.Text = "CuttingChart";
            // 
            // BackGroundPic
            // 
            this.BackGroundPic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackGroundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGroundPic.Controls.Add(this.MainMenu);
            this.BackGroundPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPic.Location = new System.Drawing.Point(0, 25);
            this.BackGroundPic.Name = "BackGroundPic";
            this.BackGroundPic.Size = new System.Drawing.Size(900, 575);
            this.BackGroundPic.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.asdToolStripMenuItem,
            this.asdToolStripMenuItem1,
            this.asdToolStripMenuItem2});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(900, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem9,
            this.asdToolStripMenuItem10});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // asdToolStripMenuItem9
            // 
            this.asdToolStripMenuItem9.Name = "asdToolStripMenuItem9";
            this.asdToolStripMenuItem9.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem9.Text = "asd";
            // 
            // asdToolStripMenuItem10
            // 
            this.asdToolStripMenuItem10.Name = "asdToolStripMenuItem10";
            this.asdToolStripMenuItem10.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem10.Text = "asd";
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem6,
            this.asdToolStripMenuItem7});
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.asdToolStripMenuItem1.Text = "asd";
            // 
            // asdToolStripMenuItem6
            // 
            this.asdToolStripMenuItem6.Name = "asdToolStripMenuItem6";
            this.asdToolStripMenuItem6.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem6.Text = "asd";
            // 
            // asdToolStripMenuItem7
            // 
            this.asdToolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem8});
            this.asdToolStripMenuItem7.Name = "asdToolStripMenuItem7";
            this.asdToolStripMenuItem7.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem7.Text = "asd";
            // 
            // asdToolStripMenuItem8
            // 
            this.asdToolStripMenuItem8.Name = "asdToolStripMenuItem8";
            this.asdToolStripMenuItem8.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem8.Text = "asd";
            // 
            // asdToolStripMenuItem2
            // 
            this.asdToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem3,
            this.asdToolStripMenuItem4});
            this.asdToolStripMenuItem2.Name = "asdToolStripMenuItem2";
            this.asdToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.asdToolStripMenuItem2.Text = "asd";
            // 
            // asdToolStripMenuItem3
            // 
            this.asdToolStripMenuItem3.Name = "asdToolStripMenuItem3";
            this.asdToolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem3.Text = "asd";
            // 
            // asdToolStripMenuItem4
            // 
            this.asdToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem5});
            this.asdToolStripMenuItem4.Name = "asdToolStripMenuItem4";
            this.asdToolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem4.Text = "asd";
            // 
            // asdToolStripMenuItem5
            // 
            this.asdToolStripMenuItem5.Name = "asdToolStripMenuItem5";
            this.asdToolStripMenuItem5.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem5.Text = "asd";
            // 
            // DownBorder
            // 
            this.DownBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.DownBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownBorder.Location = new System.Drawing.Point(5, 595);
            this.DownBorder.Name = "DownBorder";
            this.DownBorder.Size = new System.Drawing.Size(890, 5);
            this.DownBorder.TabIndex = 3;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.Location = new System.Drawing.Point(0, 25);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(5, 575);
            this.LeftBorder.TabIndex = 4;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(895, 25);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(5, 575);
            this.RightBorder.TabIndex = 5;
            // 
            // Cutting_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.DownBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.BackGroundPic);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Cutting_chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cutting_chart";
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.BackGroundPic.ResumeLayout(false);
            this.BackGroundPic.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Label CloseAppButton;
        private System.Windows.Forms.Panel BackGroundPic;
        private System.Windows.Forms.Panel DownBorder;
        private System.Windows.Forms.Panel LeftBorder;
        private System.Windows.Forms.Panel RightBorder;
        private System.Windows.Forms.Label CuttingChartTitle;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}