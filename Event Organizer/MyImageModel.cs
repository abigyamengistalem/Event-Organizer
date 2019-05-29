using System.Windows.Media.Imaging;

namespace Event_Organizer
{
    internal class MyImageModel
    {
        private string name;
        private BitmapImage bitmapImage;

        public MyImageModel(string name, BitmapImage bitmapImage)
        {
            this.name = name;
            this.bitmapImage = bitmapImage;
        }
    }
}