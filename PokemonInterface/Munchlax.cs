namespace PokemonInterface;

public class Munchlax : IPokemon
{
    public string Name { get; }
    public int Health { get; set; }

    public Munchlax()
    {
        Name = "Munchlax";
        Health = 90;
    }


    public void LooseHealth(int damage)
    {
        Health -= damage;
    }
    public void Attack(IPokemon pokemon)
    {
        Slam(pokemon);
    }


    private void Slam(IPokemon pokemon)
    {
        const int damage = 40;
        pokemon.LooseHealth(damage);
        Console.WriteLine($"{Name} uses Slam and deals {damage}");
    }
}