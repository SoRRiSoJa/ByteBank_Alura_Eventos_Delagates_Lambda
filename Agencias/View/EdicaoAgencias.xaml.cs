using Agencias.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            UpdateControls();
            UpdateTextFields();
            //--
            //ValidateOnlyNumberField(txtNumero, EventArgs.Empty);
            
            


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
            
            RoutedEventHandler dialogResultTrue = ( o, e)=>
                DialogResult = true;
            
            RoutedEventHandler dialogResultFalse =  ( o,  e)=>
                DialogResult = false;
            
            
            var salvarkEventHandler = dialogResultTrue + CloseWindow;
            var cancelarEventHandler = dialogResultFalse + CloseWindow;
            
            btnSalvar.Click += salvarkEventHandler;
            btnCalcelar.Click += cancelarEventHandler;
            
            txtNumero.Validacao += ValidateNullField;
            txtNumero.Validacao += ValidateOnlyNumberField;
            
            //txtNome.Validacao += ValidateNullField;
            //txtEndereco.Validacao += ValidateNullField;
            //txtDescricao.Validacao += ValidateNullField;
            //txtTelefone.Validacao += ValidateNullField;
        }
        private bool ValidateOnlyNumberField(string texto) 
        {
            return texto.All(Char.IsDigit);
        }
        private bool ValidateNullField(string texto) 
        {
            return String.IsNullOrEmpty(texto);
        }

        private void CloseWindow(object sender, RoutedEventArgs e) =>
            Close();
        
    }
}
