using Microsoft.Maui.Graphics.Text;
using Microsoft.UI.Xaml.Media.Animation;
using Windows.Globalization;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
         


        }

        private void Button15Percent_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void Button20Percent_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();

        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private double CalculateTip()
        {
            //Programar uma funçao que calcule
            //preciso receber o valor do pedido digitado pelo usuario
            //receber o valor da porcentagem para calcular a gorjeta 
            //realizar o calculo da gorjeta considerando o tipo

            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            double result = amount * (percent / 100);
            return result;

          

        }

        private void SliderTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelPercentageValue.Text = Math.Round(SliderTipPercent.Value).ToString();
        }
    }

}
