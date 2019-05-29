using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Event_Organizer
{
    class imageModel
    {
        public imageModel(string name, ImageSource imageSource)
        {
            Name = name;
            ImageSource = imageSource;
        }

        public string Name { get; set; }

        public ImageSource ImageSource { get; set; }

    }
}
