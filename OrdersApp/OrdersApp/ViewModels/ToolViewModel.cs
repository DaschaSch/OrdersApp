using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using OrdersApp.Models;
using OrdersApp.Views;
using System.Collections.Generic;
namespace OrdersApp.ViewModels
{
    public class ToolViewModel : BaseViewModel
    {
        public List<Tool> Tools { get; set; }
        public Command LoadMatCommand { get; set; }

        public ToolViewModel()
        {
            Title = "Order App";
            Tools = new List<Tool>
            {
                new Tool {Name = "Test Pencil", AdditionalInformation = "Test pencil info", Category = "Test Tools"},
                new Tool {Name = "Network Cable Tester", AdditionalInformation = "Network Cable Tester info", Category = "Test Tools"},
                new Tool {Name = "SL2 Screwdriver", AdditionalInformation = "SL2 Screwdriver info", Category = "Screwdrivers"},
                new Tool {Name = "Simple Wire Cutter", AdditionalInformation = "Simple Wire Cutter info", Category = "Cutters"}
            };
        }
    }
}

