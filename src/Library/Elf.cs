namespace Library;

public class Elf: ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Defense { get; set; }

    public int Damage { get; set; }
    public Weapon Weapon { get; set; }
    public Armor Armor { get; set; }

    public Elf (string unName)
    {
        Name = unName;
        HP = 100;
        Defense = 1;
        Damage = 3;

    }

    public void Attack(ICharacter character)
    {
     
    }
    
    public void Heal(ICharacter character)
    {
        character.HP = 100; 
    }
    

    public void ChangeItem(IItem item)
    {
        switch (item)
        {
            case Armor armor:
                this.Armor = armor;
                break;
            case Weapon weapon:
                this.Weapon = weapon;
                break;
            default:
                throw new ArgumentException("El item no es equipable", nameof(item));
            
        }
    }
    
    public void DropItem(IItem item)
    {
        switch (item)
        {
            case Armor armor when Armor==armor:
                this.Armor = null;
                break;
            case Weapon weapon when Weapon== weapon:
                this.Weapon = null;
                break;
            default:
                throw new ArgumentException("El personaje no tiene items equipados", nameof(item));
            
        }
    }
    
}