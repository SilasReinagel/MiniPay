﻿using System;
using Utf8Json;
using Utf8Json.Resolvers;

namespace MiniPay
{
    public static class Json
    {
        private static ReflectionValidation _validation = new ReflectionValidation();

        public static object ToObject(Type type, string json)
        {
            var obj = JsonSerializer.NonGeneric.Deserialize(type, json, StandardResolver.CamelCase);
            _validation
                .Validate(obj)
                .IfInvalid(x => throw new ArgumentException(x.IssuesMessage));
            return obj;
        }

        public static T ToObject<T>(string json)
        {
            var obj = JsonSerializer.Deserialize<T>(json, StandardResolver.CamelCase);            
            _validation
                .Validate(obj)
                .IfInvalid(x => throw new ArgumentException(x.IssuesMessage));
            return obj;
        }

        public static string ToString(object obj)
        {
            return JsonSerializer.ToJsonString(obj, StandardResolver.CamelCase);
        }

        public static byte[] ToBytes(object obj)
        {
            return JsonSerializer.Serialize(obj, StandardResolver.CamelCase);
        }
    }
}
