namespace MauiSqLiteConnection;

using MauiSqLiteConnection.DataAcess;

public partial class MainPage : ContentPage
{
	int count = 0;

	private readonly DatabaseAcessContext _dbContext;

	public MainPage(DatabaseAcessContext dbContext)
	{
		_dbContext = dbContext;
		InitializeComponent();

		_dbContext.Employees.Add(new Models.Employee
		{
			Id = Guid.NewGuid().ToString("N"),
			Name = "Jhon",
			Email = "jhon@gmail.com"

		});

		_dbContext.SaveChanges();

		lvEmployees.ItemsSource = _dbContext.Employees.ToList();
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
}

