using Sergey.UI.Extension.Attributes;
using System;
using System.Reflection;

namespace Sergey.UI.Extension.Themes
{
    public struct ThemeDisplay
    {
        public Theme Value { get; }
        public string Display
        {
            get
            {
                Type type = Value.GetType();
                MemberInfo[] memInfo = type.GetMember(Value.ToString());
                if (memInfo.Length > 0)
                {
                    object[] attrs = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);
                    if (attrs.Length > 0)
                    {
                        return ((DisplayAttribute)attrs[0]).Value;
                    }
                }
                return Value.ToString();
            }
        }

        public ThemeDisplay(Theme value)
        {
            Value = value;
        }
    }
}