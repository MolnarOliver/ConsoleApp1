using SocialFeed;

internal class Program
{
    static void Main(string[] args)
    {
        TextPost a = new TextPost("A", "aaaaa");
        TextPost b = new TextPost("b", "bbbbbb");

        for (int i = 0; i < 3; i++)
        {
            a.Like();
        }

        Console.WriteLine(a.GetDescription());
        Console.ReadKey();

        ImagePost post1 = new ImagePost("Dóra", 3);

        for (int i = 0; i < 5; i++)
        {
            post1.Like();
        }

        Console.WriteLine(post1.GetDescription());
        Console.WriteLine($"Pontszám: {post1.Score()}");
        ImagePost post2 = new ImagePost("D", 15);
        Console.WriteLine(post2.GetDescription());

        PollPost poll1 = new PollPost("E");
        poll1.Like();
        poll1.Like();
        for (int i = 0; i < 4; i++)
        {
            poll1.Vote();
        }
        Console.WriteLine(poll1.Like());
        Console.WriteLine(poll1.Vote());
        Console.WriteLine(poll1.GetDescription());
        Console.WriteLine(poll1.GetDescription());
    }

    
}