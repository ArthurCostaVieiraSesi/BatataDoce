namespace BatataDoce;

public partial class FinalPage : ContentPage
{


	public FinalPage()
	{
		InitializeComponent();
	}

    void VoltarInicio1(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

}