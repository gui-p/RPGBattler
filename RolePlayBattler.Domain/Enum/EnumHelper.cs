using System;

namespace RolePlayBattler.Domain.Enum
{
    public static class EnumHelper
    {
        public static T GetRandomEnum<T>() where T : System.Enum
        {
            Random random = new();
            var values = System.Enum.GetValues(typeof(T));
            return (T)values.GetValue(random.Next(values.Length))!;
        }
    }
}