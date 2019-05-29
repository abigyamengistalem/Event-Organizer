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
    /// Interaction logic for ForContestants.xaml
    /// </summary>
    public partial class ForContestants : UserControl
    {
        public List<SingleGalleryData> data { get; private set; }
        public ForContestants()
        {

            data = new List<SingleGalleryData>();
            DataTable contestantTable = Database.getContestants();
            DataRow[] dataRows = contestantTable.Select();
            foreach (DataRow singleRow in dataRows)
            {
                data.Add(new SingleGalleryData()
                {
                    contestantFNameBind = singleRow["FirstName"].ToString(),
                    contestantLNameBind = singleRow["MiddleName"].ToString(),
                    contestantEmailBind = singleRow["Email"].ToString(),
                    contestantHeightBind = singleRow["Height"].ToString(),
                    contestantBiographyBind = singleRow["Biography"].ToString(),
                    contestantnumberBind = singleRow["ContestantNumber"].ToString(),

                    imagePath = singleRow["Image"].ToString()
                });
            }
            InitializeComponent();
        }
    }
    public class SingleGalleryData
    {
        public string contestantFNameBind { get; set; }
        public string contestantLNameBind { get; set; }
        public string contestantEmailBind { get; set; }
        public string contestantHeightBind { get; set; }
        public string contestantBiographyBind { get; set; }
        public string contestantnumberBind { get; set; }
        public string imagePath { get; set; }
        // add the other database column here
    }
}

