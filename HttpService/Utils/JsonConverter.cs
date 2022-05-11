using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Utils
{
  public static class JsonConverter
  {
    public async static Task<string> Serialize<T>(this T obj)
    => JsonConvert.SerializeObject(obj);

    public async static Task<T> Deserialize<T>(this string json)
    => JsonConvert.DeserializeObject<T>(json);

  }
}
