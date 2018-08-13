using LinqExamples.Model;
using System.Collections.Generic;

namespace LinqExamples
{
    public static class Repository
    {
        public static List<Pokemon> GetPokemons()
        {
            var pokemons = new List<Pokemon>();

            pokemons.Add(new Pokemon(1, "Bulbassaur", TypeEnum.Grass, TypeEnum.Poison));
            pokemons.Add(new Pokemon(2, "Ivysaur", TypeEnum.Grass, TypeEnum.Poison));
            pokemons.Add(new Pokemon(3, "Venusaur", TypeEnum.Grass, TypeEnum.Poison));

            pokemons.Add(new Pokemon(4, "Charmander", TypeEnum.Fire));
            pokemons.Add(new Pokemon(5, "Charmeleon", TypeEnum.Fire));
            pokemons.Add(new Pokemon(6, "Charizard", TypeEnum.Fire, TypeEnum.Flying));

            pokemons.Add(new Pokemon(7, "Squirtle", TypeEnum.Water));
            pokemons.Add(new Pokemon(8, "Wartortle", TypeEnum.Water));
            pokemons.Add(new Pokemon(9, "Bastloise", TypeEnum.Water));

            pokemons.Add(new Pokemon(10, "Caterpie", TypeEnum.Bug));
            pokemons.Add(new Pokemon(11, "Metapod", TypeEnum.Bug));
            pokemons.Add(new Pokemon(12, "Butterfree", TypeEnum.Bug, TypeEnum.Flying));

            pokemons.Add(new Pokemon(13, "Weedle", TypeEnum.Bug, TypeEnum.Poison));
            pokemons.Add(new Pokemon(14, "Kakuna", TypeEnum.Bug, TypeEnum.Poison));
            pokemons.Add(new Pokemon(15, "Beedrill", TypeEnum.Bug, TypeEnum.Poison));

            pokemons.Add(new Pokemon(16, "Pidgey", TypeEnum.Flying, TypeEnum.Normal));
            pokemons.Add(new Pokemon(17, "Pidgeotto", TypeEnum.Flying, TypeEnum.Normal));
            pokemons.Add(new Pokemon(18, "Pidgeot", TypeEnum.Flying, TypeEnum.Normal));

            pokemons.Add(new Pokemon(19, "Rattata", TypeEnum.Normal));
            pokemons.Add(new Pokemon(20, "Raticate", TypeEnum.Normal));

            pokemons.Add(new Pokemon(21, "Spearow", TypeEnum.Flying, TypeEnum.Normal));
            pokemons.Add(new Pokemon(22, "Fearow", TypeEnum.Flying, TypeEnum.Normal));

            pokemons.Add(new Pokemon(23, "Ekans", TypeEnum.Poison));
            pokemons.Add(new Pokemon(24, "Arbok", TypeEnum.Poison));

            pokemons.Add(new Pokemon(25, "Pikachu", TypeEnum.Electric));
            pokemons.Add(new Pokemon(26, "Raichu", TypeEnum.Electric));

            pokemons.Add(new Pokemon(27, "Sandshrew", TypeEnum.Ground));
            pokemons.Add(new Pokemon(28, "Sandslash", TypeEnum.Ground));

            pokemons.Add(new Pokemon(29, "Nidoran♀", TypeEnum.Poison));
            pokemons.Add(new Pokemon(30, "Nidorina", TypeEnum.Poison));
            pokemons.Add(new Pokemon(31, "Nidoqueen", TypeEnum.Poison, TypeEnum.Ground));

            pokemons.Add(new Pokemon(32, "Nidoran♂♀", TypeEnum.Poison));
            pokemons.Add(new Pokemon(33, "Nidorino", TypeEnum.Poison));
            pokemons.Add(new Pokemon(34, "Nidoqueen", TypeEnum.Poison, TypeEnum.Ground));

            pokemons.Add(new Pokemon(35, "Clefairy", TypeEnum.Fairy));
            pokemons.Add(new Pokemon(36, "Clefable", TypeEnum.Fairy));

            pokemons.Add(new Pokemon(37, "Vulpix", TypeEnum.Fire));
            pokemons.Add(new Pokemon(38, "Ninetales", TypeEnum.Fire));

            pokemons.Add(new Pokemon(39, "Jigglypuff", TypeEnum.Normal, TypeEnum.Fairy));
            pokemons.Add(new Pokemon(40, "Wigglytuff", TypeEnum.Normal, TypeEnum.Fairy));

            return pokemons;
        }
    }
}

