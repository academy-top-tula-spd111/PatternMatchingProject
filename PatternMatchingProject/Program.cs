namespace PatternMatchingProject
{
    public class Base
    {

    }

    class Second : Base, IA
    {

    }

    class Third : Second, IB
    {

    }

    interface IA
    {

    }

    interface IB
    {

    }


    class User
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }

    internal class Program
    {
        static void SayHello(Object user)
        {
            //if((user as User).City == "Moscow")
            //if(user is User { City: "Moscow" })
            //    Console.WriteLine($"Hello stolichny!");
            //else
            //    Console.WriteLine($"Hello provincial!");
            
        }
        static void Main(string[] args)
        {
            //Base? mybase = null;
            //Second second = new();
            //Third third = new();
            //IA ia;
            //IB ib;
            //Console.WriteLine(second is not null);

            User userMember = new User() { Name = "Bob", City = "Moscow", State = "Member"};
            User userAdmin = new User() { Name = "Joe", City = "Kaluga", State = "Admin" };
            
            SayHello(userAdmin);

            char code = '+';
            int a = 10, b = 20;

            int? result = code switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                _ => null
            };

            int l = 100;

            string s = l switch
            {
                < 0 and < 50 => "less 0",
                > 50 and < 100 => "less 50",
                < 200 => "less 200",
                _ => "undefinet"
            };

            Console.WriteLine(s);




        }
    }
}