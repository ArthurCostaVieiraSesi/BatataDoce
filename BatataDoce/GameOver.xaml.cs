namespace BatataDoce;

public partial class GameOver : ContentPage
{


	public GameOver()
	{
		InitializeComponent();
	}

    void VoltarInicio(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

}