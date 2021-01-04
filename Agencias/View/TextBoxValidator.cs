using System.Windows.Controls;
using System.Windows.Media;

namespace Agencias.View
{
    public delegate bool ValidacaoEventHandler(string texto);
    public class TextBoxValidator:TextBox
    {
        public event  ValidacaoEventHandler Validacao;

        public TextBoxValidator() 
        {
            TextChanged += TextBoxValidator_TextChanged;
        }

        private void TextBoxValidator_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(Validacao is null))
            {
                var isValid = Validacao(Text);
                Background = isValid ? new SolidColorBrush(Colors.White) : new SolidColorBrush(Colors.OrangeRed);
            }
        }
    }
}
