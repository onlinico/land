﻿using System;
using System.Linq;
using System.Reflection;

namespace Land.Utils
{
    public static class EnumExtender
    {
        public static T[] GetEnumValues<T>()
        {
            Type type = typeof (T);
            if (!type.IsEnum)
                throw new ArgumentException("Type '" + type.Name + "' is not an enum");

            return (
                from field in type.GetFields(BindingFlags.Public | BindingFlags.Static)
                where field.IsLiteral
                select (T) field.GetValue(null)
                ).ToArray();
        }
    }
}