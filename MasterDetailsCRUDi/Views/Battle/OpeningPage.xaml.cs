using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailsCRUDi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OpeningPage : ContentPage
	{
		public OpeningPage ()
		{
			InitializeComponent ();
		}

	    private async void UserBattle_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new NewItemPage());
	    }
	    private async void AutoBattle_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new NewItemPage());
	    }

    }
}