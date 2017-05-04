using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XMVVM.ViewModel
{
    class ViewModelPropertyChanged : INotifyPropertyChanged
    {
        public void RaisePropertyChanged([CallerMemberName]string nameProperty = null)
        {
            var handle = PropertyChanged;
            if (handle != null) handle(this,new PropertyChangedEventArgs(nameProperty));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
