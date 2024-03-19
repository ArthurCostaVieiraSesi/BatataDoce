namespace BatataDoce;

public partial class GamePage8 : ContentPage
{


	public GamePage8()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void Proximo45(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage9();
	}

}