using Newtonsoft.Json;

namespace PokemonExcelBuilder;

public class Boosts
{
    public int? Atk;
    public int? Def;
    public int? Spa;
    public int? Spd;
    public int? Spe;
}

public class MoveEffect
{
    public int? Chance;
    public Boosts? Boosts;
}

public class ZMove
{
    public int? BasePower;
    public string? Effect;
    public Boosts? Boost;
}

public class MaxMove
{
    public int? BasePower;
}

public class Move
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string FullName { get; set; }
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
    public string Type { get; set; }
    public string Target { get; set; }
    public int BasePower { get; set; }
    public int Accuracy { get; set; }
    public int CritRatio { get; set; }
    public string BaseMoveType { get; set; }
    public MoveEffect? Secondary { get; set; }
    public List<MoveEffect>? Secondaries { get; set; }
    public bool HasSheerForce { get; set; }
    public int Priority { get; set; }
    public string Category { get; set; }
    public bool IgnoreNegativeOffensive { get; set; }
    public bool IgnorePositiveDefensive { get; set; }
    public bool IgnoreOffensive { get; set; }
    public bool IgnoreDefensive { get; set; }
    public List<string>? IgnoreImmunity { get; set; }
    public bool IgnoreEvasion { get; set; }
    public int Pp { get; set; }
    public bool NoPPBoosts { get; set; }
    public string? IsZ { get; set; }
    // public bool IsMax { get; set; }
    public Dictionary<string, int>? Flags { get; set; }
    public string PressureTarget { get; set; }
    public string NonGhostTarget { get; set; }
    public bool IgnoreAbility { get; set; }
    public bool SpreadHit { get; set; }
    public bool ForceSTAB { get; set; }
    public MaxMove? MaxMove { get; set; }
    public ZMove? ZMove { get; set; }
    public string ContestType { get; set; }
}