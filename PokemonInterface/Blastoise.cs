namespace PokemonInterface;

public class Blastoise : IPokemon
{
    public string Name { get; }
    public int Health { get; set; }

    public Blastoise()
    {
        Name = "Blastoise";
        Health = 100;
    }


    public void LooseHealth(int damage)
    {
        Health -= damage;
    }
    public void Attack(IPokemon pokemon)
    {
        if (new Random().Next(0, 2) == 1) 
            HydroPump(pokemon);
        else
            IceBeam(pokemon);
    }


    private void IceBeam(IPokemon pokemon)
    {
        const int damage = 70;
        pokemon.LooseHealth(damage);
        Console.WriteLine($"{Name} uses Ice Beam and deals {damage}");
    }
    private void HydroPump(IPokemon pokemon)
    {
        const int damage = 100;
        pokemon.LooseHealth(damage);
        Console.WriteLine($"{Name} uses Hydro Pump and deals {damage}");
    }
}