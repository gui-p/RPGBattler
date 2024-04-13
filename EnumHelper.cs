using System.Reflection;

namespace DnD.Helpers
{
    public static class EnumHelper
    {
        public static Array GetRandomEnum<T>() where T : Enum 
        {
            Random random = new();
            Type type = typeof(T);
            Array properties = type.GetEnumValues();
            //int RandNum = random.Next(0, properties.);            
            return properties;
        }
    }
}