namespace BatataDoce;

public partial class GamePage4c : ContentPage
{


	public GamePage4c()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;
	}

	void proximo6(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage5();
	}

}