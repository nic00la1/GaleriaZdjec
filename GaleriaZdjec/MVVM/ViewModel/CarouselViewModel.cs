using GaleriaZdjec.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaZdjec.MVVM.ViewModel
{
    public class CarouselViewModel
    {
        public List<ImageModel> Images { get; set; }

        public CarouselViewModel()
        {
            Images = new List<ImageModel>
            {
                new ImageModel { Source = "kot1.jpg"},
                new ImageModel { Source = "kot2.jpg"},
                new ImageModel { Source = "kot3.jpg"},
                new ImageModel { Source = "kot4.jpg"}
            };
        }
    }
}
