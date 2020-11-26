using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.System;

namespace DeviceApp
{
    /// <summary>
    /// Main page of device application
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CirclePage
    {
        /// <summary>
        /// The constructor of MainPage
        /// </summary>
		public MainPage()
        {
            InitializeComponent();
            CreateListView();
        }

        /// <summary>
        /// Create list view of device feature
        /// </summary>
        private void CreateListView()
        {
            // Create device feature list
            // Battery, Display, Haptic, IR, Led & Camera back flash
            List<FeatureItem> featureItems = new List<FeatureItem>
            {
                new FeatureItem("날씨"),
                new FeatureItem("낚시 도감"),
                new FeatureItem("균형도우미"),
            };
            DeviceFeatureList.ItemsSource = featureItems;
        }

        /// <summary>
        /// Method for tapped event of device feature list item
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event argument</param>
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            FeatureItem item = (FeatureItem)e.Item;
            if (item.Name.Equals("날씨 "))
            {
//              weather();
            }
            else if (item.Name.Equals("낚시 도감 "))
            {
//              fishinggo();
            }
            else if (item.Name.Equals("균형도우미 "))
            {
//              level();
            }
            else
            {
                // Unknown feature
                this.Navigation.PushAsync(new SimpleResult("wrong function"));
            }
        }
    }
}