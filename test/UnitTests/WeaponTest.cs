using Library;

namespace UnitTests;

/*
 Se testea la clase Weapon porque tiene lo mismo que Armor ya que comarten interfaz, y ademas
 se pueden testear sus metodos unicos, osea si funciona esto, funciona spell y armor ya que weapon utiliza de ambas.
 */ 
[TestClass]
public class WeaponTest
{
    // Se inicializan las instancias como campos de la clase para que se puedan usar en cada metodo
    private Weapon bookOfDarkness;
    private Spell freeze;
    private Spell magicMissile;
    
    [TestInitialize]
    public void Setup()
    {
        bookOfDarkness = new Weapon("Book of Darkness", "Book", 4, new List<Spell>());
        freeze = new Spell("Freeze", "Ice", 0, 4, 6);
        magicMissile = new Spell("Magic Missile", "Void", 0, 8, 12);
    }
    //Se testea que se puedan agregar hechizos a las armas
    [TestMethod]
    public void SpellsInWeapon_ShouldBeTwo()
    {
        
        bookOfDarkness.AddSpell(freeze);
        bookOfDarkness.AddSpell(magicMissile);

        Assert.AreEqual(2, bookOfDarkness.Spells.Count);
    }
    
    //Se testea que se puedan eliminar hechizos
    [TestMethod]
    public void SpellsInWeapon_ShouldBeCleared()
    {
        Weapon bookOfDarkness = new Weapon("Book of Darkness", "Book", 4, new List<Spell>());
        Spell freeze = new Spell("Freeze", "Ice", 0, 4, 6);
        Spell magicMissile = new Spell("Magic Missile", "Void", 0, 8, 12);
        
        bookOfDarkness.AddSpell(freeze);
        bookOfDarkness.AddSpell(magicMissile);
        
        bookOfDarkness.ClearSpell();

        Assert.AreEqual(0, bookOfDarkness.Spells.Count);
    }
    
    //Se testea que se puedan eliminar hechizos por el nombre, si el nombre no es correcto no se elimina
    [TestMethod]
    public void SpellInWeapon_ShouldBeClearedByName()
    {
        Weapon bookOfDarkness = new Weapon("Book of Darkness", "Book", 4, new List<Spell>());
        Spell freeze = new Spell("Freeze", "Ice", 0, 4, 6);
        Spell magicMissile = new Spell("Magic Missile", "Void", 0, 8, 12);
        
        bookOfDarkness.AddSpell(freeze);
        bookOfDarkness.AddSpell(magicMissile);
        
        bookOfDarkness.DeleteSpellByName("Magic Missile");

        Assert.IsFalse(bookOfDarkness.Spells.Any(s => s.Name == "Magic Missile"));
    }
    
    [TestMethod]
    public void SpellInWeapon_ShouldNotBeCleared_IfNameIsNotInWeapon()
    {
        Weapon bookOfDarkness = new Weapon("Book of Darkness", "Book", 4, new List<Spell>());
        Spell freeze = new Spell("Freeze", "Ice", 0, 4, 6);
        Spell magicMissile = new Spell("Magic Missile", "Void", 0, 8, 12);
        
        bookOfDarkness.AddSpell(freeze);
        bookOfDarkness.AddSpell(magicMissile);
        
        bookOfDarkness.DeleteSpellByName("Random Spell");

        Assert.IsTrue(bookOfDarkness.Spells.Any(s => s.Name == "Magic Missile"));
    }
}