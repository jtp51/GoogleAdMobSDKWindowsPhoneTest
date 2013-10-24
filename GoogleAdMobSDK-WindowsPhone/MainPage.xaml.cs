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
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            AdView bannerAd = new AdView
            {
                Format = AdFormats.Banner,
                AdUnitID = "",
                Width = 320,
                Height = 50
            };

            //Set up delegates
            bannerAd.ReceivedAd += bannerAd_ReceivedAd;
            bannerAd.FailedToReceiveAd += bannerAd_FailedToReceiveAd;


            AdRequest adRequest = new AdRequest();
            adRequest.ForceTesting = true;

            ContentPanel.Children.Add(bannerAd);
            bannerAd.LoadAd(adRequest);
        }

        void bannerAd_ReceivedAd(object sender, AdEventArgs e)
        {
            throw new NotImplementedException();
        }

        void bannerAd_FailedToReceiveAd(object sender, AdErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}