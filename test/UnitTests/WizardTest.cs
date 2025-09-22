using Library;

namespace LibraryTests
{
    [TestClass]
    // Decidimos hacer test solo para wizard, ya que esta clase tiene contenidos los metodos de las demás razas y un poco más
    // O sea que si funciona esta funcionan las demás
    public class WizardTests
    {
        private Weapon bookOfSpells;
        private Armor armor;
        private Wizard wizard;

        [TestInitialize]
        public void Setup()
        {
            var fireball = new Spell("Fireball", "Damage", 0, 20, 30);
            bookOfSpells = new Weapon("Libro de Hechizos", "Book of spells", 5, new List<Spell> { fireball });

            armor = new Armor ("tunic", 3, "cool tunic") ;

            wizard = new Wizard("Gandalf", bookOfSpells);
            wizard.Armor = armor;
        }

        [TestMethod]
        public void Constructor_InitializeProperties()
        {
            Assert.AreEqual("Gandalf", wizard.Name);
            Assert.AreEqual(100, wizard.HP);
            Assert.AreEqual(100, wizard.Mana);
            Assert.AreEqual(2, wizard.Damage);
            Assert.AreEqual(2, wizard.Defense);
            Assert.AreEqual(bookOfSpells, wizard.Weapon);
        }

        [TestMethod]
        public void GetTotalAttack_ReturnCorrectValue_WithoutArmorDamage()
        {
            int expected = wizard.Damage + armor.Damage + bookOfSpells.Damage; // 2 + 0 + 5 = 7
            Assert.AreEqual(expected, wizard.GetTotalAttack());
        }

        [TestMethod]
        public void GetTotalDefense_ShouldReturnCorrectValue()
        {
            int expected = wizard.Defense + bookOfSpells.Defense + armor.Defense; // 2 + 0 + 3 = 5
            Assert.AreEqual(expected, wizard.GetTotalDefense());
        }

        [TestMethod]
        public void Attack_ShouldReduceEnemyHpBasedOnDefense()
        {
            var enemy = new Wizard("Saruman", new Weapon("Báculo", "Staff", 3, new List<Spell>()));
            enemy.Defense = 5;

            wizard.Attack(enemy);

            int expectedHp = wizard.GetTotalAttack() - enemy.Defense; // 7 - 5 = 2
            Assert.AreEqual(expectedHp, enemy.HP);
        }

        [TestMethod]
        public void ThrowSpell_ShouldReduceMana_WhenSpellExistsInBook()
        {
            var spell = bookOfSpells.Spells[0]; // Fireball (misma instancia, Contains será true)
            int initialMana = wizard.Mana;

            wizard.ThrowSpell(spell);

            Assert.AreEqual(initialMana - spell.ManaCost, wizard.Mana);
        }

        [TestMethod]
        public void ThrowSpell_ShouldNotReduceMana_WhenSpellNotInBook()
        {
            var lightning = new Spell("Lightning", "Damage", 0, 30, 40); // nueva instancia, no está en el libro
            int initialMana = wizard.Mana;

            wizard.ThrowSpell(lightning);

            Assert.AreEqual(initialMana, wizard.Mana);
        }

        [TestMethod]
        public void Heal_ShouldRestoreHpTo100()
        {
            wizard.HP = 20;

            wizard.Heal(wizard);

            Assert.AreEqual(100, wizard.HP);
        }

        [TestMethod]
        public void ChangeItem_ShouldChangeWeapon()
        {
            var newWeapon = new Weapon("Vara mágica", "Staff", 10, new List<Spell>());
            wizard.ChangeItem(newWeapon);

            Assert.AreEqual(newWeapon, wizard.Weapon);
        }

        [TestMethod]
        public void ChangeItem_ShouldChangeArmor()
        {
            var newArmor = new Armor ("helmet", 4, "cool helmet");
            wizard.ChangeItem(newArmor);

            Assert.AreEqual(newArmor, wizard.Armor);
        }

        [TestMethod]
        public void DropItem_ShouldRemoveWeapon()
        {
            wizard.DropItem(bookOfSpells);

            Assert.IsNull(wizard.Weapon);
        }

        [TestMethod]
        public void DropItem_ShouldRemoveArmor()
        {
            wizard.DropItem(armor);

            Assert.IsNull(wizard.Armor);
        }
    }
}
