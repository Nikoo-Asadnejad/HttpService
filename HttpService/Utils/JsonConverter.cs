
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpService.Utils;
public static class JsonConverter
  {
    public static string Serialize<T>(this T obj)
    => JsonConverter.Serialize(obj);

    public static T Deserialize<T>(this string json)
    => JsonConverter.Deserialize<T>(json);

  }

