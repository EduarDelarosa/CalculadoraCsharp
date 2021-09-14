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

namespace PrimeraCalculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double primero;
        public double segundo;
        string operador;

        public MainWindow()
        {
            InitializeComponent();
        }

        Clases.SumaCls sum = new Clases.SumaCls();
        Clases.RestaCls rest = new Clases.RestaCls();
        Clases.MultipliCls multipl = new Clases.MultipliCls();
        Clases.DivisionCls divi = new Clases.DivisionCls();

        private void btnN0_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "0";
        }

        private void btnN1_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "1";
        }

        private void btnN2_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "2";
        }

        private void btnN3_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "3";
        }

        private void btnN4_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "4";
        }

        private void btnN5_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "5";
        }

        private void btnN6_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "6";
        }

        private void btnN7_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "7";
        }

        private void btnN8_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "8";
        }

        private void btnN9_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + "9";
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = tbx1.Text + ".";
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbx2.Clear();
                operador = "+";
                primero = double.Parse(tbx1.Text);
                tbx2.Text = tbx2.Text + primero + operador;
                tbx1.Clear();

            } catch (Exception ex)
            {

            }
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbx2.Clear();
                operador = "-";
                primero = double.Parse(tbx1.Text);
                tbx2.Text = tbx2.Text + primero + operador;
                tbx1.Clear();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbx2.Clear();
                operador = "x";
                primero = double.Parse(tbx1.Text);
                tbx2.Text = tbx2.Text + primero + operador;
                tbx1.Clear();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEntre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbx2.Clear();
                operador = "/";
                primero = double.Parse(tbx1.Text);
                tbx2.Text = tbx2.Text + primero + operador;
                tbx1.Clear();
            }
            catch(Exception ex)
            {

            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbx2.Clear();
                tbx2.Text = tbx2.Text + primero + operador;
                segundo = double.Parse(tbx1.Text);
                tbx2.Text = tbx2.Text + segundo + "=";

                double summ, restt, multt, divv;

                switch (operador)
                {
                    case "+":
                        summ = sum.Sumar((primero), (segundo));
                        tbx1.Text = summ.ToString();
                        break;
                    case "-":
                        restt = rest.Restar((primero), (segundo));
                        tbx1.Text = restt.ToString();
                        break;
                    case "x":
                        multt = multipl.Multiplicar((primero), (segundo));
                        tbx1.Text = multt.ToString();
                        break;
                    case "/":
                        divv = divi.Dividir((primero), (segundo));
                        tbx1.Text = divv.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Clear();
            tbx2.Clear();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
                if (tbx1.Text.Length == 1)
                    tbx1.Text = "";
                else
                    tbx1.Text = tbx1.Text.Substring(0, tbx1.Text.Length - 1);

            }
            catch(Exception ex)
            {

            }
        }

    }
}
