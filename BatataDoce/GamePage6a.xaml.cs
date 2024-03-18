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

		if((App.Current as App).TemLanterna==true)
			botaolanterna.IsVisible=true;
	}

	void UsarLanterna(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage6b();
	}

	void Voltar1(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage7();
	}

}