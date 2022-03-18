using System;
using System.Collections.Generic;

namespace Sergey.UI.Extension.Themes
{
    public sealed class Themes
    {
        public static Uri Light { get; } = new Uri("/Sergey.UI.Extension;component/Resources/Themes/Light.xaml");
        public static Uri Dark { get; } = new Uri("/Sergey.UI.Extension;component/Resources/Themes/Dark.xaml");

        private static readonly Dictionary<Theme, Uri> _themes = new Dictionary<Theme, Uri> {
            { Theme.Light, Light },
            { Theme.Dark, Dark }
        };

        public static Uri GetUri(Theme theme)
        {
            return _themes[theme];
        }

    }
}