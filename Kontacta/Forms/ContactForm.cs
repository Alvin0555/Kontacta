using Kontacta.Forms;
using Kontacta.Interfaces;
using Kontacta.Services;

namespace Kontacta
{
    public partial class ContactForm : Form
    {
        private readonly IAuthService _authService;
        public ContactForm()
        {
            InitializeComponent();
            IUserRepository userRepository = new InMemoryUserRepository();
            _authService = new AuthService(userRepository);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
