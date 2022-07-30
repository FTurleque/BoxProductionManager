using System.ComponentModel;
using System.Reflection;

namespace BoxProductionApp.Class
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Extension qui permet d'itérer sur une enum et en récupérer les valeurs 
        /// </summary>
        /// <param name="GenericEnum">Type de l'enum</param>
        /// <returns></returns>
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] Level = genericEnumType.GetMember(GenericEnum.ToString());
            if (Level.Length <= 0)
            {
                return GenericEnum.ToString();
            }
            object[] attribs = Level[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attribs.Any() ? ((DescriptionAttribute)attribs.ElementAt(0)).Description : GenericEnum.ToString();
        }
    }
}
