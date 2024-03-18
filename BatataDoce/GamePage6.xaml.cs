namespace BatataDoce;

public partial class GamePage6 : ContentPage
{


	public GamePage6()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;
	}

	void Janela(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage6a();
	}

	void Corpo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage6c();
	}

}