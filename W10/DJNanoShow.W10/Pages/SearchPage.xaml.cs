//---------------------------------------------------------------------------
//
// <copyright file="SearchPage.xaml.cs" company="Microsoft">
//    Copyright (C) 2015 by Microsoft Corporation.  All rights reserved.
// </copyright>
//
// <createdOn>2/24/2016 10:51:56 AM</createdOn>
//
//---------------------------------------------------------------------------

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using DJNanoShow.ViewModels;

namespace DJNanoShow.Pages
{
    public sealed partial class SearchPage : Page
    {
        public SearchPage()
        {
            ViewModel = new SearchViewModel();
            this.InitializeComponent();
            new Microsoft.ApplicationInsights.TelemetryClient().TrackPageView(this.GetType().FullName);
        }
        public SearchViewModel ViewModel { get; private set; }
		protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.SearchDataAsync(e.Parameter.ToString());
        }
    }    
}
