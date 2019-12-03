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

namespace WPF_APP
{
    /// <summary>
    /// Logique d'interaction pour dash.xaml
    /// </summary>
    public partial class dash : Window
    {
        string username;
        public dash(String user)
        {
            InitializeComponent();
            userLogged.Content = user;
        }


    }
}
