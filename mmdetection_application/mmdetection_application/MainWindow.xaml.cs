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
using mmdetection_application.Views;

namespace mmdetection_application
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public Page? PageData { get; set; }
        public Page? PageTrain { get; set; }
        public Page? PageTest {  get; set; }

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private static MainWindow? _Instance;
        public static MainWindow GetInstance()
        {
            if (_Instance != null)
            {
                return _Instance;
            }
            _Instance = new MainWindow();
            return _Instance;
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
            contentFrame.Navigate(typeof(PageHome));
        }

        private void ClickData(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(PageData));
        }

        private void ClickTrain(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(PageTrain));
        }
    }
}