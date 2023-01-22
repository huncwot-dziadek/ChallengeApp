User user1 = new User("Adam", "123456AAA");
User user2 = new User("Ewa", "123456AAA");
User user3 = new User("Karol", "123456AAA");
User user4 = new User("Mietek", "123456AAA");

user1.AddScore(5);
user1.AddScore(1);
user1.AddScore(9);
var result = user1.Result;
Console.WriteLine(result);


class User
{
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;

    }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}



