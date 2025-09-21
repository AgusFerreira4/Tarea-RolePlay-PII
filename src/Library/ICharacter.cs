namespace Library;

public interface ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDefense { get; set; }
    public int TotalDefense { get;}
    public int BaseDamage { get; set; }
    public int TotalDamage { get;}

    public Weapon Weapon { get; set; }
    public Armor Armor { get; set; }

    public void Attack(ICharacter character)
    { }

    public void Heal(ICharacter character) { }
    
    public void ChangeItem(IItem item) { }

    public void DropItem(IItem item)
    { }
}