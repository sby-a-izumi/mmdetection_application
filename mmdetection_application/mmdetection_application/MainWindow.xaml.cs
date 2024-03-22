using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mmdetection_application.UserControls;
using mmdetection_application.Views;

namespace mmdetection_application
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   

        
        public MainWindow()
        {
            InitializeComponent();
            contentFrame.Navigate(new PageHome());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        /// <summary>
        /// アプリケーションを終了するためのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void ClickHome(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PageHome());
        }

        private void ClickData(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PageData());
        }

        private void ClickTrain(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PageTrain());
        }
    }
}