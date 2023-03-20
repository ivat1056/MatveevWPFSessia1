using System.Windows;
using System.Windows.Controls;

namespace MatveevWPFSessia1.Pages
{
    /// <summary>
    /// Логика взаимодействия для UPDPage.xaml
    /// </summary>
    public partial class UPDPage : Page
    {
        public UPDPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new OrdersPage());
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
            //order.OrderStatusID = cbStatus.SelectedIndex + 1;
            //Base.ep.SaveChanges();
            //order.OrderStatusID = cbStatus.SelectedIndex + 1;
            //Base.ep.SaveChanges();

        }
    }
}
