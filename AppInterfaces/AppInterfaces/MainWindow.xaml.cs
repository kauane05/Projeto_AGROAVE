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


namespace AppInterfaces
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCadastrarCliente(object sender, RoutedEventArgs e)
        {
            CadastrarCliente form = new CadastrarCliente();
            form.ShowDialog();
        }

        private void btCadastrarEstoqueClick(object sender, RoutedEventArgs e)
        {
            CadastrarEstoqueProducao form = new CadastrarEstoqueProducao();
            form.ShowDialog();
        }

        private void btControlarAcesso_Click(object sender, RoutedEventArgs e)
        {
            ControlarPerfilFuncionario form = new ControlarPerfilFuncionario();
            form.ShowDialog();
        }

        private void btCadastrarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFornecedor1 form = new CadastrarFornecedor1();
            form.ShowDialog();  
        }
    }
}
