using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsDemo.View.PoopTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PoopHomePageView : ContentPage
    {
        public PoopHomePageView()
        {
            InitializeComponent();
        }

        private async void newPoopButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new AddNewPoopView());
        }

        private void SeeHistoryButton_Clicked(object sender, EventArgs e)
        {

        }

        private void StatisticsButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}