using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0) 
            {
                MessageBox.Show("Нельзя осталвять поля пустыми!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if(LoginTextBox.Text.Equals("admin") && PasswordTextBox.Text.Equals("1234"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            } 
            else
            {
                MessageBox.Show("Не верный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
