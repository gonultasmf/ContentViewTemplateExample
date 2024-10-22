using System.Reflection;

namespace ContentViewTemplateExampleApp;

public partial class MainPage : ContentPage, IFmgLibHotReload
{
    public MainPage()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Content(
           new CollectionView()
           .Margin(10)
           .ItemsSource(new List<Mymodel>{
            new Mymodel("Deneme 1", "Deneme 1 icin yazildi."),
            new Mymodel("Deneme 2", "Deneme 2 icin yazildi."),
            new Mymodel("Deneme 3", "Deneme 3 icin yazildi."),
            new Mymodel("Deneme 4", "Deneme 4 icin yazildi."),
            new Mymodel("Deneme 5", "Deneme 5 icin yazildi."),
            new Mymodel("Deneme 6", "Deneme 6 icin yazildi."),
            new Mymodel("Deneme 7", "Deneme 7 icin yazildi.")
           })
           .ItemTemplate(new DataTemplate(() => 
            new CardView()
            .CardTitle(e => e.Path("Title"))
            .CardDescription(e => e.Path("Description"))
           ))
        );
    }
}
