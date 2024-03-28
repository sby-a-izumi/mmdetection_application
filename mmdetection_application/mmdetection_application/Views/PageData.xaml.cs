using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
using mmdetection_application.ViewModels;

namespace mmdetection_application.Views
{
    /// <summary>
    /// PageData.xaml の相互作用ロジック
    /// </summary>
    public partial class PageData : Page
    {
        public PageData()
        {
            InitializeComponent();
            _vm = new DataViewModel();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var file_dlg = new OpenFileDialog();

            file_dlg.Filter = "アノテーションファイル (*.json)|*.json";

            if (file_dlg.ShowDialog() == true)
            {
                MessageBox.Show(file_dlg.FileName);
            }

            _vm.NameOpenFile = file_dlg.FileName;
        }

        DataViewModel _vm;
    }
}
