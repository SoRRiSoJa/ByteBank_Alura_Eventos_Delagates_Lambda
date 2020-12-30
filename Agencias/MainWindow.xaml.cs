using Agencias.Components;
using Agencias.Data;
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
        private readonly AgenciasListBox lstAgencias;
        public MainWindow()
        {
            this.lstAgencias = new AgenciasListBox(this);
            InitializeComponent();
            AtualizarControles();
        }

        private void AtualizarControles()
        {
            lstAgencias.Width = 380;
            lstAgencias.Height = 380;
            Canvas.SetTop (lstAgencias, 15);
            Canvas.SetLeft (lstAgencias, 15);

            container.Children.Add(lstAgencias);
            lstAgencias.Items.Clear();
            var agencias = _context.Agencia.ToList();
            foreach (var agencia in agencias)
            {
                lstAgencias.Items.Add(agencia);
            }
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
    }
}
