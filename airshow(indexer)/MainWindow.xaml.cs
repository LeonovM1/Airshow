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
using System.IO;

namespace airshow_indexer_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 0;
        createBasket create = new createBasket();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        ///1-st Airplane
        private void SpecBtn_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\airshow(indexer)\airshow(indexer)\Boeing747-400.txt"));
        }

        private void AddBtn_Click1(object sender, RoutedEventArgs e)
        {
            
            if (index < 5)
            {
                create[index] = new Goods { Name = "Boeing747-400", price = 234000000 };
                index++;
            }
            else
            {
                MessageBox.Show("Корзина полная! Перейдите в неё.");
            }
        }

        ///2-nd Airplane
        private void SpecBtn_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\airshow(indexer)\airshow(indexer)\Boeing777-9.txt"));
        }

        private void AddBtn_Click2(object sender, RoutedEventArgs e)
        {
            if (index < 5)
            {
                create[index] = new Goods { Name = "Boeing777-9", price = 442200000 };
                index++;
            }
            else
            {
                MessageBox.Show("Корзина полная! Перейдите в неё.");
            }
        }

        ///3-rd Airplane

        private void SpecBtn_Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\airshow(indexer)\airshow(indexer)\Airbus-A380.txt"));
        }

        private void AddBtn_Click3(object sender, RoutedEventArgs e)
        {
            if (index < 5)
            {
                create[index] = new Goods { Name = "Airbus-A380", price = 333517500 };
                index++;
            }
            else
            {
                MessageBox.Show("Корзина полная! Перейдите в неё.");
            }
        }

        ///4-th Airplane
        private void SpecBtn_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\airshow(indexer)\airshow(indexer)\Superjet-100.txt"));
        }

        private void AddBtn_Click4(object sender, RoutedEventArgs e)
        {
            if (index < 5)
            {
                create[index] = new Goods { Name = "Sukhoi Superjet-100", price = 32000000 };
                index++;
            }
            else
            {
                MessageBox.Show("Корзина полная! Перейдите в неё.");
            }
        }

        ///5-th Airplane
        private void SpecBtn_Click5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\airshow(indexer)\airshow(indexer)\Boeing737-max-10.txt"));
        }

        private void AddBtn_Click5(object sender, RoutedEventArgs e)
        {
            if (index < 5)
            {
                create[index] = new Goods { Name = "Boeing737 MAX 10", price = 129900000 };
                index++;
            }
            else
            {
                MessageBox.Show("Корзина полная! Перейдите в неё.");
            }
        }

        /// Busket button
        private void Basket_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Basket basket = new Basket(create, index);
            basket.Show();
            Application.Current.MainWindow.Close();
        }

    }
}
