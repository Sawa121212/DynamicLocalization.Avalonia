using System.Globalization;
using DynamicLocalizationUI.Avalonia.Interfaces;

namespace DynamicLocalization.Demo.Properties
{
    /// <summary>
    /// Переключатель Языка в ПО
    /// </summary>
    public class ResourceProvider : ILocalizationResourceProvider
    {
        public ResourceProvider()
        {
            // Тут нужно сделать загрузчик настроек и задать начальный язык ПО
        }

        public void ChangeResources()
        {
            // задать начальный язык ПО
            Language.Culture = new CultureInfo("ru");
        }
    }
}