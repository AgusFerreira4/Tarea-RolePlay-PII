namespace Library;

public class Weapon : IItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Damage { get; set; }

    public int Defense { get; set; }
    public int Healing { get; set; }
    public List<Spell> Spells { get; set; }

    public Weapon(string name, string type, int damage, List<Spell> spells)
    {
        Name = name;
        Type = type;
        Damage = damage;
        Defense = 0;
        Healing = 0;
        Spells = spells;
    }

    public void AddSpell(Spell spell)
    {
        Spells.Add(spell);
    }

    public void ClearSpell(Spell spell)
    {
        Spells.Clear();
    }

    public void DeleteSpellByName(string name)
    {
        Spells.RemoveAll(spell => spell.Name == name);
    }

    public void PrintSpells()
    {
        foreach (Spell spell in Spells)
        {
            Console.WriteLine(spell.Name);
        }
    }
}