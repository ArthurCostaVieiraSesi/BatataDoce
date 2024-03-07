namespace BatataDoce;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	void QuandoClicarNoBotao(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}

		void QuandoClicarNoBotaoSobre(object sender, EventArgs args)
	{
		Sobre.IsVisible=true;
	}

		void QuandoClicarNoBotaoVoltar(object sender, EventArgs args)
	{
		Sobre.IsVisible=false;
	}

		void QuandoClicarNoBotaoCreditos(object sender, EventArgs args)
	{
		Creditos.IsVisible=true;
	}

		void QuandoClicarNoBotaoVoltar1(object sender, EventArgs args)
	{
		Creditos.IsVisible=false;
	}

}

