using MySql.Data.MySqlClient;
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

            LoginField.Text = "Логин";
            PassField.Text = "Пароль";
            
        }
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

        #region [CloseAppButton_Click]
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

        #region [ShowPassPic]

        private void ShowPassPic_MouseEnter(object sender, EventArgs e)
        {
            if (PassField.UseSystemPasswordChar)
            {
                PassField.ForeColor = Color.Red;
            }
        }

        private void ShowPassPic_MouseLeave(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
                PassField.ForeColor = Color.Gray;
            else
            PassField.ForeColor = Color.Black;
        }

        private void ShowPassPic_MouseDown(object sender, MouseEventArgs e)
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
        }

        private void ShowPassPic_MouseUp(object sender, MouseEventArgs e)
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
        }

        #endregion

        #region [LoginButton]

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Green;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string loginUser = LoginField.Text;
            string passwordUser = PassField.Text;

            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND pass = @up", database.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                this.Hide();
                Cutting_chart cutting_Chart = new Cutting_chart();
                cutting_Chart.Show();
            }
            else
                MessageBox.Show("Unsuccessfully");

        }

        #endregion

        #region [RegistrationLabel]

        private void RegistrationLabel_MouseEnter(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.Green;
        }

        private void RegistrationLabel_MouseLeave(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.White;
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        #endregion

        #region [ForgotPassLabel]

        private void ForgotPassLabel_MouseEnter(object sender, EventArgs e)
        {
            ForgotPassLabel.ForeColor = Color.Green;
        }

        private void ForgotPassLabel_MouseLeave(object sender, EventArgs e)
        {
            ForgotPassLabel.ForeColor = Color.White;
        }

        #endregion

    }
}
