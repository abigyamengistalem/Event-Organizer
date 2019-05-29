using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Event_Organizer
{
    class MainViewModel
    {
        public void LoadImages()
        {
            var d = new DirectoryInfo("assets/images");
            var images = d.GetFiles();
            MyImages = images.Select(x => new MyImageModel(x.Name, new BitmapImage(new Uri(x.FullName))));
        }

        public IEnumerable<MyImageModel> MyImages { get; set; }

    }
}
