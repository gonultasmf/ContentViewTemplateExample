﻿namespace ContentViewTemplateExampleApp;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(new ResourceDictionary().MergedDictionaries(AppStyles.Default))
        .MainPage(new AppShell());
    }
}
