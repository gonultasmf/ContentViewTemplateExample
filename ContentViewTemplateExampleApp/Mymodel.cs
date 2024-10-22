namespace ContentViewTemplateExampleApp;

public class Mymodel
{
    public Mymodel(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public string Title { get; set; }
    public string Description { get; set; }
}