namespace BatataDoce;

public partial class GamePage6a : ContentPage
{


	public GamePage6a()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

        InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			botaolanterna.IsVisible=true;
	}

}