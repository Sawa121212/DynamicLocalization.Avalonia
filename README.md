# DynamicLocalization.Avalonia
Dynamic runtime localization in a [Avalonia](https://github.com/AvaloniaUI/Avalonia) application. This app helps get start using [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia) with [Prism.Avalonia](https://github.com/AvaloniaCommunity/Prism.Avalonia).

![Анимация](https://github.com/user-attachments/assets/432af2c1-5b88-4883-8e0a-1c5cdd466d9d)

## Using DynamicLocalization
### Using localization
* Add resources. Example `Language.resx` and `Language.ru.resx`
<img width="396" height="264" alt="image" src="https://github.com/user-attachments/assets/d89835cd-c440-4970-9c6d-1a66a5e23c1f" />

* Registration in the container `ILocalizer`

`App.axaml.cs`
```csharp
using DynamicLocalization.Avalonia.Interfaces;
using DynamicLocalization.Avalonia.Localization;
```
```csharp
containerRegistry.RegisterSingleton<ILocalizer, Localizer>();
```

* Add a new resource manager in the container by specifying the resource class: `Language.resx`

`ModuleAModule.cs`
```csharp
containerProvider.Resolve<ILocalizer>().AddResourceManager(new ResourceManager(typeof(Language)));
```

* In xaml use `Localize`
```XAML
xmlns:extensions="clr-namespace:DynamicLocalization.Avalonia.Extensions;assembly=DynamicLocalization.Avalonia"
```
```XAML
<MenuItem Header="{extensions:Localize Cut}" />
```

### Change language
* Use `ILocalizer` from the container

`ShellViewModel.cs`
```CSharp
private readonly ILocalizer _localizer;

public ShellViewModel(ILocalizer localizer)
{
    _localizer = localizer;
}
```

* Change app culture
```CSharp
Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
```

* Change the language in `ILocalizer`
```CSharp
_localizer.EditLanguage(language);
```

## Technologies and Tools Used
- [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia) cross-platform XAML-based GUI framework
- [Prism](https://github.com/AvaloniaCommunity/Prism.Avalonia) provides your Avalonia apps with Prism framework support so you can navigate and perform dependency injection easier than before
- [JetBrains Rider](https://www.jetbrains.com/rider/) and [Microsoft Visual Studio](https://visualstudio.microsoft.com/) IDEs
- [AvaloniaRider](https://github.com/fornever/avaloniarider) plugin for visual designer support
- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
