using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XFPageNavigation.Droid;

[assembly: Dependency(typeof(NaviAndroid))]
namespace XFPageNavigation.Droid
{
    public class NaviAndroid : INavi
    {
        public void PushAsnc(ContentPage page)
        {
            var app = Xamarin.Forms.Application.Current as App;
            var nav = app.MainPage as NavigationPage;
            nav.Navigation.PushAsync(page);
        }
    }
}