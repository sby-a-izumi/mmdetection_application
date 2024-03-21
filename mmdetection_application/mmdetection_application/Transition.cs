using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmdetection_application
{
    using ViewModels;
    public class Transition:MainViewModels
    {
        public Transition()
        {
            HomeViewModel = new HomeViewModel();
            ActiveContent = HomeViewModel;
        }
        private MainViewModels? _activeContent;
        public MainViewModels? ActiveContent
        {
            get { return _activeContent; }
            set
            {
                if (_activeContent != value)
                {
                    _activeContent = value;
                    RaisePropertyChanged(nameof(ActiveContent));
                }
            }
        }
        HomeViewModel? _homeViewModel;
        public HomeViewModel? HomeViewModel
        {
            get { return _homeViewModel; }
            set
            {
                if (_homeViewModel != value)
                {
                    _homeViewModel = value;
                    RaisePropertyChanged(nameof(HomeViewModel));
                }
            }
        }
    }

    
}
