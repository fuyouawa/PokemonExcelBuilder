using Newtonsoft.Json;

namespace PokemonExcelBuilder;

public static class JsonExtension
{
    public static string ToJson<T>(this T val)
    {
        if (val == null)
        {
            return string.Empty;
        }

        return JsonConvert.SerializeObject(val);
    }
}