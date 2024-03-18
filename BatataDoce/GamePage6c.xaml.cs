namespace BatataDoce;

public partial class GamePage6c : ContentPage
{


	public GamePage6c()
	{
		InitializeComponent();
		if((App.Current as App).TemLanterna==true)
			imglanterna.IsVisible=true;

		if((App.Current as App).TemMachado==true)
			imgmachado.IsVisible=true;

	}

    void Voltar3(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage7();
	}

}