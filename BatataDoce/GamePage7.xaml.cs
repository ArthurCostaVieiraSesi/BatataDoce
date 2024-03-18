namespace BatataDoce;

public partial class GamePage7 : ContentPage
{


	public GamePage7()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

}