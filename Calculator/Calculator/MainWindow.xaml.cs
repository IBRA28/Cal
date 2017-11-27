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
using MahApps.Metro.Controls;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Очистка по символьно из Textbox
        }

        private void change_system_button_Click(object sender, RoutedEventArgs e)
        {
            switch (change_system_button.Content.ToString())
            {
                case "2":
                    change_system_button.Content = "10";
                    break;
                case "10":
                    change_system_button.Content = "16";
                    break;
                case "16":
                    change_system_button.Content = "2";
                    break;
            }
        }

      

    }
}
