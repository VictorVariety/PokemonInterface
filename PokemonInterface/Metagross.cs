using static System.Net.Mime.MediaTypeNames;

namespace PokemonInterface;

public class Metagross : IPokemon
{
    public string Name { get; set; }

    public int Health { get; set; }
    public Metagross()
    {
        Name = "Metagross";
        Health = 100;
    }


    public void LooseHealth(int damage)
    {
        Health -= damage;
    }
    public void Attack(IPokemon pokemon)
    {
        if (new Random().Next(0, 2) == 1)
            Psychic(pokemon);
        else
            CometPunch(pokemon);
    }


    private void Psychic(IPokemon pokemon)
    {
        const int damage = 70;
        pokemon.LooseHealth(damage);
        Console.WriteLine($"{Name} uses Psychic and deals {damage}");
    }
    private void CometPunch(IPokemon pokemon)
    {
        const int damage = 100;
        pokemon.LooseHealth(damage);
        Console.WriteLine($"{Name} uses Comet Punch and deals {damage}");
    }
}