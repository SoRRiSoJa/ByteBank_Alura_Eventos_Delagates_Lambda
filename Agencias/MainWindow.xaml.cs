using Agencias.Data;
using System.Linq;
using System.Windows;

namespace Agencias
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context _context = new Context();
        public MainWindow()
        {
            InitializeComponent();
            AtualizarControles();
        }

        private void AtualizarControles()
        {
            lstAgencias.Items.Clear();
            var agencias = _context.Agencia.ToList();
            foreach (var agencia in agencias)
            {
                lstAgencias.Items.Add(agencia);
            }
        }
    }
}
