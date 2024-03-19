namespace BatataDoce;

public partial class GamePage11 : ContentPage
{


	public GamePage11()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void Morta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage12();
	}

}