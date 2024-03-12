namespace BatataDoce;

public partial class GamePage : ContentPage
{


	public GamePage()
	{
		InitializeComponent();
	}

	void QuandoClicarNoBotaoProximo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage1();
	}

}