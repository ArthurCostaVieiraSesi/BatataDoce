namespace BatataDoce;

public partial class GamePage4b : ContentPage
{


	public GamePage4b()
	{
		InitializeComponent();
	}

	void proximo5(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage5();
	}

}