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
            ValidateNullField(txtNumero, EventArgs.Empty);
            ValidateOnlyNumberField(txtNumero, EventArgs.Empty);
            //--
            ValidateNullField(txtNome, EventArgs.Empty);
            ValidateNullField(txtEndereco, EventArgs.Empty);
            ValidateNullField(txtDescricao, EventArgs.Empty);
            ValidateNullField(txtTelefone, EventArgs.Empty);


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
            
            txtNumero.TextChanged += ValidateNullField;
            txtNumero.TextChanged += ValidateOnlyNumberField;
            
            txtNome.TextChanged += ValidateNullField;
            txtEndereco.TextChanged+= ValidateNullField;
            txtDescricao.TextChanged += ValidateNullField;
            txtTelefone.TextChanged+= ValidateNullField;
        }
        private void ValidateOnlyNumberField(object sender, EventArgs e) 
        {
            var txt = sender as TextBox;
            txt.Background = (txt.Text.All(char.IsDigit)) ? new SolidColorBrush(Colors.White) : txt.Background = new SolidColorBrush(Colors.OrangeRed);
        }
        private void ValidateNullField(object sender, EventArgs e) 
        {
            var txt = sender as TextBox;
            txt.Background = (String.IsNullOrEmpty(txt.Text)) ? new SolidColorBrush(Colors.OrangeRed) : txt.Background = new SolidColorBrush(Colors.White);
        }

        private void CloseWindow(object sender, RoutedEventArgs e) =>
            Close();
        
    }
}
