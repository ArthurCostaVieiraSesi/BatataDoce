namespace BatataDoce;

public partial class GamePage2 : ContentPage
{


	public GamePage2()
	{
		InitializeComponent();
	}

	void Proximo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage3();
	}

}