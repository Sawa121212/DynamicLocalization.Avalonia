using System;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using DynamicLocalizationUI.Avalonia.Localization;

namespace DynamicLocalizationUI.Avalonia.Extensions
{
    /// <summary>
    /// Binding an expression by key
    /// </summary>
    public class LocalizeExtension : MarkupExtension
    {
        public LocalizeExtension(string key)
        {
            Key = key;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            string keyToUse = Key;

            if (!string.IsNullOrWhiteSpace(Context))
                keyToUse = $"{Context}/{Key}";

            ReflectionBindingExtension binding = new($"[{keyToUse}]")
            {
                Mode = BindingMode.OneWay,
                Source = Localizer.Instance,
            };

            return binding.ProvideValue(serviceProvider);
        }

        public string Key { get; set; }

        public string Context { get; set; }
    }
}