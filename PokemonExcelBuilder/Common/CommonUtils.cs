namespace PokemonExcelBuilder;

public static class CommonUtils
{
    public static string GetExportType(string type)
    {
        switch (type)
        {
            case "Normal":
                return "一般";
            case "Flying":
                return "飞行";
            case "Fire":
                return "火";
            case "Psychic":
                return "超能力";
            case "Water":
                return "水";
            case "Bug":
                return "虫";
            case "Electric":
                return "电";
            case "Rock":
                return "岩石";
            case "Grass":
                return "草";
            case "Ghost":
                return "幽灵";
            case "Ice":
                return "冰";
            case "Dragon":
                return "龙";
            case "Fighting":
                return "格斗";
            case "Dark":
                return "恶";
            case "Poison":
                return "毒";
            case "Steel":
                return "钢";
            case "Ground":
                return "地面";
            case "Fairy":
                return "妖精";
            case "???":
                return "未知";
            default:
                throw new NotImplementedException(type);
        }
    }
}