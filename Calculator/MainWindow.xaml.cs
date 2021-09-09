using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainItem.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
            {
                TextLabel.Text = "";
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(TextLabel.Text, null).ToString();
                TextLabel.Text = value;
            }

            else
            {
                TextLabel.Text += str;
            }
        }
    }
}
