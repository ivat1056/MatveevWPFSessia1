using MatveevWPFSessia1.Class;
using MatveevWPFSessia1.Pages;
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

namespace MatveevWPFSessia1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool c = false;
        int k = 0;
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.frame = frame;
            FrameClass.frame.Navigate(new MainPage(c,k));
            Base.ep = new EP();
        }
    }
}
