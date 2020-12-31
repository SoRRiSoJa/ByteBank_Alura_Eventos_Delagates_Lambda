using Agencias.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Agencias.View
{
    /// <summary>
    /// Lógica interna para EdicaoAgencias.xaml
    /// </summary>
    public partial class EdicaoAgencias : Window
    {
        private readonly Agencia _agencia;
        public EdicaoAgencias(Agencia agencia)
        {
            InitializeComponent();
            this._agencia = agencia?? throw new ArgumentNullException(nameof(agencia));
            UpdateTextFields();
            UpdateControls();

        }
        private void UpdateTextFields() 
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtDescricao.Text = _agencia.Descricao;
            txtTelefone.Text = _agencia.Telefone;
            txtEndereco.Text = _agencia.Endereco;
        }
        private void UpdateControls() 
        {
            //var salvarkEventHandler = (RoutedEventHandler) btnSalvar_Click + CloseWindow;
            //var cancelarEventHandler = (RoutedEventHandler) btnCalcelar_Click + CloseWindow;

            btnSalvar.Click += new RoutedEventHandler(CloseWindow);
            btnCalcelar.Click += new RoutedEventHandler(CloseWindow);
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)=>
            DialogResult = true;
        

        private void btnCalcelar_Click(object sender, RoutedEventArgs e)=>
            DialogResult = false;
        
        private void CloseWindow(object sender, RoutedEventArgs e) =>
            Close();
        
    }
}
