using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMVVM.Model;
using XMVVM.ViewModel;

namespace XMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            lvStudents.ItemSelected += lvStudentsItemSelected;

        }

        private void lvStudentsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if (selectedStudent == null) return;
            Navigation.PushAsync(new StudentDetail(selectedStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
