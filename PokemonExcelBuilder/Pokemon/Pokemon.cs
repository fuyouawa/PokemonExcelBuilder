namespace PokemonExcelBuilder;

public class Pokemon
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Fullname { get; set; }
    public string EffectType { get; set; }
    public bool Exists { get; set; }
    public int Num { get; set; }
    public int Gen { get; set; }
    public string ShortDesc { get; set; }
    public string Desc { get; set; }
    public object? IsNonstandard { get; set; }
    public bool NoCopy { get; set; }
    public bool AffectsFainted { get; set; }
    public string SourceEffect { get; set; }
    public string BaseSpecies { get; set; }
    public string Forme { get; set; }
    public string BaseForme { get; set; }
    public List<string>? OtherFormes { get; set; }
    public List<string>? FormeOrder { get; set; }
    public string Spriteid { get; set; }
    public Dictionary<string, string>? Abilities { get; set; }
    public List<string>? Types { get; set; }
    public string Prevo { get; set; }
    public string Tier { get; set; }
    public string DoublesTier { get; set; }
    public string NatDexTier { get; set; }
    public List<string>? Evos { get; set; }
    public int EvoLevel { get; set; }
    public bool Nfe { get; set; }
    public List<string>? EggGroups { get; set; }
    public bool CanHatch { get; set; }
    public string Gender { get; set; }
    public GenderRatio GenderRatio { get; set; }
    public BaseStats BaseStats { get; set; }
    public int Bst { get; set; }
    public float Weightkg { get; set; }
    public int Weighthg { get; set; }
    public float Heightm { get; set; }
    public string Color { get; set; }
    public List<string>? Tags { get; set; }
    public bool UnreleasedHidden { get; set; }
    public bool MaleOnlyHidden { get; set; }
    public string CanGigantamax { get; set; }
    public bool GmaxUnreleased { get; set; }
    public bool CannotDynamax { get; set; }
}

public class GenderRatio
{
    public float M { get; set; }
    public float F { get; set; }
}

public class BaseStats
{
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Spa { get; set; }
    public int Spd { get; set; }
    public int Spe { get; set; }
}