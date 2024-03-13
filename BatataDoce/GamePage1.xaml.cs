namespace BatataDoce;

public partial class GamePage1 : ContentPage
{


	public GamePage1()
	{
		InitializeComponent();
	}

	void QuandoClicarNoBotaoProximo1(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage2();
	}

}