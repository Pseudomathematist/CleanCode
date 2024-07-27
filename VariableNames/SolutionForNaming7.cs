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
