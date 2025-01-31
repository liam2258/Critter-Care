using Critter_Care.Models;
using Critter_Care.PageModels;

namespace Critter_Care.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}