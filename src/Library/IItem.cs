namespace Library;

public interface IItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Damage { get; set; }
    public int Healing { get; set; }
}