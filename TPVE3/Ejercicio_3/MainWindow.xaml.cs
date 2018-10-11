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

namespace Ejercicio_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //variables que necesito
            String value = lado.Text;
            System.Diagnostics.Debug.WriteLine(value);

            if (value.Equals(""))
            {
                MessageBox.Show("El campo esta vacio");
            } else {
                double myNum = 0;
                if (Double.TryParse(value, out myNum))
                {
                    // it is a number
                    double areaNum = myNum * myNum;
                    double perimeterNum = myNum * 4;
                    area.Text = areaNum.ToString();
                    perimeter.Text = perimeterNum.ToString();
                }
                else
                {
                    MessageBox.Show("Debes ingresar un numero");
                }
            }
        }
    }
}
