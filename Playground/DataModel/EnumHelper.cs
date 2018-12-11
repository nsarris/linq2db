using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace PiraeusBank.BI.ICE2.Helpers
{
    public class EnumCodeAttribute : Attribute
    {
        public string Code { get; set; }
        public EnumCodeAttribute(string code)
        {
            Code = code;
        }
    }
    public static class EnumHelper
    {
        public class EnumDef
        {
            public object Id { get; private set; }
            public string Code { get; private set; }
            public string Name { get; private set; }
            public string Description { get; private set; }
            public Type Type { get; private set; }
            public string FullName { get { return Type.Name + "." + Name; } }
            internal EnumDef(object id, string name, string description, Type type, string code)
            {
                this.Id = id;
                this.Name = name;
                this.Description = description;
                this.Type = type;
                this.Code = code;
            }
        }

        static ConcurrentDictionary<Type, object> cache = new ConcurrentDictionary<Type, object>();

        static Dictionary<TEnum, EnumDef> GetEnumDef<TEnum>()
            where TEnum : struct, IConvertible
        {
            object res = null;
            if (cache.TryGetValue(typeof(TEnum), out res))
                return (Dictionary<TEnum, EnumDef>)res;
            else
            {
                var d = new Dictionary<TEnum, EnumDef>();
                foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
                    d.Add(item, new EnumDef(item, item.ToString(), GetDescription(item as Enum), typeof(TEnum), GetCode(item as Enum)));

                cache.TryAdd(typeof(TEnum), d);

                return d;
            }
        }

        public static EnumDef GetItem<TEnum>(TEnum value, params object[] descriptionParameters)
            where TEnum : struct, IConvertible
        {
            if (!value.GetType().IsEnum)
                throw new ArgumentException("value must be an enum type");

            var def = GetEnumDef<TEnum>();
            EnumDef enumdef;
            def.TryGetValue(value, out enumdef);

            var descr = enumdef.Description;
            if (descriptionParameters != null)
                try
                {
                    descr = string.Format(descr, descriptionParameters);
                }
                catch { }

            return new EnumDef(enumdef.Id, enumdef.Name, descr, typeof(TEnum), enumdef.Code);
        }

        

        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                var attribute = field.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();
                return attribute == null ? value.ToString() : attribute.Description;
            }
            else
                return value.ToString();

        }

        public static string GetCode(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                var attribute = field.GetCustomAttribute<EnumCodeAttribute>();
                return attribute == null ? value.ToString() : attribute.Code;
            }
            else
                return value.ToString();

        }

        public static EnumDef GetItem(object value, params object[] descriptionParameters)
        {
            if (value == null || !value.GetType().IsEnum)
                throw new ArgumentException("value must be an enum type");

            var m = typeof(EnumHelper).GetMethods().Where(x => x.Name == "GetItem" && x.IsGenericMethod).Single().MakeGenericMethod(new Type[] { value.GetType() });
            return (EnumDef)m.Invoke(null, new object[] { value, descriptionParameters });
        }

        public static bool TryGetValueFromName<TEnum>(string name, out TEnum result)//, bool RemoveSpaces = true)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            result = default;

			var def = GetEnumDef<TEnum>().Values.FirstOrDefault(x => x.Name == name);

			if (def == null)
                return false;
            else
            {
                result = (TEnum)(def.Id);
                return true;
            }

            //if (RemoveSpaces)
            //    Name = Name.Replace(" ", string.Empty);

            //foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
            //    if (StringComparer.OrdinalIgnoreCase.Compare((item).ToString(),Name)==0)
            //    {
            //        result = item;
            //        return true;
            //    }

            //return false;
        }

        public static bool TryGetValueFromDescription<TEnum>(string description, out TEnum result)//, bool RemoveSpaces = true)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            result = default;

            var def = GetEnumDef<TEnum>().Values.FirstOrDefault(x => x.Description == description);

            if (def == null)
                return false;
            else
            {
                result = (TEnum)(def.Id);
                return true;
            }

            //if (RemoveSpaces)
            //    Name = Name.Replace(" ", string.Empty);

            //foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
            //    if (StringComparer.OrdinalIgnoreCase.Compare((item).ToString(),Name)==0)
            //    {
            //        result = item;
            //        return true;
            //    }

            //return false;
        }

        public static bool TryGetValueFromCode<TEnum>(string code, out TEnum result)//, bool RemoveSpaces = true)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            result = default;

			var def = GetEnumDef<TEnum>().Values.FirstOrDefault(x => x.Code == code);

			if (def == null)
                return false;
            else
            {
                result = (TEnum)(def.Id);
                return true;
            }
        }

        public static bool TryGetValueFromValue<TEnum>(object value, out TEnum result)
        where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            result = default(TEnum);

            if (value == null)
                return false;

            foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
                try
                {
                    var v = Convert.ChangeType(item, value.GetType());
                    if (v.Equals(value))
                    {
                        result = item;
                        return true;
                    }
                }
                catch
                {
                }

            return false;
        }

        public static TEnum GetValueOrDefaultFromName<TEnum>(string name)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            TryGetValueFromName<TEnum>(name, out var e);
            return e;
        }

        public static TEnum GetValueOrDefaultFromValue<TEnum>(object value)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            TryGetValueFromValue<TEnum>(value, out var e);
            return e;
        }

        public static TEnum? GetValueOrNullFromValue<TEnum>(object value)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            if (TryGetValueFromValue<TEnum>(value, out var e))
                return (TEnum?)e;
            else
                return null;
        }

        public static TEnum GetValueOrDefaultFromDescription<TEnum>(string description)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            TryGetValueFromDescription<TEnum>(description, out var e);
            return e;
        }

        public static TEnum? GetValueOrNullFromDescription<TEnum>(string description)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            if (TryGetValueFromDescription<TEnum>(description, out var e))
                return e;
            else
                return null;
        }

        public static TEnum GetValueOrDefaultFromCode<TEnum>(string code)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            TryGetValueFromCode<TEnum>(code, out var e);
            return e;
        }

        public static TEnum? GetValueOrNullFromCode<TEnum>(string code)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            if (TryGetValueFromCode<TEnum>(code, out var e))
                return e;
            else
                return null;
        }

        public static string GetDescriptionFromValue<TEnum>(TEnum value)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            return GetEnumDef<TEnum>()[value].Description;

            //FieldInfo fi = value.GetType().GetField(value.ToString());
            //DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //if (attributes.Length > 0)
            //{
            //    return attributes[0].Description;
            //}
            //else
            //{
            //    return value.ToString();
            //}
        }

        public static string GetCodeFromValue<TEnum>(TEnum value)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            return GetEnumDef<TEnum>()[value].Code;
        }

        public static string GetDescriptionFromValue<TEnum>(TEnum value, params string[] parameters)
            where TEnum : struct, IConvertible
        {
            return string.Format(GetDescriptionFromValue(value), parameters);
        }

        public static TEnum GetValueFromDescription<TEnum>(string description)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

			var def = GetEnumDef<TEnum>().Values.FirstOrDefault(x => x.Description == description);

			if (def == null)
                throw new ArgumentException("The string is not a description or value of the specified enum.");
            else
            {
                return (TEnum)(def.Id);
            }
        }

        public static TEnum GetValueFromCode<TEnum>(string code)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

			var def = GetEnumDef<TEnum>().Values.FirstOrDefault(x => x.Code == code);

			if (def == null)
                throw new ArgumentException("The string is not a description or value of the specified enum.");
            else
            {
                return (TEnum)(def.Id);
            }
        }

        public static TEnum GetValueFromValue<TEnum>(object value)
            where TEnum : struct, IConvertible
        {
            Contract.Requires(IsEnumType(typeof(TEnum)), "T must be Enum type");

            TEnum e = default(TEnum);
            if (TryGetValueFromValue<TEnum>(value, out e))
                return e;

            throw new InvalidCastException($"Value '{value}' cannot be converted to enum type {typeof(TEnum).FullName}");
        }

        public static List<T> EnumToList<T>()
        {
            Contract.Requires(IsEnumType(typeof(T)), "T must be Enum type");

            if (!IsEnumType(typeof(T)))
                throw new ArgumentException("T must be of type System.Enum");

            return Enum.GetValues(typeof(T)).Cast<T>().ToList();

        }

        public static bool IsEnumType(Type T)
        {
            //return (T.BaseType == typeof(Enum));
            return T.IsEnum;
        }
    }
}
