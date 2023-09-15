using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System.Collections.Generic; // Add this using directive

namespace carruselymap
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ImageItem> ImageItems { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ComboBox.ItemsSource = new List<string>
            {
                "mostrar restaurantes",
                "mostrar iglesias",
                "mostrar hoteles"
            };

            ImageItems = new ObservableCollection<ImageItem>
            {
                new ImageItem { ImageSource = ImageSource.FromFile("Resources/Images/tiquipayaU.jpg"), Title = "Image 1", Description = "Description for Image 1" },
                new ImageItem { ImageSource = ImageSource.FromFile("Resources/Images/tiquipayaD.jpg"), Title = "Image 2", Description = "Description for Image 2" },
                new ImageItem { ImageSource = ImageSource.FromFile("Resources/Images/tiquipayaT.jpg"), Title = "Image 3", Description = "Description for Image 3" },
                new ImageItem { ImageSource = ImageSource.FromFile("Resources/Images/tiquipayaC.jpg"), Title = "Image 4", Description = "Description for Image 4" },
                new ImageItem { ImageSource = ImageSource.FromFile("Resources/Images/tiquipayaI.jpg"), Title = "Image 5", Description = "Description for Image 5" }
            };

            BindingContext = this;
        }
        private void OnVerLugaresClicked(object sender, EventArgs e)
        {
            // Access the ImageItems property within the MainPage class
            ObservableCollection<ImageItem> imageItems = ImageItems;

            // Now you can use imageItems as needed
        }

        private void OnComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // Access the ImageItems property within the MainPage class
            ObservableCollection<ImageItem> imageItems = ImageItems;

            // Now you can use imageItems as needed
        }

        private void OnIconHomeClicked(object sender, EventArgs e)
        {
           
        }
        private void OnIconSearchClicked(object sender, EventArgs e)
        {

        }
        private void OnIconSavedClicked(object sender, EventArgs e)
        {

        }

        private void OnIconUserClicked(object sender, EventArgs e)
        {

        }
    }

    public class ImageItem
    {
        public ImageSource ImageSource { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
