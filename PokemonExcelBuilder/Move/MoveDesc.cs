namespace PokemonExcelBuilder;

public class MoveDesc
{
    [DescProperty("ID", IsIndex = true)] public int Id { get; set; }
    [DescProperty("编号")] public int Num { get; set; }
    [DescProperty("名称")] public string Name { get; set; }
    [DescProperty("世代")] public int Gen { get; set; }
    [DescProperty("威力")] public int BasePower { get; set; }
    [DescProperty("点数")] public int PP { get; set; }
    [DescProperty("属性")] public string Type { get; set; }
    [DescProperty("分类")] public string Category { get; set; }
    [DescProperty("目标")] public string Target { get; set; }
    [DescProperty("命中率")] public int Accuracy { get; set; }
    [DescProperty("暴击率")] public int CritRatio { get; set; }
    [DescProperty("副作用", IsList = true)] public string Secondaries { get; set; }
    [DescProperty("优先级")] public int Priority { get; set; }
    [DescProperty("忽略进攻增益")] public string IgnoreOffensive { get; set; }
    [DescProperty("忽略防御增益")] public string IgnoreDefensive { get; set; }
    [DescProperty("忽略免疫")] public string IgnoreImmunity { get; set; }
    [DescProperty("忽略闪避")] public string IgnoreEvasion { get; set; }
    [DescProperty("有强行特性")] public bool HasSheerForce { get; set; }
    [DescProperty("无点数增加")] public bool NoPPBoosts { get; set; }
    [DescProperty("忽略特性")] public bool IgnoreAbility { get; set; }
    [DescProperty("Z招式")] public string ZMove { get; set; }
}