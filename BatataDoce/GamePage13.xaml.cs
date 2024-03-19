namespace BatataDoce;

public partial class GamePage13 : ContentPage
{


	public GamePage13()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void medo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new FinalPage();
	}

    void raiva(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage14();
	}

}