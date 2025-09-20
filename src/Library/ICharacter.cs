namespace Library;

public interface ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public Weapon Weapon { get; set; }

    public void Attack(ICharacter character)
    {
        
    }

    public void Heal(ICharacter character)
    {
        
    }

    public void GiveItem(IItem item)
    {
        
    }

    public void ChangeItem(IItem item)
    {
        
    }

    public void DropItem(IItem item)
    {
        
    }
}