using Kontacta.Interfaces;
using Kontacta.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kontacta.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            IUserRepository userRepository = new InMemoryUserRepository();
            _authService = new AuthService(userRepository);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var success = _authService.Login(txtUsername.Text, txtPassword.Text);
            if (!success)
            {
                MessageBox.Show("Incorrect username or password");
                txtPassword.Text = string.Empty;
                return;
            }

            this.Hide();
            new ContactForm().ShowDialog();
        }
    }
}
