using Agencias.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Agencias.Components
{
    public class AgenciasListBox:ListBox
    {
        private readonly MainWindow _mainWindow;
        public AgenciasListBox(MainWindow mainWindow)
        {
            _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        }
        
        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            var agenciaSelecionada = SelectedItem as Agencia;
            _mainWindow.txtNumero.Text = agenciaSelecionada.Numero;
            _mainWindow.txtNome.Text = agenciaSelecionada.Nome;
            _mainWindow.txtDescricao.Text = agenciaSelecionada.Descricao;
            _mainWindow.txtTelefone.Text = agenciaSelecionada.Telefone;
            _mainWindow.txtEndereco.Text = agenciaSelecionada.Endereco;
        }
    }
}
