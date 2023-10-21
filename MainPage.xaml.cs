namespace CarouselDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            carouselView.ItemsSource = new object[]
            {
                new Item { Color = Colors.Red },
                new Item { Color = Colors.Green },
                new Item { Color = Colors.Yellow },
                new Item { Color = Colors.Blue },
            };
        }
    }
}

public class Item
{
    public Color Color { get; set; }
}