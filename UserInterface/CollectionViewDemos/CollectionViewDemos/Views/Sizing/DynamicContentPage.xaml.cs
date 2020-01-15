using System;
using System.Collections.Generic;
using System.Windows.Input;
using CollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace CollectionViewDemos.Views
{
    public partial class DynamicContentPage : ContentPage
    {
		public DynamicContentPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysWithDetailsViewModel();
        }
	}
}
