using OrdersApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace OrdersApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        List<Material> matList = new List<Material>();
        List<Tool> toolList = new List<Tool>();
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(List<Material> list)
        {
            matList = list;
        }

        public MainPage(List<Tool> list)
        {
            toolList = list;
        }

        async void DisplayMessage(object sender, EventArgs e)
        {
            await DisplayAlert("Информация", "Список сформирован", "OK");
        }

        private void CheckOutTools_Clicked(object sender, EventArgs e)
        {
            if(matList != null)
            {
                ExportDataToCsv.ExportCsv(matList, "Materials");
                DisplayMessage(sender, e);
            }
            if(toolList != null)
            {
                ExportDataToCsv.ExportCsv(matList, "Tools");
                DisplayMessage(sender, e);
            }
            else
            {
                Console.WriteLine("lists are empty");
            }

        }
        
        private void LogOut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}