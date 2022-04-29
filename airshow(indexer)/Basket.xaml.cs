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
using System.Windows.Shapes;

namespace airshow_indexer_
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        internal Basket(createBasket create, int index)
        {
            double countPrice = 0;
            InitializeComponent();
            for(int i = 0; i < index; i++)
            {
                List<Goods> goods = new List<Goods>() { new Goods() { Name = create[i].Name, price = create[i].price } };
                AirplaneDataGrid.Items.Add(goods);
                countPrice += goods[0].price;
            }
            pushCountPrice(countPrice);
        }
        private void pushCountPrice(double a)
        {
            TextBlockBasket.Text = $"Общая ценна {a} $ ";
        }




        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
