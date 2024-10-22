using Microsoft.Maui.Controls.Shapes;

namespace ContentViewTemplateExampleApp;

public class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty =
        BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardDescriptionProperty =
        BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }


    public CardView()
    {
        this
        .Content(
            new Border()
            .StrokeShape(new RoundRectangle().CornerRadius(20))
            .Stroke(LightGray)
            .BackgroundColor(LightGray)
            .BindingContext(this)
            .SizeRequest(350,150)
            .Padding(10)
            .Content(
                new Grid()
                .ColumnDefinitions(e => e.Auto().Star())
                .RowDefinitions(e => e.Star(count:2))
                .Children(
                    new Image()
                    .Source("dotnet_bot.png")
                    .RowSpan(2)
                    .SizeRequest(60),

                    new Label()
                    .Text(e => e.Path(nameof(CardTitle)))
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .Column(1)
                    .CenterVertical(),

                    new Label()
                    .Text(e => e.Path(nameof(CardDescription)))
                    .FontAttributes(Italic)
                    .FontSize(15)
                    .Column(1)
                    .Row(1)
                    .CenterVertical()
                )
                
            )
        );
    }
}