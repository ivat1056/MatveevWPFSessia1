using MatveevWPFSessia1.Class;
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

namespace MatveevWPFSessia1.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        List<BasketClass> basket;
        Order order;
        int role;
        public OrdersPage()
        {
            InitializeComponent();
            lvListOrders.ItemsSource = Base.ep.Order.ToList();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            int index = Convert.ToInt32(btn.Uid);
            Order order = Base.ep.Order.FirstOrDefault(x => x.OrderID == index);
            FrameClass.frame.Navigate(new UPDPage(order));

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new Correct(role,basket));
        }
    }
}
