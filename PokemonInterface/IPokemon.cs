namespace PokemonInterface;

public interface IPokemon
{
    string Name { get; }
    int Health { get; set; }

    void Attack(IPokemon pokemon);
    void LooseHealth(int damage);
}