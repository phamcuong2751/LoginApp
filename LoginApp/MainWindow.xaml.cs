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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Data { get; set; } = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var DataUN = userName.Text;
            var DataPW = password.Password;
            if (DataUN.Length == 0 || DataPW.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai cú pháp, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(DataUN == "admin" && DataPW == "qwe3@1")
            {
                var nextPage = new DashboardWindow();
                nextPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chúc mừng, bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nextPage = new ResetPassword();
            nextPage.ShowDialog();
        }
    }
}
