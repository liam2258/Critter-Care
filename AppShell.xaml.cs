
namespace Critter_Care;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for navigation
        //Routing.RegisterRoute(nameof(Pages.ProfilePage), typeof(Pages.ProfilePage));
        //Routing.RegisterRoute(nameof(Pages.CalendarPage), typeof(Pages.CalendarPage));
        //Routing.RegisterRoute(nameof(Pages.SettingsPage), typeof(Pages.SettingsPage));
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(SettingsPage));
    }
}
