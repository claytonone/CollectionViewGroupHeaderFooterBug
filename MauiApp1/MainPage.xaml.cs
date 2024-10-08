namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        List<TestGroup> items = [];

        for (int i = 0; i < 4; i++)
        {
            var group = new TestGroup()
            {
                Title = $"Group {i + 1}"
            };

            for (int j = 0; j < 4; j++)
            {
                group.Add(new TestItem() { Value = $"Sub item {j + 1}" });
            }

            items.Add(group);
        }

        ItemsList.ItemsSource = items;
    }
}