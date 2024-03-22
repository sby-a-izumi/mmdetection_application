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


        private IList<MainViewModels> _contents;
        public IList<MainViewModels> Contents
        {
            get { return _contents ?? (_contents = CreateContents().ToArray()); }
        }

        private IEnumerable<MainViewModels> CreateContents()
        {
            yield return new HomeViewModel();
            yield return new DataViewModel();
            yield return new TrainViewModel();
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
        public HomeViewModel HomeViewModel { get { return Contents.First() as HomeViewModel; } }   
    }

    
}
