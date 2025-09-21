namespace Library;

public interface IItem
{
    public string Name { get; set; }
    public int Defense { get; set; }
    public int Damage { get; set; }
    public int Healing { get; set; }
}