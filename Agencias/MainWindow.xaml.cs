using Agencias.Components;
using Agencias.Data;
using Agencias.Model;
using Agencias.View;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Agencias
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context _context = new Context();
        private readonly ListBox lstAgencias;
        public MainWindow()
        {
            this.lstAgencias = new ListBox();
            InitializeComponent();
            AtualizarControles();
        }

        private void AtualizarControles()
        {
            lstAgencias.SelectionChanged += new SelectionChangedEventHandler(lstAgencias_SelectionChanged);
            lstAgencias.Width = 380;
            lstAgencias.Height = 380;
            Canvas.SetTop(lstAgencias, 15);
            Canvas.SetLeft(lstAgencias, 15);

            container.Children.Add(lstAgencias);
            LoadAndUpdateList();
        }

        private void LoadAndUpdateList()
        {
            lstAgencias.Items.Clear();
            var agencias = _context.Agencia.ToList();
            foreach (var agencia in agencias)
            {
                lstAgencias.Items.Add(agencia);
            }
        }

        private void lstAgencias_SelectionChanged(object sender, RoutedEventArgs e) 
        {
            var agenciaSelecionada = lstAgencias.SelectedItem as Agencia;
            txtNumero.Text = agenciaSelecionada.Numero;
            txtNome.Text = agenciaSelecionada.Nome;
            txtDescricao.Text = agenciaSelecionada.Descricao;
            txtTelefone.Text = agenciaSelecionada.Telefone;
            txtEndereco.Text = agenciaSelecionada.Endereco;
        }
        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            var confirmacao=MessageBox.Show("Você deseja realmente excluir essa buceta?","Confirmação",MessageBoxButton.YesNo);
            if (confirmacao == MessageBoxResult.Yes)
            {

            }
            else 
            { 
            
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Agencia agenciaSelecionada = lstAgencias.SelectedItem as Agencia;
            if (!(agenciaSelecionada is null))
            {
                var wpfForm = new EdicaoAgencias(agenciaSelecionada);
                var result=wpfForm.ShowDialog().Value;
                if (result)
                {
                    //Clicou em salvar
                }
                else 
                { 
                    //Clicou cnacelar
                }
            }
        }

        private void btnEditar_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
