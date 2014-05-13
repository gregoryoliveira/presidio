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
using MahApps.Metro.Controls;
using Prototipo_Presidio.Regra_de_Negocio;

namespace Prototipo_Presidio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CadastroPresidiario : MetroWindow
    {
        IniciaTextCadastroPresidiario iniciadorDeText = new IniciaTextCadastroPresidiario();

        public CadastroPresidiario()
        {
            InitializeComponent();
        }

        public String limpaText(TextBox t) 
        {
            return "";
        }

        private void txtMatricula_GotFocus(object sender, RoutedEventArgs e)
        {
            txtMatricula.Text = limpaText(txtMatricula);
        }

        private void txtMatricula_LostFocus(object sender, RoutedEventArgs e)
        {
            txtMatricula.Text = iniciadorDeText.Matricula;
        }

        private void txtNome_GotFocus(object sender, RoutedEventArgs e)
        {
            txtNome.Text = limpaText(txtNome);
        }

        private void txtNome_LostFocus(object sender, RoutedEventArgs e)
        {
            txtNome.Text = iniciadorDeText.Nome;
        }
    }
}
