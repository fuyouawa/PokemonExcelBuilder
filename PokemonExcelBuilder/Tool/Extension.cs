using Newtonsoft.Json;

namespace PokemonExcelBuilder;

public static class Extension
{
    public static string ToJson<T>(this T val)
    {
        if (val == null)
        {
            return string.Empty;
        }

        return JsonConvert.SerializeObject(val);
    }

    public static string ToExport(this IEnumerable<string> values)
    {
        return string.Join(", ", values);
    }
}