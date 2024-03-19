namespace BatataDoce;

public partial class GamePage9 : ContentPage
{


	public GamePage9()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void Sim(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage10();
	}


}