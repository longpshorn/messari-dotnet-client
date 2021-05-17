using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Messari.Helper
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum enumName)
        {
            if (enumName == null)
            {
                throw new ArgumentNullException("enumName");
            }

            Type type = enumName.GetType();
            MemberInfo[] memInfo = type.GetMember(enumName.ToString());

            if (memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return enumName.ToString();
        }

        public static T GetEnumFromDescription<T>(this string stringValue)
        {
            var enumType = typeof(T);
            var members = enumType.GetMembers();
            foreach (var member in members)
            {
                var attr = member.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault();
                if (attr is DescriptionAttribute descriptionAttribute
                    && descriptionAttribute.Description == stringValue)
                {
                    return (T)Enum.Parse(enumType, member.Name);
                }
            }
            throw new Exception($"Description string {stringValue} not found in {enumType}.");
        }
    }
}
