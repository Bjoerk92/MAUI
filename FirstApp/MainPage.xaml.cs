
namespace FirstApp;

public partial class MainPage : ContentPage
{
	private int count = 0;
	public MainPage()
	{
		Console.WriteLine("Initializing MainPage");

		InitializeComponent();
	}

	public void ChangeLabel()
	{
		IncShower.Text = count.ToString();
	}

	void IncrementButton(object sender, EventArgs e)
	{
		count++;
		ChangeLabel();
	}

	void DecrementButton(object sender, EventArgs e)
	{
		count--;
		ChangeLabel();
	}

	async void OnPickerSelected(object sender, EventArgs e)
	{
		await DisplayAlert("Alert", "You selected " + picker.SelectedItem, "OK");
	}

	async void EnterEntry(object sender, EventArgs e)
	{
		await DisplayAlert("Alert", "You entered " + entry.Text, "OK");
	}

}