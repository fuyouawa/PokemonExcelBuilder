using System.Diagnostics;
using Newtonsoft.Json;

namespace PokemonExcelBuilder;

public static class PokemonBuild
{
    public static List<PokemonDesc> ProcessToDescStore(int gen, List<Pokemon> pokemons)
    {
        var total = new List<PokemonDesc>();

        int i = 1;
        foreach (var pokemon in pokemons)
        {
            if (pokemon.Gen > gen || pokemon.IsNonstandard != null)
                continue;

            if (!string.IsNullOrEmpty(pokemon.Forme) && pokemon.OtherFormes is { Count: > 0 })
            {
                Console.WriteLine(pokemon.Name);
                throw new Exception();
            }

            total.Add(new PokemonDesc
            {
                Id = i,
                Name = pokemon.Name,
                Num = pokemon.Num,
                Gen = pokemon.Gen,
                BaseForme = pokemon.BaseSpecies,
                OtherFormes = (pokemon.OtherFormes is { Count: > 0 }
                    ? pokemon.OtherFormes
                    : [pokemon.Forme]).Where(IsValidPokemon).ToJson(),
                Abilities = pokemon.Abilities?.Select(x => x.Value).ToJson(),
                Types = pokemon.Types.ToJson(),
                Prevo = pokemon.Prevo,
                Evos = pokemon.Evos?.Where(IsValidPokemon).ToJson(),
                EvoLevel = pokemon.EvoLevel,
                Tier = pokemon.Tier,
                DoublesTier = pokemon.DoublesTier,
                NatDexTier = pokemon.NatDexTier,
                EggGroups = pokemon.EggGroups.ToJson(),
                CanHatch = pokemon.CanHatch,
                GenderRatio = pokemon.GenderRatio.ToJson(),
                Hp = pokemon.BaseStats.Hp,
                Atk = pokemon.BaseStats.Atk,
                Def = pokemon.BaseStats.Def,
                Spa = pokemon.BaseStats.Spa,
                Spd = pokemon.BaseStats.Spd,
                Spe = pokemon.BaseStats.Spe,
                WeightKg = pokemon.Weightkg,
                HeightM = pokemon.Heightm,
            });
            i++;
        }

        return total;

        bool IsValidPokemon(string pokemonName)
        {
            var idx = pokemons.FindIndex(p => p.Name == pokemonName && p.Gen <= gen);
            return idx > 0;
        }
    }
}