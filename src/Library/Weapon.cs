namespace Library;

public class Weapon : IItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Damage { get; set; }

    public int Defense { get; set; }
    public int Healing { get; set; }

    public Weapon(string name, string type, int damage)
    {
        Name = name;
        Type = type;
        Damage = damage;
        Defense = 0;
        Healing = 0;

    }
}