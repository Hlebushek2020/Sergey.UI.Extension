using System;

namespace Sergey.UI.Extension.Attributes
{
    internal class DisplayAttribute : Attribute
    {
        public string Value { get; }
        public DisplayAttribute(string value)
        {
            Value = value;
        }
    }
}
