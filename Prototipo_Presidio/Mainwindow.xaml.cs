using MahApps.Metro.Controls;
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

namespace Prototipo_Presidio
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cadPresidiarioBtn_Click(object sender, RoutedEventArgs e)
        {
            CadastroPresidiario cad = new CadastroPresidiario();
            cad.Show();
        }

        private void cadFuncionarioBtn_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionario cad = new CadastroFuncionario();
            cad.Show();
        }

        private void fichaPresidiarioBtn_Click(object sender, RoutedEventArgs e)
        {
            CadastroFichaPresidiario cad = new CadastroFichaPresidiario();
            cad.Show();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }


    }
}
