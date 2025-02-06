namespace CapitecAssign;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GlobalOneHomePage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private  async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GlobalOneHomePage());
    }
}