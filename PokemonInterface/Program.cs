using PokemonInterface;


var wildPokemon = new List<IPokemon>()
{
    new Munchlax(),
    new Metagross(),
    new Blastoise()
};

var magikarp = new Magikarp();
var pokemon = GetWildPokemon(wildPokemon);


Console.WriteLine($"The great {magikarp.Name} is sizing up a {pokemon.Name} in the wild, and a battle ensues!");
while (magikarp.Health > 0)
{
    Console.WriteLine();
    magikarp.Attack(pokemon);
    pokemon.Attack(magikarp);
    Console.WriteLine();
}
Console.WriteLine($"{pokemon.Name} defeated {magikarp.Name}");
Console.WriteLine($"And gained no experience, useless fish..");



IPokemon GetWildPokemon(List<IPokemon> pokemonList)
{
    var randomIndex = new Random().Next(0, pokemonList.Count);
    return pokemonList[randomIndex];
}