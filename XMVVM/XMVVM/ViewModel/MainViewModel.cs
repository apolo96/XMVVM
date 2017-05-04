using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XMVVM.Model;
using XMVVM.Services;

namespace XMVVM.ViewModel
{
    class MainViewModel: ViewModelPropertyChanged
    {

        bool isBusy = false;

        public ObservableCollection<Student> Students { get; set; }

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }

            set
            {
                isBusy = value;
                RaisePropertyChanged();
            }
        }

        public Command LoadDirectoryCommand { get; set; }


        public MainViewModel()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
           
        }


        async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);
                var loadedDirectory = StudentDirectoryService.loadStudentDirectory();
                foreach (var student in loadedDirectory.Students)
                {
                    Students.Add(student);
                }      
                IsBusy = false;
            }
        }

    }
}
