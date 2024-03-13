namespace BatataDoce;

public partial class GamePage3 : ContentPage
{


	public GamePage3()
	{
		InitializeComponent();
	}

	void Loja(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage4a();
	}

	void Crime(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage4b();
	}

}