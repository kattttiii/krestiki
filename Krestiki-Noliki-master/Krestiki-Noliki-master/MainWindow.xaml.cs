using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _1_para
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        string xo = "😎";
        bool konec = false;
        Random rnd = new Random();

        private void Restart()
        {
            _1.Content = String.Empty;
            _1.IsEnabled = true;
            _2.Content = String.Empty;
            _2.IsEnabled = true;
            _3.Content = String.Empty;
            _3.IsEnabled = true;
            _4.Content = String.Empty;
            _4.IsEnabled = true;
            _5.Content = String.Empty;
            _5.IsEnabled = true;
            _6.Content = String.Empty;
            _6.IsEnabled = true;
            _7.Content = String.Empty;
            _7.IsEnabled = true;
            _8.Content = String.Empty;
            _8.IsEnabled = true;
            _9.Content = String.Empty;
            _9.IsEnabled = true;
            Result.Content = String.Empty;
            xo = xo == "😎" ? "😭" : "😎";
        }

        private void Stop()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }
        private void bot()
        {

            int a = rnd.Next(9);


            if (a == 0 && _1.IsEnabled == true)
            { _1.Content = xo; _1.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 1 && _2.IsEnabled == true)
            { _2.Content = xo; _2.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 2 && _3.IsEnabled == true)
            { _3.Content = xo; _3.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 3 && _4.IsEnabled == true)
            { _4.Content = xo; _4.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 4 && _5.IsEnabled == true)
            { _5.Content = xo; _5.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 5 && _6.IsEnabled == true)
            { _6.Content = xo; _6.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 6 && _7.IsEnabled == true)
            { _7.Content = xo; _7.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 7 && _8.IsEnabled == true)
            { _8.Content = xo; _8.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (a == 8 && _9.IsEnabled == true)
            { _9.Content = xo; _9.IsEnabled = false; xo = xo == "😎" ? "😭" : "😎"; }

            else if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
            { }

            else bot();
        }
        private void Pobeda() 
        {
            if (_1.Content == _2.Content && _2.Content == _3.Content && _1.IsEnabled == false == _2.IsEnabled == false && _3.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_4.Content == _5.Content && _5.Content == _6.Content && _4.IsEnabled == false == _5.IsEnabled == false && _6.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_7.Content == _8.Content && _8.Content == _9.Content && _7.IsEnabled == false == _8.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_1.Content == _4.Content && _4.Content == _7.Content && _1.IsEnabled == false == _4.IsEnabled == false && _7.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_2.Content == _5.Content && _5.Content == _8.Content && _2.IsEnabled == false == _5.IsEnabled == false && _8.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_3.Content == _6.Content && _6.Content == _9.Content && _3.IsEnabled == false == _6.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_1.Content == _5.Content && _5.Content == _9.Content && _1.IsEnabled == false == _5.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_3.Content == _5.Content && _5.Content == _7.Content && _3.IsEnabled == false == _5.IsEnabled == false && _7.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else
            {
                if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
                {
                    Result.Content = "Ничья";
                }
            }
            if (konec == true)
            {
                if (xo == "😎") { Result.Content = "Победа 😭"; }
                else Result.Content = "Победа 😎";
            }
        }
        

        private void _1_Click_1(object sender, RoutedEventArgs e)
        {
            _1.Content = xo;
            _1.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            _2.Content = xo;
            _2.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            _3.Content = xo;
            _3.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            _4.Content = xo;
            _4.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            _5.Content = xo;
            _5.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            _6.Content = xo;
            _6.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            _7.Content = xo;
            _7.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            _8.Content = xo;
            _8.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            _9.Content = xo;
            _9.IsEnabled = false;
            xo = xo == "😎" ? "😭" : "😎";
            Pobeda();
            bot();
            Pobeda();
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            konec = false;
            Restart();
            
        }
    }
}