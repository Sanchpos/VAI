using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vai.Data.Models
{
    public class Base64Field<T, TValue>
    {
        private static BinaryFormatter converter;
        private readonly PropertyInfo property;
        private readonly T that;
        private TValue valueCache;
        private bool valueCacheValid;

        public TValue Value
        {
            get
            {
                if (valueCacheValid) return valueCache;
                var storedVal = (string)property.GetValue(that);
                if (string.IsNullOrWhiteSpace(storedVal)) return default(TValue);
                var bytes = Convert.FromBase64String(storedVal);
                using (var stream = new MemoryStream(bytes))
                {
                    valueCache = (TValue)converter.Deserialize(stream);
                    valueCacheValid = true;
                }
                return valueCache;
            }
            set
            {
                using (var stream = new MemoryStream())
                {
                    converter.Serialize(stream, value);
                    var bytes = stream.ToArray();
                    property.SetValue(that, Convert.ToBase64String(bytes));
                    valueCacheValid = false;
                }
            }
        }

        public Base64Field(T that, string propertyName)
        {
            this.that = that;
            property = typeof(T).GetProperty(propertyName);
            if (property.PropertyType != typeof(string)) throw new InvalidOperationException("ArrayParameter can write only to string properties");
            if (converter == null)
                converter = new BinaryFormatter();
        }
    }
}
