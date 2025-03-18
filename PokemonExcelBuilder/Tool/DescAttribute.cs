namespace PokemonExcelBuilder;

public class DescPropertyAttribute : Attribute
{
    public string Name { get; }
    public bool IsList { get; set; }
    public bool IsIndex { get; set; }
    public bool EmptyIfZero { get; set; }

    public DescPropertyAttribute(string name)
    {
        Name = name;
    }
}