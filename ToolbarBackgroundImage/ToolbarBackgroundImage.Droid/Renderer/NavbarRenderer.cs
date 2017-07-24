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
using Xamarin.Forms.Platform.Android;
using ToolbarBackgroundImage.Droid;

[assembly: ExportRenderer(typeof(ContentPage), typeof(NavbarRenderer))]
namespace ToolbarBackgroundImage.Droid
{
    public class NavbarRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null && Context != null)
            {
                var toolbar = (Context as MainActivity).FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
                if (toolbar == null) return;
                toolbar.Subtitle = e.NewElement.ClassId;
                //We are using existing property to set subtitle in renderer, 
                //Although you can have your own property instead ClassId but you have to create a BasePage.
            }
        }
    }
}