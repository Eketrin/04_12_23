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

namespace _04_12_23
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DoResult_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<int, int> sortirovka = new Dictionary<int, int>();
            foreach (var item in List.Items)
            {
                sortirovka[item.ToString().Length] = +1;
            }
            int len = -1;
            int chast = 200;
            foreach (var item in sortirovka)
            {
                if (item.Value < chast && item.Key > len)
                {
                    len = item.Key;
                    chast = item.Value;
                }
            }
            Result.Text = len.ToString() + " " + chast.ToString();
        }

        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            string text = Input.Text;
            if (text != "")
            {
                List.Items.Add(text);
            }
        }
    }
}
