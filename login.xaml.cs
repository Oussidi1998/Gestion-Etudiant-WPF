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

namespace WPF_APP
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(loginInput.Text=="admin" && passInput.Password == "123456")
            {
                dash app = new dash(loginInput.Text);
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalide Mot passe ou login", "Auth Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
