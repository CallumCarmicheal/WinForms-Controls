using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions {
    using System;

    /// <summary>
    /// Static class for generic parsing of string to enum
    /// </summary>
    /// <typeparam name="T">Type of the enum to be parsed to</typeparam>
    public static class Enum<T> {
        /// <summary>
        /// Parses the specified value from string to the given Enum type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static T Parse(string value) {
            //Null check
            if (value == null) throw new ArgumentNullException("value");
            //Empty string check
            value = value.Trim();
            if (value.Length == 0) throw new ArgumentException("Must specify valid information for parsing in the string", "value");
            //Not enum check
            Type t = typeof(T);
            if (!t.IsEnum) throw new ArgumentException("Type provided must be an Enum", "T");

            return (T)Enum.Parse(typeof(T), value);
        }
    }

    // The following extension methods can be accessed by instances of any 
    // class that implements IMyInterface.
    public static class Extension {

        public static TEnum ToEnum<TEnum>(this string val) {
            return (TEnum)System.Enum.Parse(typeof(TEnum), val);
        }

        public static TEnum ToEnum<TEnum>(this int val) {
            return (TEnum)System.Enum.ToObject(typeof(TEnum), val);
        }
    }
}
