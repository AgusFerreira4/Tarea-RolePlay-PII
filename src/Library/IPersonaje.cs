namespace Library;

public interface IPersonaje
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Defense { get; set; }
    public Weapon Weapon { get; set; }

    public void Attack()
    {
        
    }

    public void Heal()
    {
        
    }

    public void GiveItem()
    {
        
    }

    public void ChangeItem()
    {
        
    }

    public void DropItem()
    {
        
    }
}