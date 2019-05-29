using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Event_Organizer
{
    /// <summary>
    /// Interaction logic for ViewSponsers.xaml
    /// </summary>
    public partial class ViewSponsers : UserControl
    {
        public ViewSponsers()
        {
            InitializeComponent();
            this.sponserGrid.ItemsSource = DatabaseS.getSponsers().AsDataView();
        }
    }
}
