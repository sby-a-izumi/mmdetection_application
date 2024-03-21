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
            DataContext = new Transition();
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
        /// データ画面に遷移するためのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickData(object sender, RoutedEventArgs e)
        {
            GetInstance().Hide();
            WindowData.GetInstance().Show();
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
    }
}