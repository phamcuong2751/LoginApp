using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Window
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPasswordClick(object sender, RoutedEventArgs e)
        {
            var oldpass = "qwe3@1";
            if (oldPassword.Password.Length == 0 || confirmPass.Password.Length == 0 || newPassword.Password.Length == 0)
            {
                MessageBox.Show("Lỗi cú pháp, ô đăng nhập không được để trống!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (oldPassword.Password != oldpass)
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng, vui lòng kiểm tra lại!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (confirmPass.Password != newPassword.Password)
            {
                MessageBox.Show("Xác nhận mật khẩu mới thất bại, vui lòng kiểm tra lại!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {               
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Chúc Mừng!", MessageBoxButton.OK, MessageBoxImage.Information);
                oldPassword.Clear();
                newPassword.Clear();
                confirmPass.Clear();
            }
        }
    }
}
