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