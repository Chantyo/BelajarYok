using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)//ToDoList
        {
            Navigation.PushAsync(new BelajarYok.View.AddFolder.AddToDoList());
        }

        private void Button_Clicked_1(object sender, EventArgs e)//Tasks
        {
            DisplayAlert("halo", "ini Tasks", "ok");
        }

        private void Button_Clicked_2(object sender, EventArgs e)//event
        {
            DisplayAlert("oi", "ini event", "ok");
        }
    }
}