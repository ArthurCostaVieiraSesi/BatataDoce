namespace BatataDoce;

public partial class App : Application
{
	
	public bool TemMachado = false;
	public bool TemLanterna = false;

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
