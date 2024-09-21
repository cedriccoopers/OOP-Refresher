public class Person
{
    private int age;

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int age)
    {
        if(age > 0)
        {
            this.age = age;
        }
    }
}