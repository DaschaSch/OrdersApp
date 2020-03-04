using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using OrdersApp.Models;
using OrdersApp.Views;
using OrdersApp.ViewModels;

namespace OrdersApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolPage : ContentPage
    {
        ToolViewModel viewModel;
        public List<Tool> ToolsList;
        public List<Tool> AddedTools = new List<Tool>();
        public ToolPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ToolViewModel();

            ToolsList = viewModel.Tools;
        }


        async void DisplayMessage(object sender, EventArgs e)
        {
            await DisplayAlert("Информация", "Инструмент добавлен", "OK");
        }

        private void AddItem(object sender, EventArgs e)
        {
            Tool material = toolsList.SelectedItem as Tool;
            AddedTools.Add(material);
            MainPage mainPage = new MainPage(AddedTools);
            DisplayMessage(sender, e);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                toolsList.ItemsSource = ToolsList;
            }

            else
            {
                toolsList.ItemsSource = ToolsList.Where(x => x.Name.StartsWith(e.NewTextValue));
            }
        }

    }
}
