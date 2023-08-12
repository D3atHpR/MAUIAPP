namespace MAUIAPP;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void NameMudar(object sender, EventArgs e)
    {
		if (Namealt.Text == "Welcome to .NET Multi-platform App UI")
		{
			Namealt.Text = "Fui Alterado";
		}
		else
		{
			Namealt.Text = "Welcome to .NET Multi-platform App UI";

        }
    }
}

