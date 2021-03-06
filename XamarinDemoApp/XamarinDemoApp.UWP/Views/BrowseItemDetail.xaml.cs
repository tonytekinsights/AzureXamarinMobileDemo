﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using XamarinDemoApp.Models;
using XamarinDemoApp.ViewModels;

namespace XamarinDemoApp.UWP.Views
{
	public sealed partial class BrowseItemDetail : Page
	{
		public ItemDetailViewModel ViewModel { get; set; }

		public BrowseItemDetail()
		{
			InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			ViewModel = new ItemDetailViewModel((Item)e.Parameter);
			DataContext = ViewModel;
		}
	}
}