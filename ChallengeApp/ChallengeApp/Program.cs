using ChallengeApp;

User user1 = new User("Adam", "123456AAA");
User user2 = new User("Ewa", "123456AAA");
User user3 = new User("Karol", "123456AAA");
User user4 = new User("Mietek", "123456AAA");

user1.AddScore(5);
user1.AddScore(1);
user1.AddScore(9);
var result = user1.Result;
Console.WriteLine(result);

