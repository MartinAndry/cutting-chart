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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            NameField.Text = "Имя";
            SurnameField.Text = "Фамилия";
            PhoneField.Text = "Телефон";
            LoginField.Text = "Логин";
            PassField.Text = "Пароль";
            PassField2.Text = "Повторите пароль";

        }

        #region [CloseAppButton_Click]
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

        #region [ShowPassPic]

        private void ShowPassPic_MouseEnter(object sender, EventArgs e)
        {
            if (PassField.UseSystemPasswordChar)
            {
                PassField.ForeColor = Color.Red;
            }

            if (PassField2.UseSystemPasswordChar)
            {
                PassField2.ForeColor = Color.Red;
            }
        }

        private void ShowPassPic_MouseLeave(object sender, EventArgs e)
        {
            PassField.ForeColor = Color.Black;
            PassField2.ForeColor = Color.Black;
        }

        private void ShowPassPic_Click(object sender, EventArgs e)
        {
            if (!PassField.UseSystemPasswordChar)
            {
                if (PassField.Text != "Пароль")
                {
                    PassField.UseSystemPasswordChar = true;
                }
            }
            else
            {
                PassField.UseSystemPasswordChar = false;
            }

            if (!PassField2.UseSystemPasswordChar)
            {
                if (PassField2.Text != "Повторите пароль")
                {
                    PassField2.UseSystemPasswordChar = true;
                }
            }
            else
            {
                PassField2.UseSystemPasswordChar = false;
            }

        }

        #endregion

        #region [NameField]
        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Имя";
                NameField.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region [SurnameField]
        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Фамилия")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Фамилия";
                SurnameField.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region [PhoneField]
        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Телефон")
            {
                PhoneField.Text = "";
                PhoneField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (PhoneField.Text == "")
            {
                PhoneField.Text = "Телефон";
                PhoneField.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region [LoginField]
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Логин";
                LoginField.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region [PassField]
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
            {
                PassField.UseSystemPasswordChar = true;
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Пароль";
                PassField.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region [PassField2]
        private void PassField2_Enter(object sender, EventArgs e)
        {
            if (PassField2.Text == "Повторите пароль")
            {
                PassField2.UseSystemPasswordChar = true;
                PassField2.Text = "";
                PassField2.ForeColor = Color.Black;
            }
        }

        private void PassField2_Leave(object sender, EventArgs e)
        {
            if (PassField2.Text == "")
            {
                PassField2.UseSystemPasswordChar = false;
                PassField2.Text = "Повторите пароль";
                PassField2.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
