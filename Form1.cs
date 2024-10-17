using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }


        private bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$"; // Regular Expression cho mật khẩu hợp lệ
            return Regex.IsMatch(password, passwordPattern);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

 
            if (IsValidEmail(email) && IsValidPassword(password))
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không hợp lệ! " +
                    "Email phải đúng định dạng, mật khẩu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.",
                    "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





    }
}
