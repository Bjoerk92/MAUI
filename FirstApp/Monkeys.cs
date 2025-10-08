using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Maui.Controls.Internals;
public class Monkeys
{
	private ObservableCollection<Object> _monkeys = new ObservableCollection<object>()
	{
		"Baboon",
		"Capuchin Monkey"
	};

	public ObservableCollection<object> MonkeysList
	{
		get { return _monkeys; }
		set { _monkeys = value; }
	}

}

