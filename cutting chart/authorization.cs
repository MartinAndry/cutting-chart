using System;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 30);
        }
        
        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAppButton_MouseEnter(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.Red;
        }

        private void CloseAppButton_MouseLeave(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.FromArgb(239, 243, 239);
        }
        
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

        private void ShowPassPic_MouseEnter(object sender, EventArgs e)
        {
            if (PassField.UseSystemPasswordChar)
            {
                PassField.ForeColor = Color.Red;
            }
        }

        private void ShowPassPic_MouseLeave(object sender, EventArgs e)
        {
            PassField.ForeColor = Color.Black;
        }

        private void ShowPassPic_Click(object sender, EventArgs e)
        {
            if (PassField.UseSystemPasswordChar)
            {
                PassField.UseSystemPasswordChar = false;
            }
            else
            {
                PassField.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Green;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.White;
        }

        private void RegistrationLabel_MouseEnter(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.Green;
        }

        private void RegistrationLabel_MouseLeave(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.White;
        }

        private void ForgotPassLabel_MouseEnter(object sender, EventArgs e)
        {
            ForgotPassLabel.ForeColor = Color.Green;
        }

        private void ForgotPassLabel_MouseLeave(object sender, EventArgs e)
        {
            ForgotPassLabel.ForeColor = Color.White;
        }
    }
}
