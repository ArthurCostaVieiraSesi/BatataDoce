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

}