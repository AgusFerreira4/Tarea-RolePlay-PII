namespace Library;

public class Elf: ICharacter
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDefense { get; set; }

    public int TotalDefense
    {
        get
        {
            return this.BaseDefense + this.Armor.Defense + this.Weapon.Defense;
        }
    }

    public int BaseDamage { get; set; }
    public int TotalDamage
    {
        get
        {
            return this.BaseDamage + this.Armor.Damage + this.Weapon.Damage;
        }
    }
    public Weapon Weapon { get; set; }
    public Armor Armor { get; set; }

    public Elf (string unName, Weapon unWeapon)
    {
        this.Name = unName;
        this.HP = 100;
        this.BaseDefense = 1;
        this.BaseDamage = 3;
        this.Weapon = unWeapon;

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