namespace FirstApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		const int newWidth = 1200;
		const int newHeight = 800;

		var newWindow = new Window(new AppShell())
		{
			Width = newWidth,
			Height = newHeight
		};


		return newWindow;
	}
}