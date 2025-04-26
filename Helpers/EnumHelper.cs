using System.ComponentModel;
using System.Reflection;

namespace SistemaFinanceiro.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Retorna a descrição associada a um valor de enum (via [Description]),
        /// ou o nome do valor caso não haja atributo Description.
        /// </summary>
        public static string GetDescription(Enum value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name == null) return value.ToString();

            var field = type.GetField(name);
            if (field == null) return name;

            var attr = field.GetCustomAttribute<DescriptionAttribute>();
            return attr?.Description ?? name;
        }

        /// <summary>
        /// Retorna todas as descrições de um enum TEnum, na ordem de declaração.
        /// </summary>
        public static IEnumerable<string> GetAllDescriptions<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                       .Cast<Enum>()
                       .Select(e => GetDescription(e));
        }

        /// <summary>
        /// Retorna pares (valor, descrição) de um enum TEnum, na ordem de declaração.
        /// </summary>
        public static IEnumerable<(TEnum Value, string Description)> GetAllValuesAndDescriptions<TEnum>()
            where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                       .Cast<TEnum>()
                       .Select(e => (e, GetDescription(e)));
        }
    }
}