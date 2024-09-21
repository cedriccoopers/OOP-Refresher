public class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows");
    }
}