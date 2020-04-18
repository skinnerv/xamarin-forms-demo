using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsDemo.Control;

namespace XamarinFormsDemo.Covid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Covid19PageView : ContentPage
    {
        public Covid19PageView()
        {
            InitializeComponent();
        }

        private void RefreshCovid19DiseaseStatus_Clicked(object sender, EventArgs e)
        {
            UpdateWebContentsDataCovid19 updateWebContentsDataCovid19 = new UpdateWebContentsDataCovid19();
            updateWebContentsDataCovid19.DownloadFreshCovid19Data();

            RefreshCovid19DiseaseStatus.Text = "Covid status has been refreshed";
        }
    }
}