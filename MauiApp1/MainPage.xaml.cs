using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            List<Artwork> VanGoghWorks = new List<Artwork>
            {
                new Artwork { Image = "sunflowers.jpg", Title = "Vase with Fifteen Sunflowers", Price = "$950,000" },
                new Artwork { Image = "vase.jpeg", Title = "Vase with Irises Against a Yellow Background", Price = "$870,000" },
                new Artwork { Image = "self.jpeg", Title = "Self-Portrait with a Straw Hat", Price = "$1,260,000" },
                new Artwork { Image = "night.jpg", Title = "The Starry Night Over The Rhone", Price = "$1,550,000" },


                // Add more dummy data as needed...
            };

            // Set the CollectionView's ItemsSource to the list of artworks
            collectionView.ItemsSource = VanGoghWorks;
        }


        // Simple Artwork class with Image, Title, and Price properties
        public class Artwork
        {
            public string Image { get; set; }
            public string Title { get; set; }
            public string Price { get; set; }
        }

    }
}
