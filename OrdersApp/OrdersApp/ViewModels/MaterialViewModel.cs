using System.Threading.Tasks;

using Xamarin.Forms;

using OrdersApp.Models;
using OrdersApp.Views;
using System.Collections.Generic;

namespace OrdersApp.ViewModels
{
   public class MaterialViewModel : BaseViewModel
    {
        public List<Material> Materials { get; set; }
        public Command LoadMatCommand { get; set; }

        public MaterialViewModel()
        {
            Title = "Order App";
            Materials = new List<Material>
            {
                new Material {Name = "Alarm Cable", AdditionalInformation = "Alarm Cable info", Category = "Cables"},
                new Material {Name = "Fiber Cable", AdditionalInformation = "Fiber Cable info", Category = "Cables"},
                new Material {Name = "PCM Cable", AdditionalInformation = "PCM Cable info", Category = "Cables"},
                new Material {Name = "Cat 5 Coiled Cable", AdditionalInformation = "Cat 5 Coiled Cable info", Category = "Coiled Cables" },
                new Material {Name = "Cat 6 Coiled Cable", AdditionalInformation = "Cat 6 Coiled Cable info", Category = "Coiled Cables"}
            };
        }

    }
}
