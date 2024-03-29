﻿using MySql.Data.MySqlClient;
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

            if (PassField2.UseSystemPasswordChar)
            {
                PassField2.ForeColor = Color.Red;
            }
        }

        private void ShowPassPic_MouseLeave(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
                PassField.ForeColor = Color.Gray;
            else
                PassField.ForeColor = Color.Black;

            if (PassField2.Text == "Повторите пароль")
                PassField2.ForeColor = Color.Gray;
            else
                PassField2.ForeColor = Color.Black;
        }

        private void ShowPassPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (PassField.UseSystemPasswordChar != PassField2.UseSystemPasswordChar)
            {
                if (PassField.Text != "Пароль" || PassField.Text != "")
                {
                    if (PassField2.Text != "Повторите пароль" || PassField2.Text != "")
                    {
                        PassField.UseSystemPasswordChar = true;
                        PassField2.UseSystemPasswordChar = true;
                    }
                }
            }

            if (PassField.UseSystemPasswordChar)
            {
                PassField.UseSystemPasswordChar = false;
            }
            else if (!PassField.UseSystemPasswordChar)
            {
                if (PassField.Text == "Пароль" || PassField.Text == "")
                {
                    PassField.UseSystemPasswordChar = false;
                }
                else
                {
                    PassField.UseSystemPasswordChar = true;

                }
            }


            if (PassField2.UseSystemPasswordChar)
            {
                PassField2.UseSystemPasswordChar = false;
            }
            else if (!PassField2.UseSystemPasswordChar)
            {
                if (PassField2.Text == "Повторите пароль" || PassField2.Text == "")
                {
                    PassField2.UseSystemPasswordChar = false;
                }
                else
                {
                    PassField2.UseSystemPasswordChar = true;

                }
            }
        }

        private void ShowPassPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (PassField.UseSystemPasswordChar != PassField2.UseSystemPasswordChar)
            {
                if (PassField.Text != "Пароль" || PassField.Text != "")
                {
                    if (PassField2.Text != "Повторите пароль" || PassField2.Text != "")
                    {
                        PassField.UseSystemPasswordChar = true;
                        PassField2.UseSystemPasswordChar = true;
                    }
                }
            }

            if (PassField.UseSystemPasswordChar)
            {
                PassField.UseSystemPasswordChar = false;
            }
            else if (!PassField.UseSystemPasswordChar)
            {
                if (PassField.Text == "Пароль" || PassField.Text == "")
                {
                    PassField.UseSystemPasswordChar = false;
                }
                else
                {
                    PassField.UseSystemPasswordChar = true;

                }
            }


            if (PassField2.UseSystemPasswordChar)
            {
                PassField2.UseSystemPasswordChar = false;
            }
            else if (!PassField2.UseSystemPasswordChar)
            {
                if (PassField2.Text == "Повторите пароль" || PassField2.Text == "")
                {
                    PassField2.UseSystemPasswordChar = false;
                }
                else
                {
                    PassField2.UseSystemPasswordChar = true;

                }
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
            else
            {
                NameField.Text = char.ToUpper(NameField.Text[0]) + NameField.Text.Substring(1);
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
            else
            {
                SurnameField.Text = char.ToUpper(SurnameField.Text[0]) + SurnameField.Text.Substring(1);
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
            if (PassField.Text == PassField2.Text)
                PasswordOK.Visible = true;
            else
                PasswordOK.Visible = false;
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
            if (PassField.Text == PassField2.Text)
                PasswordOK.Visible = true;
            else
                PasswordOK.Visible = false;
        }

        #endregion

        #region [Is Valid Input ???]
        public bool IsValidLogin()
        {
            if (LoginField.Text != "Логин")
            {
                string loginUser = LoginField.Text;

                DataBase database = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul", database.GetConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Логин занят");
                    return false;
                }
            }
            else
            {
                LoginField.ForeColor = Color.Red;
                return false;
            }

        }

        //public bool IsValidPhone()
        //{
        //    return false;
        //}

        //public bool IsValidPassword()
        //{
        //    return false;
        //}

        public bool IsValidInput()
        {
            if (NameField.Text == "Имя")
            {
                NameField.ForeColor = Color.Red;
                return false;
            }

            else if (SurnameField.Text == "Фамилия")
            {
                SurnameField.ForeColor = Color.Red;
                return false;
            }

            else if (PhoneField.Text == "Телефон")
            {
                PhoneField.ForeColor = Color.Red;
                return false;
            }

            else if (!IsValidLogin())
            {
                return false;
            }

            else if (PassField.Text != PassField2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            else
            {
                return true;
            }
        }
        #endregion

        #region [RegistrationButton]

        private void RegistrationButton_MouseEnter(object sender, EventArgs e)
        {
            RegistrationButton.ForeColor = Color.Green;
        }


        private void RegistrationButton_MouseLeave(object sender, EventArgs e)
        {
            RegistrationButton.ForeColor = Color.White;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `phone`, `login`, `pass`) VALUES(@name, @surname, @phone, @login, @pass)", db.GetConnection());


                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameField.Text;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("+++");
                else
                    MessageBox.Show("---");

                db.CloseConnection();
            }
        }
        #endregion

        #region [GoToAuthorizationButton]
        private void GoToAuthorizationButton_MouseEnter(object sender, EventArgs e)
        {
            GoToAuthorizationButton.ForeColor = Color.Green;
        }

        private void GoToAuthorizationButton_MouseLeave(object sender, EventArgs e)
        {
            GoToAuthorizationButton.ForeColor = Color.White;
        }

        private void GoToAuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }
        #endregion
    }
}
