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

namespace mmdetection_application
{
    /// <summary>
    /// WindowData.xaml の相互作用ロジック
    /// </summary>
    public partial class WindowData : Window
    {
        public WindowData()
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
        private static WindowData? _Instance;
        public static WindowData GetInstance()
        {
            if (_Instance != null)
            {
                return _Instance;
            }
            _Instance = new WindowData();
            return _Instance;
        }

        private void ClickHome(object sender, RoutedEventArgs e)
        {
            GetInstance().Hide();
            MainWindow.GetInstance().Show();
        }

    }
}
