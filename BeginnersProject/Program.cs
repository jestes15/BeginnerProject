using System;

namespace BeginnersProject
{
    class main
    {
        static void Main(string[] args)
        {
            var userDetails = new LoginDetails();
            Console.WriteLine(UtilityFunctions.Output(userChoice: 1));
            userDetails.set_username(Console.ReadLine());
            userDetails.set_encoded_username(UtilityFunctions.sha256_hash(userDetails.get_username()));
            Console.WriteLine(UtilityFunctions.Output(userChoice: 2));
            userDetails.set_password(Console.ReadLine());
            userDetails.set_encoded_password(UtilityFunctions.sha256_hash(userDetails.get_password()));
            
            Console.WriteLine($"{userDetails.get_username()} => {userDetails.get_encoded_username()}");
            Console.WriteLine($"{userDetails.get_password()} => {userDetails.get_encoded_password()}");
        }
    }
}
