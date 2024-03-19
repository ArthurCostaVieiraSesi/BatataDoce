namespace BatataDoce;

public partial class FinalPage1 : ContentPage
{


	public FinalPage1()
	{
		InitializeComponent();
	}

    void VoltarInicio2(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

}