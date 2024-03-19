namespace BatataDoce;

public partial class GamePage10 : ContentPage
{


	public GamePage10()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void nao(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage11();
	}

}