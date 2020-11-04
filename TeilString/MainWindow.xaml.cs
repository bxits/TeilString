using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeilString
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, RoutedEventArgs e)
        {
            string textAusTextBox = txtEingabe.Text;

            //Zeichenkette (String) zerlegen anhand des Zeichens ','.
            //Es wird ein sog. Array zurückgegeben.
            string[] stringTeile = textAusTextBox.Split(',');

            //Auf die einzelnen Elemente in stringTeile zugreifen.
            lblAusgabe.Content = stringTeile[0] + " ---" + stringTeile[1] + "---" + stringTeile[2];
        }
    }
}
