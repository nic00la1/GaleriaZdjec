using GaleriaZdjec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaZdjec.ViewModel
{
    public class CarouselViewModel
    {
        public List<ImageModel> Images { get; set; }

        public CarouselViewModel()
        {
            Images = new List<ImageModel>
            {
                new ImageModel { Image = ""},
                new ImageModel { Image = ""},
                new ImageModel { Image = ""},
                new ImageModel { Image = ""}

            };
        }
    }
}
