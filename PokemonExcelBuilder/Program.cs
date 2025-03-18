using Newtonsoft.Json;

namespace PokemonExcelBuilder
{
    internal class Program
    {
        private static readonly string InputJsonDataDir = "InputJsonData";
        private static readonly string OutputExcelDir = "OutputExcel";

        static void BuildGen(int genNum, string genName)
        {
            var inputDir = Path.Combine(InputJsonDataDir, genName);
            var outputDir = Path.Combine(OutputExcelDir, genName);

            var pokemonsInputPath = Path.Combine(inputDir, "pokemons.json");
            var abilitiesInputPath= Path.Combine(inputDir, "abilities.json");
            var itemsInputPath= Path.Combine(inputDir, "items.json");
            var typechartInputPath= Path.Combine(inputDir, "typechart.json");
            var movesInputPath= Path.Combine(inputDir, "moves.json");

            var pokemonsOutputPath = Path.Combine(outputDir, "PokemonDescStore.xlsx");
            var abilitiesOutputPath= Path.Combine(outputDir, "AbilityDescStore.xlsx");
            var itemsOutputPath= Path.Combine(outputDir, "ItemDescStore.xlsx");
            var typechartOutputPath= Path.Combine(outputDir, "TypeChartStore.xlsx");
            var movesOutputPath= Path.Combine(outputDir, "MoveDescStore.xlsx");

            var json = File.ReadAllText(pokemonsInputPath);
            var pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
            var pokemonDescStore = PokemonBuild.ProcessToDescStore(genNum, pokemons!);
            ExcelExport.ExportToExcel(pokemonDescStore, pokemonsOutputPath, "PokemonDesc");

            json = File.ReadAllText(movesInputPath);
            var moves = JsonConvert.DeserializeObject<List<Move>>(json);
            var moveDescStore = MoveBuild.ProcessToDescStore(genNum, moves!);
            ExcelExport.ExportToExcel(moveDescStore, movesOutputPath, "MoveDesc");
        }

        static void Main(string[] args)
        {
            JsonConvert.DefaultSettings += () => new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            BuildGen(1, "gen1");
        }
    }
}
