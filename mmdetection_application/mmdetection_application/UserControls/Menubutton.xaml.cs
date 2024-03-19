using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.IconPacks;

namespace mmdetection_application.UserControls
{
    /// <summary>
    /// Menubutton.xaml の相互作用ロジック
    /// </summary>
    public partial class Menubutton : UserControl
    {
        public Menubutton()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Iconプロパティの設定
        /// </summary>
        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind) GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(Menubutton));

        /// <summary>
        /// IsActiveプロパティの設定
        /// </summary>
        public bool IsActive
        {
            get { return (bool) GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(Menubutton));

        /// <summary>
        /// Clickプロパティの設定
        /// </summary>
        public string Click
        {
            get { return (string)GetValue(ClickProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.Register("Click", typeof(string), typeof(Menubutton));
    }
}
