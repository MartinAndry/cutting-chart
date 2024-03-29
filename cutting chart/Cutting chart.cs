﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cutting_chart
{
    public partial class Cutting_chart : Form
    {
        public Cutting_chart()
        {
            InitializeComponent();
        }


        #region [CloseAppButton]
        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseAppButton_MouseEnter(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.Red;
        }

        private void CloseAppButton_MouseLeave(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.FromArgb(239, 243, 239);
        }
        #endregion

        #region [TopBorder_MouseMove]
        Point lastPoint;
        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion


        #region [Change_Size]
        private void RightBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X);
        }

        private void RightBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Width += e.X - lastPoint.X;
            }
        }

        private void DownBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.Y);
        }

        private void DownBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Height += e.Y - lastPoint.Y;
            }
        }

        private void CornerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CornerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Width += e.X - lastPoint.X;
                this.Height += e.Y - lastPoint.Y;
            }
        }
        #endregion
    }
}
