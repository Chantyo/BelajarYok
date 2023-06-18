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
    public partial class Friends : ContentPage
    {
        private bool isAddImageButtonClicked = false;
        private string searchText = string.Empty;

        public Friends()
        {
            InitializeComponent();
        }
        private void OnSearchEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            searchText = e.NewTextValue;
            UpdateContentVisibility();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            isAddImageButtonClicked = true;
            //addButton.BackgroundColor = Color.Transparent;
            //addButton.TextColor = Color.FromHex("#bcfe2f");
            //addButton.Text = "Added";
            //friendText.Text = "Sudah di daftarkan sebagai teman";
            UpdateContentVisibility();
        }

        private void OnAddImageButtonClicked(object sender, EventArgs e)
        {
            if (searchText == "admin")
            {
                isAddImageButtonClicked = true;

                UpdateContentVisibility();
            }
        }

        private void UpdateContentVisibility()
        {
            if (searchText == "admin" && isAddImageButtonClicked)
            {
                //contentFrame.IsVisible = true;
            }
            else
            {
                //contentFrame.IsVisible = false;
            }
        }
    }
}
    
