using Newtonsoft.Json;

namespace PokemonExcelBuilder;

public static class MoveBuild
{
    public class ZMoveDesc
    {
        public string? Type;
        public int? BasePower;
        public string? Effect;
        public Boosts? Boost;
    }

    public static List<MoveDesc> ProcessToDescStore(int gen, List<Move> moves)
    {
        var total = new List<MoveDesc>();
        
        int i = 1;
        foreach (var move in moves)
        {
            if (move.Gen > gen || move.IsNonstandard != null)
                continue;
            
            total.Add(new MoveDesc()
            {
                Id = i,
                Name = move.Name,
                Gen = move.Gen,
                Num = move.Num,
                BasePower = move.BasePower,
                PP = move.Pp,
                Type = CommonUtils.GetExportType(move.Type),
                Category = move.Category,
                Target = move.Target,
                Accuracy = move.Accuracy,
                CritRatio = move.CritRatio,
                Secondaries = move.Secondaries.ToJson(),
                Priority = move.Priority,
                IgnoreOffensive = move.IgnoreOffensive ? "all" : string.Empty,
                IgnoreDefensive = move.IgnoreDefensive ? "all" : string.Empty,
                IgnoreImmunity = move.IgnoreImmunity.ToJson(),
                IgnoreEvasion = move.IgnoreEvasion ? "all" : string.Empty,
                HasSheerForce = move.HasSheerForce,
                NoPPBoosts = move.NoPPBoosts,
                IgnoreAbility = move.IgnoreAbility,
                ZMove = (move.IsZ == null && move.ZMove == null
                    ? null
                    : new ZMoveDesc()
                    {
                        Type = move.IsZ,
                        BasePower = move.ZMove?.BasePower,
                        Effect = move.ZMove?.Effect,
                        Boost = move.ZMove?.Boost
                    }).ToJson()
            });
            i++;
        }

        return total;
    }
}