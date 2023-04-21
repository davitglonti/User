// first project
using System;

public class User
{
    public static void Main(string[] args)
    {
        string expectedUsername = "myusername";
        string expectedPassword = "mypassword";
        int maxTries = 5;
        int tries = 0;
        while(tries< maxTries) {
            Console.Write("Enter username:");
            var username = Console.ReadLine();
            Console.Write("Enter Password: ");
            var password = Console.ReadLine();

            if(username == expectedUsername && password == expectedPassword ) {
                Console.WriteLine("Success");
                break;
            }else {
                 Console.WriteLine("inCorrect");
                 tries++;
            }
        }

        if(tries==maxTries){
            Console.WriteLine("max attempts reached");
        }

    }
}