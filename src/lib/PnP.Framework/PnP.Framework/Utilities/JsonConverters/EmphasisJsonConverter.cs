﻿using Newtonsoft.Json;
using System;

namespace PnP.Framework.Utilities.JsonConverters
{
    /// <summary>
    /// Converts Emphasis values into the supported integer format
    /// </summary>
    public class EmphasisJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (true);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object initialValue = reader.Value;
            int result = 0;
            
            if (initialValue != null)
            {
                var stringValue = initialValue.ToString();
                if (!string.IsNullOrEmpty(stringValue) &&
                    stringValue.Equals("undefined", StringComparison.InvariantCultureIgnoreCase))
                {
                    result = 0;
                }
                else if (!int.TryParse(stringValue, out result))
                {
                    result = 0;
                }
            }

            return (result);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value!=null)
            {
                int zoneEmphasis = 0;
                int.TryParse(value.ToString(), out zoneEmphasis);
                writer.WriteValue(zoneEmphasis);
            }
        }
    }
}
