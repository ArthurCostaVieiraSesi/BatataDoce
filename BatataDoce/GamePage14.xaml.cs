namespace BatataDoce;

public partial class GamePage14 : ContentPage
{


	public GamePage14()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

        if((App.Current as App).TemMachado==true)
			machado.IsVisible=true;

	}

    void morreu(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GameOver();
	}

    void morreu2(object sender, EventArgs args)
	{
		Application.Current.MainPage = new FinalPage1();
	}

}