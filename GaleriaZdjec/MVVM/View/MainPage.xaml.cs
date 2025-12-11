using GaleriaZdjec.MVVM.ViewModel;
using System.Collections;
using System.Collections.ObjectModel;

namespace GaleriaZdjec
{
    public partial class MainPage : ContentPage
    {
        private CarouselViewModel viewModel;
        private int currentIndex = 0;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new CarouselViewModel();

            // Ustaw pierwszy obraz
            CatImage.Source = viewModel.Images[currentIndex].Source;
        }

        private async void Prev_Clicked(System.Object sender, System.EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                CatImage.Source = viewModel.Images[currentIndex].Source;
            }
        }

        private void Next_Clicked(System.Object sender, System.EventArgs e)
        {
            if (currentIndex < viewModel.Images.Count - 1)
            {
                currentIndex++;
                CatImage.Source = viewModel.Images[currentIndex].Source;
            }
        }

        private void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
        {
            var shell = Application.Current.MainPage as Shell;
            if (shell != null)
            {
                if (e.Value) 
                {
                    RootGrid.BackgroundColor = Color.FromArgb("#1565C0");
                }
                else
                {
                    RootGrid.BackgroundColor = Color.FromArgb("#00796B");
                }
            }
        }

        private void Entry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            entry.Text = new string(entry.Text.Where(char.IsDigit).ToArray());


            var entryToString = entry.Text;

            if (int.TryParse(entryToString, out int entryToInt))
                if (entryToInt >= 1 && entryToInt <= 4)
                    CatImage.Source = $"kot{entryToString}.jpg";
                else
                    CatImage.Source = "kot1.jpg";
        }
    }
}
