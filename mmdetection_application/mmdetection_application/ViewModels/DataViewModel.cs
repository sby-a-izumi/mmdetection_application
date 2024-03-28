using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmdetection_application.ViewModels
{
    internal class DataViewModel : MainViewModels
    {
        private string? _nameOpenFile = "Init";
        public string? NameOpenFile
        {
            get { return this._nameOpenFile; }
            set { SetProperty(ref this._nameOpenFile, value); }
        }
    }
}
