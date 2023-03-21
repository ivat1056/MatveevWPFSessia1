using MatveevWPFSessia1.Class;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MatveevWPFSessia1.Pages
{
    /// <summary>
    /// Логика взаимодействия для UPDPage.xaml
    /// </summary>
    public partial class UPDPage : Page
    {
        Order order;
        public UPDPage(Order order)
        {
            InitializeComponent();
            this.order = order;
            dpDeliveryDate.SelectedDate = order.OrderDeliveryDate;
            cbStatus.ItemsSource = Base.ep.OrderStatus.ToList();
            cbStatus.SelectedValuePath = "OrderStatus";
            cbStatus.DisplayMemberPath = "Name";
            cbStatus.SelectedValue = order.OrderStatusID;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new OrdersPage());
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                order.OrderDeliveryDate = (DateTime)dpDeliveryDate.SelectedDate;
                order.OrderStatusID = cbStatus.SelectedIndex + 1;
                Base.ep.SaveChanges();
                MessageBox.Show("Изменение");
                FrameClass.frame.Navigate(new OrdersPage());
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }

        }
    }
}
