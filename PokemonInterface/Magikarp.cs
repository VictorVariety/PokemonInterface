namespace PokemonInterface;

public class Magikarp : IPokemon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool IsUseless { get; set; }

    public Magikarp()
    {
        Name = "Magikarp";
        Health = 150;
        IsUseless = true;
    }


    public void Attack(IPokemon pokemon)
    {
        Splash();
    }
    public void LooseHealth(int damage)
    {
        Health -= damage;
    }


    private void Splash()
    {
        Console.WriteLine($"{Name} splashes around but it achieves nothing. Undignifying..");
    }
}