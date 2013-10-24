using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GoogleAdMobSDK_WindowsPhone.Resources;
using GoogleAds;

namespace GoogleAdMobSDK_WindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        private AdView bannerAd;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            bannerAd = new AdView
            {
                Format = AdFormats.Banner,
                AdUnitID = "",
                Width = 320,
                Height = 50
            };

            //Set up delegates
            //Ad reception
            bannerAd.ReceivedAd += bannerAd_ReceivedAd;
            bannerAd.FailedToReceiveAd += bannerAd_FailedToReceiveAd;
            //Overlay
            bannerAd.DismissingOverlay += bannerAd_DismissingOverlay;
            bannerAd.ShowingOverlay += bannerAd_ShowingOverlay;
            //Application
            bannerAd.LeavingApplication += bannerAd_LeavingApplication;
            


            AdRequest adRequest = new AdRequest();
            adRequest.ForceTesting = true;

            ContentPanel.Children.Add(bannerAd);
            bannerAd.LoadAd(adRequest);
        }

        void bannerAd_LeavingApplication(object sender, AdEventArgs e)
        {
            System.Console.WriteLine("Leaving the app " + e.ToString());
        }

        void bannerAd_ShowingOverlay(object sender, AdEventArgs e)
        {
            
        }

        void bannerAd_DismissingOverlay(object sender, AdEventArgs e)
        {
            System.Console.WriteLine("Dismissing overlay " + e.ToString());
        }

        void bannerAd_ReceivedAd(object sender, AdEventArgs e)
        {
            System.Console.WriteLine("Ad received " + e.ToString());
            
        }

        void bannerAd_FailedToReceiveAd(object sender, AdErrorEventArgs e)
        {
            System.Console.WriteLine("Failed to receive Ad " + e.ToString());
        }

    }
}