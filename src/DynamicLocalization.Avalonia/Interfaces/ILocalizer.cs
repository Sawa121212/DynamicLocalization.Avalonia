using System.Resources;

namespace DynamicLocalizationUI.Avalonia.Interfaces
{
    public interface ILocalizer
    {
        void ChangeLanguage(string language);

        string? GetExpression(string key);

        void EditLanguage(string language);

        void AddResourceManager(ResourceManager resourceManager);
    }
}