namespace PokemonExcelBuilder;

public class DescPropertyAttribute : Attribute
{
    public string Name { get; }
    public string? Type { get; set; }
    public bool IsList { get; set; } = false;
    public bool IsIndex { get; set; }= false;
    public bool EmptyIfZero { get; set; } = true;

    public DescPropertyAttribute(string name)
    {
        Name = name;
    }
}