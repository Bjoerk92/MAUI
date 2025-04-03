namespace FirstApp;

public partial class MainPage : ContentPage
{
	List<string> itemList = new List<string>();
	public MainPage()
	{
		InitializeComponent();


		itemList.Add("Baboon");
		itemList.Add("Capuchin Monkey");
		itemList.Add("Blue monkey");
		itemList.Add("Squirrel monkey");
		itemList.Add("Golden Lion Tamarin");
		itemList.Add("Howler Monkey");
		itemList.Add("Japanese Macaque");

		Picker picker = new Picker { Title = "Select a monkey" };
		picker.ItemsSource = itemList; 
	}

	


}