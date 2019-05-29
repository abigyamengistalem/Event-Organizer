using System;
using System.Collections.Generic;
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
    /// Interaction logic for ForJudges.xaml
    /// </summary>
    public partial class ForJudges : UserControl
    {
        public ForJudges()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            judgeGrid.Children.Clear();
            judgeGrid.Children.Add(new AddJudge());

        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            judgeGrid.Children.Clear();
            judgeGrid.Children.Add(new ViewJudge());
        }
    }
}
