namespace Library;

public class Armor : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Healing { get; set; }
    public int Defense { get; set; }

    public Armor(string type, int defense, string name)
    {
        Defense = defense;
        Name = name;
        Damage = 0;
        Healing = 0;
    }

}