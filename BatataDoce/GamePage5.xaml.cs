namespace BatataDoce;

public partial class GamePage5 : ContentPage
{


	public GamePage5()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;
	}

    void proximo7(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage6();
	}

}