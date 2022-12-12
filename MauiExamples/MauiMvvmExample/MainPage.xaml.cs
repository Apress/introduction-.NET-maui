namespace MauiMvvmExample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(CounterViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
	}

	private void OnBtnClicked(object sender, EventArgs e)
	{
        count += ((CounterViewModel)BindingContext).IncrementAmount;

        IncrementLabel.Text = $"The total value is {count}";

		SemanticScreenReader.Announce(IncrementLabel.Text);
	}
}

