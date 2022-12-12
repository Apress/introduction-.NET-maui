namespace MauiXamlDemo;

public partial class FlyoutPageDemo : FlyoutPage
{
    public FlyoutPageDemo()
    {
        InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += OnItemChanged;
    }

    void OnItemChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutItemModel;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
        }
    }
}