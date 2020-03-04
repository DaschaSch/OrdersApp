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
    public partial class MaterialPage : ContentPage
    {
        MaterialViewModel viewModel;
        public List<Material> MaterialsList;
        public List<Material> AddedMaterials = new List<Material>();

        public MaterialPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MaterialViewModel();

            MaterialsList = viewModel.Materials;

            #region Item Template
            //ListView listView = new ListView
            //{
            //    HasUnevenRows = true,
            //    // Определяем источник данных
            //    ItemsSource = viewModel.Materials,

            //    // Определяем формат отображения данных
            //    ItemTemplate = new DataTemplate(() =>
            //    {
            //        // привязка к свойствам
            //        Label nameLabel = new Label { FontSize = 18 };
            //        nameLabel.SetBinding(Label.TextProperty, "Name");

            //        Label additionalInfoLabel = new Label();
            //        additionalInfoLabel.SetBinding(Label.TextProperty, "AdditionalInformation");

            //        Label categoryLabel = new Label();
            //        categoryLabel.SetBinding(Label.TextProperty, "Category");

            //        // создаем объект ViewCell.
            //        return new ViewCell
            //        {
            //            View = new StackLayout
            //            {
            //                Padding = new Thickness(0, 5),
            //                Orientation = StackOrientation.Vertical,
            //                Children = { nameLabel, additionalInfoLabel, categoryLabel }
            //            }
            //        };
            //    })
            //};
            //Button addButton = new Button;
            //this.Content = new StackLayout { Children = { listView } };
            #endregion

        }

        //protected override void OnAppearing()
        //{
        //    materialsList.ItemsSource = App.Database.GetItems();
        //    base.OnAppearing();
        //}

        async void DisplayMessage(object sender, EventArgs e)
        {
            await DisplayAlert("Информация", "Материал добавлен", "OK");
        }

        private void AddItem(object sender, EventArgs e)
        {
            Material material = materialsList.SelectedItem as Material;
            AddedMaterials.Add(material);
            MainPage mainPage = new MainPage(AddedMaterials);
            DisplayMessage(sender, e);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                materialsList.ItemsSource = MaterialsList;
            }

            else
            {
                materialsList.ItemsSource = MaterialsList.Where(x => x.Name.StartsWith(e.NewTextValue));
            }
        }
    }
}