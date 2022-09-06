// See https://aka.ms/new-console-template for more information

Program.Main();

partial class Program
{
    public static void Main()
    {

        //a
        Coffee coffee = new HouseBlend();
        coffee = new Suger(coffee);
        coffee = new Whip(coffee);

        //b
        // The one thing that can not be changed is the original coffee sort, as the decorations are put on top

        // Demo 1
        coffee = new HouseBlend();
        coffee = new Suger(coffee);
        coffee = new Whip(coffee);
        Console.WriteLine("Cost should be: "+1.50+" / Coffee objects cost: "+coffee.Cost());

        // Demo 2
        coffee = new DarkRoast();
        coffee = new Milk(coffee);
        Console.WriteLine("Cost should be: " + 1.25 + " / Coffee objects cost: " + coffee.Cost());

        // Demo 3
        coffee = new Decaf();
        coffee = new Whip(coffee);
        Console.WriteLine("Cost should be: " + 1.50 + " / Coffee objects cost: " + coffee.Cost());


    }
}

abstract class Coffee
{
    public abstract double Cost();
    public abstract string Description();
}

class HouseBlend : Coffee
{
    public override double Cost()
    {
        return 1.20;
    }

    public override string Description()
    {
        return "HouseBlend";
    }
}

class DarkRoast : Coffee
{
    public override double Cost()
    {
        return 1.10;
    }

    public override string Description()
    {
        return "DarkRoast";
    }
}

class Decaf : Coffee
{
    public override double Cost()
    {
        return 1.40;
    }

    public override string Description()
    {
        return "Decaf";
    }
}

abstract class Decorator : Coffee
{

}

class Whip : Decorator
{
    private Coffee c;
    public Whip(Coffee c)
    {
        this.c = c;
    }
    public override double Cost()
    {
        return 0.10 + c.Cost();
    }

    public override string Description()
    {
        return c.Description() + ", Whip";
    }
}

class Milk : Decorator
{
    private Coffee c;
    public Milk(Coffee c)
    {
        this.c = c;
    }
    public override double Cost()
    {
        return 0.15 + c.Cost();
    }

    public override string Description()
    {
        return c.Description() + ", Milk";
    }
}

class Suger : Decorator
{
    private Coffee c;
    public Suger(Coffee c)
    {
        this.c = c;
    }
    public override double Cost()
    {
        return 0.20 + c.Cost();
    }

    public override string Description()
    {
        return c.Description() + ", Suger";
    }
}

