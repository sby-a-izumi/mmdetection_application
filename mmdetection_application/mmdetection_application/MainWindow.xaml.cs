using System.Collections.ObjectModel;
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
using mmdetection_application.ViewModels;
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

            this._datavm = new DataViewModel();
            this._vm = new MainWindowViewModel();

            contentFrame.Navigate(new PageHome());
            IsActiveHome = true;
            IsActiveData = false;
            IsActiveTrain = false;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public bool IsActiveHome
        {
            get { return _vm.IsActiveHome; }
            set { _vm.IsActiveHome = value; }
        }
        public bool IsActiveData
        {
            get { return _vm.IsActiveData; }
            set { _vm.IsActiveData = value; }
        }
        public bool IsActiveTrain
        {
            get { return _vm.IsActiveTrain; }
            set { _vm.IsActiveTrain = value; }
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

        private void ClickMinimize(object sender, RoutedEventArgs e)
        {

        }

        private void ClickHome(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PageHome());

            IsActiveHome = true;
            IsActiveData = false;
            IsActiveTrain = false;
        }

        private void ClickData(object sender, RoutedEventArgs e)
        {
            var pageData = new PageData();
            pageData.DataContext = _datavm;
            contentFrame.Navigate(pageData);
            IsActiveHome = false;
            IsActiveData = true;
            IsActiveTrain = false;
        }

        private void ClickTrain(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PageTrain());
            IsActiveHome = false;
            IsActiveData = false;
            IsActiveTrain = true;
        }

        private DataViewModel _datavm;
        private MainWindowViewModel _vm;
    }
}