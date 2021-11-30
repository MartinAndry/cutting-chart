
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
            this.BackGroundPic = new System.Windows.Forms.Panel();
            this.DownBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.TopBorder.Controls.Add(this.CloseAppButton);
            this.TopBorder.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(5, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(790, 23);
            this.TopBorder.TabIndex = 1;
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.AutoSize = true;
            this.CloseAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.CloseAppButton.Location = new System.Drawing.Point(768, 0);
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
            // BackGroundPic
            // 
            this.BackGroundPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(187)))), ((int)(((byte)(253)))));
            this.BackGroundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGroundPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPic.Location = new System.Drawing.Point(5, 0);
            this.BackGroundPic.Name = "BackGroundPic";
            this.BackGroundPic.Size = new System.Drawing.Size(790, 445);
            this.BackGroundPic.TabIndex = 2;
            // 
            // DownBorder
            // 
            this.DownBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.DownBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownBorder.Location = new System.Drawing.Point(5, 445);
            this.DownBorder.Name = "DownBorder";
            this.DownBorder.Size = new System.Drawing.Size(790, 5);
            this.DownBorder.TabIndex = 3;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.Location = new System.Drawing.Point(0, 0);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(5, 450);
            this.LeftBorder.TabIndex = 4;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(795, 0);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(5, 450);
            this.RightBorder.TabIndex = 5;
            // 
            // Cutting_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopBorder);
            this.Controls.Add(this.BackGroundPic);
            this.Controls.Add(this.DownBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cutting_chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cutting_chart";
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Label CloseAppButton;
        private System.Windows.Forms.Panel BackGroundPic;
        private System.Windows.Forms.Panel DownBorder;
        private System.Windows.Forms.Panel LeftBorder;
        private System.Windows.Forms.Panel RightBorder;
    }
}