﻿using System;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TPM_Parser.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        ApplicationDataContainer roamingSettings = null;
        const string DontShowLandingPageSetting = "DontShowLandingPage";

        public SettingsPage()
        {
            this.InitializeComponent();

            roamingSettings = ApplicationData.Current.RoamingSettings;

            if (roamingSettings.Values[DontShowLandingPageSetting] != null &&
                roamingSettings.Values[DontShowLandingPageSetting].Equals(true.ToString()))
            {
                DontShowLandingPage.IsChecked = true;
            }
            else
            {
                DontShowLandingPage.IsChecked = false;
            }
        }

        private void DontShowLandingPage_Checked(object sender, RoutedEventArgs e)
        {
            roamingSettings.Values[DontShowLandingPageSetting] = DontShowLandingPage.IsChecked.ToString();
        }
    }
}
