namespace BatataDoce;

public partial class GamePage6b : ContentPage
{


	public GamePage6b()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void Burro(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GameOver();
	}

    void Voltar2(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage7();
	}

}