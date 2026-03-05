public class User
{
    private readonly DateTime createdAt;
    private int age;

    // автосвойство
    public string Name { get; set; }

    // свойство только для чтения
    public DateTime CreatedAt { get { return createdAt; } }

    // свойство с логикой
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                age = 0;
        }
    }

    // private set
    public int Score { get; private set; }

    public bool IsAdult
    {
        get { return age >= 18; }
    }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        createdAt = DateTime.Now;
        Score = 0;
    }

    public void AddScore()
    {
        Score++;
    }

    public override string ToString()
    {
        return $"{Name}, {Age}, {CreatedAt.ToString()}, Is adult: {IsAdult}, Score: {Score}";
    }
}

class Program
{
    static void Main()
    {
        User user1 = new User("Stas", 52);
        Console.WriteLine(user1);

        user1.AddScore();
        user1.AddScore();

        Console.WriteLine(user1);
    }
}