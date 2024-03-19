namespace BatataDoce;

public partial class GamePage12 : ContentPage
{


	public GamePage12()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void propro(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage13();
	}

}