using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFPageNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PushAsync
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickedPushAsync(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SecondPage());
        }

        /// <summary>
        /// PushAsync from App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickedPushAsyncFromApp(object sender, EventArgs e)
        {
            var app = Xamarin.Forms.Application.Current as App;
            var nav = app.MainPage as NavigationPage;
            nav.Navigation.PushAsync(new SecondPage());
        }

        /// <summary>
        /// PushAsync from native
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickedPushAsyncFromNative(object sender, EventArgs e)
        {
            var navi = DependencyService.Get<INavi>();
            navi.PushAsnc(new SecondPage());
        }
    }
}
