namespace BatataDoce;

public partial class GamePage4a : ContentPage
{


	public GamePage4a()
	{
		InitializeComponent();
	}

	void Lanterna(object sender, EventArgs args)
	{
        (App.Current as App).TemLanterna=true;
		Application.Current.MainPage = new GamePage4c();
	}

	void Machado(object sender, EventArgs args)
	{
        (App.Current as App).TemMachado=true;
		Application.Current.MainPage = new GamePage4c();
	}

}