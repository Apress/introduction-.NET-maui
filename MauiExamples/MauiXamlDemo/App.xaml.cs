namespace MauiXamlDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        
        // Only have one of these statements uncommented
        // Uncomment this for a flyout page navigation
        MainPage = new FlyoutPageDemo();

        // Uncomment this for a tab page navigation
        //MainPage = new MainPage();
    }
}