using System;
using System.Text;
using System.Windows;

namespace DecToHexConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long dec = 0;
            bool isNumeric = int.TryParse(DecimalInput.Text, out int n);
            if (isNumeric == true)
            {
                dec = Int64.Parse(DecimalInput.Text);

                if (dec >= 0 && dec <= 999999999)
                {
                    string hexValue = dec.ToString("X");
                    StringBuilder hex = new StringBuilder(hexValue);
                    for (int i = 0; i < 4 - (hex.Length); i++)
                    {
                        hex = hex.Insert(0, '0');
                    }
                    hex = hex.Insert(0, 'P');
                    HexadecimalOutput.Text = hex.ToString();
                    Clipboard.SetText(hex.ToString());
                }
                else
                {
                    HexadecimalOutput.Text = "Error";
                }
            }
            else
            {
                HexadecimalOutput.Text = "Error";
            }
        }
    }
}
