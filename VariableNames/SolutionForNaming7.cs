3.1
public class Rectangle
{
    private double width;
    private double height;

    private Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Rectangle CreateSquare(double side)
    {
        return new Rectangle(side, side);
    }

    public static Rectangle CreateRectangle(double width, double height)
    {
        return new Rectangle(width, height);
    }
}
//

public class Character
{
    private string name;
    private int level;
    private int strength;
    private int agility;
    private int intelligence;

    private Character(string name, int level, int strength, int agility, int intelligence)
    {
        this.name = name;
        this.level = level;
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
    }

    public static Character CreateStandardCharacter(string name)
    {
        return new Character(name, 1, 5, 5, 5);
    }

    public static Character CreateCharacter(string name, int level, int strength, int agility, int intelligence)
    {
        return new Character(name, level, strength, agility, intelligence);
    }

    public static Character CreateClassCharacter(string name, string className)
    {
        switch (className)
        {
            case "Warrior":
                return new Character(name, 1, 8, 3, 2);
            case "Mage":
                return new Character(name, 1, 2, 3, 8);
            case "Rogue":
                return new Character(name, 1, 3, 8, 2);
            default:
                return new Character(name, 1, 5, 5, 5);
        }
    }
}
//

public class Spell
{
    private string name;
    private int manaCost;
    private int damage;
    private SpellType type;

    // Приватный конструктор
    private Spell(string name, int manaCost, int damage, SpellType type)
    {
        this.name = name;
        this.manaCost = manaCost;
        this.damage = damage;
        this.type = type;
    }

    // Метод-фабрика для создания базового заклинания
    public static Spell CreateBasicSpell(string name, SpellType type)
    {
        return new Spell(name, 10, 5, type);
    }

    // Метод-фабрика для создания заклинания с заданными характеристиками
    public static Spell CreateSpell(string name, int manaCost, int damage, SpellType type)
    {
        return new Spell(name, manaCost, damage, type);
    }

    // Метод-фабрика для создания заклинания с увеличенным уроном
    public static Spell CreatePowerfulSpell(string name, SpellType type)
    {
        return new Spell(name, 20, 15, type);
    }

    // Другие методы класса Spell
}

public enum SpellType
{
    Fire,
    Ice,
    Lightning,
    Healing
}
3.2
Не использовал
