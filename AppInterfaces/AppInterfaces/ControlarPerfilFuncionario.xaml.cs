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
using AppInterfaces.Models;
//using Mysql.Data.MysqlClient;

namespace AppInterfaces
{
    /// <summary>
    /// Lógica interna para ControlarPerfilFuncionario.xaml
    /// </summary>
    public partial class ControlarPerfilFuncionario : Window
    {
        private Perfil perfil;
        private List<Perfil> perfilList;
        public ControlarPerfilFuncionario()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            perfil = new Perfil();
            perfilList = new List<Perfil>();
            /*txtNome.Text = _perfil.Nome;
            txtCpf.Text = _perfil.Cpf;
            txtContato.Text = _perfil.Telefone;
            txtRg.Text = _perfil.Rg;
            txtEmail.Text = _perfil.Email;
            txtFuncao.Text = _perfil.Funcao;
            txtSetor.Text = _perfil.Setor;*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome, cpf, contato, rg, email, funcao, setor;

            perfil.Nome = txtNome.Text;
            cpf = txtCpf.Text;
            contato = txtContato.Text;
            rg = txtRg.Text;
            email = txtEmail.Text;
            funcao = txtFuncao.Text;
            setor = txtSetor.Text;

            MessageBox.Show($"Nome: {perfil.Nome}\n" +
               $"CPF: {cpf}\n" +
               $"Contato: {contato}\n" +
               $"Rg: {rg}\n" +
               $"E-mail: {email}\n" +
               $"Função: {funcao}\n" +
               $"Setor: {setor}\n" , "Informações", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtContato.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
            txtFuncao.Text = "";
            txtSetor.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente sair?", "App - Controle Acesso Perfil do Funcionário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        


    }
    }

