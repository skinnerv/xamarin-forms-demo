using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsDemo.Control;
using XamarinFormsDemo.Control.ManipulateCovidData;

namespace XamarinFormsDemo.Covid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Covid19PageView : ContentPage
    {
        private static Areas _areas { get; set; }
        public Covid19PageView()
        {
            InitializeComponent();
        }

        private void RefreshCovid19DiseaseStatus_Clicked(object sender, EventArgs e)
        {
            UpdateWebContentsDataCovid19 updateWebContentsDataCovid19 = new UpdateWebContentsDataCovid19();
            updateWebContentsDataCovid19.DownloadFreshCovid19Data();

            RefreshCovid19DiseaseStatus.Text = "Covid status has been refreshed";
            _areas = new Areas();
            JsonToCshCovid jsonToCshCovid = new JsonToCshCovid(_areas, updateWebContentsDataCovid19.responsHtml);

            if (jsonToCshCovid.convertJsonToCsh)
                UpdateListScreenView(_areas);
        }



        private void UpdateListScreenView(Areas areas)
        {
            if(PolandSwitch.IsToggled)
            {
                Console.WriteLine("dlp PolandSwitch is toggeled");
                var Poland = _areas.Countries.Select(x => x);
                throw new Exception("To implement later");
              
            }
            if (WorldSwitch.IsToggled)
            {
                Console.WriteLine("dlp WorldSwitch is toggeled");
                throw new Exception("To implement later");
            }
        }
    }
}