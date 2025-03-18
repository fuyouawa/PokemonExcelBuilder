namespace PokemonExcelBuilder;

public class PokemonDesc
{
    [DescProperty("ID", IsIndex = true)] public int Id { get; set; }
    [DescProperty("编号")] public int Num { get; set; }
    [DescProperty("名称")] public string Name { get; set; }
    [DescProperty("世代")] public int Gen { get; set; }
    [DescProperty("基础形态")] public string BaseForme { get; set; }
    [DescProperty("其他形态", IsList = true)] public string OtherFormes { get; set; }
    [DescProperty("能力", IsList = true)] public string Abilities { get; set; }
    [DescProperty("类型", IsList = true)] public string Types { get; set; }
    [DescProperty("进化前")] public string Prevo { get; set; }
    [DescProperty("进化")] public string Evos { get; set; }
    [DescProperty("进化等级")] public int EvoLevel { get; set; }
    [DescProperty("分级")] public string Tier { get; set; }
    [DescProperty("双打分级")] public string DoublesTier { get; set; }
    [DescProperty("全国图鉴分级")] public string NatDexTier { get; set; }
    [DescProperty("蛋组", IsList = true)] public string EggGroups { get; set; }
    [DescProperty("可捕捉")] public bool CanHatch { get; set; }
    [DescProperty("性别比率")] public string GenderRatio { get; set; }
    [DescProperty("血量")] public int Hp { get; set; }
    [DescProperty("攻击")] public int Atk { get; set; }
    [DescProperty("防御")] public int Def { get; set; }
    [DescProperty("特攻")] public int Spa { get; set; }
    [DescProperty("特防")] public int Spd { get; set; }
    [DescProperty("速度")] public int Spe { get; set; }
    [DescProperty("重量（kg）")] public float WeightKg { get; set; }
    [DescProperty("升高（m）")] public float HeightM { get; set; }
}