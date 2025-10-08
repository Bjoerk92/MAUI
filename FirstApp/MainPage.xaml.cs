using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Internals;

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
		count++;
		IncShower.Text = count.ToString();
	}

	void OnButtonClicked(object sender, EventArgs e)
	{
		ChangeLabel();
	}

	async void OnPickerSelected(object sender, EventArgs e)
	{
		await DisplayAlert("Selected", ((Picker)sender).SelectedItem.ToString(), "OK");
	}

}