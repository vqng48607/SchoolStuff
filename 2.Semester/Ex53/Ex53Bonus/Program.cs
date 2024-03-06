using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Ex53Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClubMember> memberList = new List<ClubMember>();

            memberList.Add(new ClubMember { Id = 1, FirstName = "Farrand", LastName = "Semkins", Gender = Gender.Female, Age = 77 });
            memberList.Add(new ClubMember { Id = 2, FirstName = "Trev", LastName = "Quail", Gender = Gender.Male, Age = 84 });
            memberList.Add(new ClubMember { Id = 3, FirstName = "Dani", LastName = "Ballister", Gender = Gender.Female, Age = 76 });
            memberList.Add(new ClubMember { Id = 4, FirstName = "Hyacinthie", LastName = "Mish", Gender = Gender.Female, Age = 70 });
            memberList.Add(new ClubMember { Id = 5, FirstName = "Jarib", LastName = "Boustred", Gender = Gender.Male, Age = 32 });
            memberList.Add(new ClubMember { Id = 6, FirstName = "Erl", LastName = "Meeson", Gender = Gender.Male, Age = 62 });
            memberList.Add(new ClubMember { Id = 7, FirstName = "Aile", LastName = "Highman", Gender = Gender.Female, Age = 79 });
            memberList.Add(new ClubMember { Id = 8, FirstName = "Rheta", LastName = "Battelle", Gender = Gender.Female, Age = 42 });
            memberList.Add(new ClubMember { Id = 9, FirstName = "Olimpia", LastName = "Foulsham", Gender = Gender.Female, Age = 60 });
            memberList.Add(new ClubMember { Id = 10, FirstName = "Dagny", LastName = "Ilchenko", Gender = Gender.Male, Age = 34 });
            memberList.Add(new ClubMember { Id = 11, FirstName = "Davis", LastName = "Gilbride", Gender = Gender.Male, Age = 46 });
            memberList.Add(new ClubMember { Id = 12, FirstName = "Kamillah", LastName = "Bahls", Gender = Gender.Female, Age = 24 });
            memberList.Add(new ClubMember { Id = 13, FirstName = "Flore", LastName = "Ansley", Gender = Gender.Female, Age = 89 });
            memberList.Add(new ClubMember { Id = 14, FirstName = "Glad", LastName = "Clowser", Gender = Gender.Female, Age = 48 });
            memberList.Add(new ClubMember { Id = 15, FirstName = "Christian", LastName = "Congram", Gender = Gender.Female, Age = 33 });
            memberList.Add(new ClubMember { Id = 16, FirstName = "Tore", LastName = "Saggs", Gender = Gender.Male, Age = 28 });
            memberList.Add(new ClubMember { Id = 17, FirstName = "Vevay", LastName = "Klezmski", Gender = Gender.Female, Age = 43 });
            memberList.Add(new ClubMember { Id = 18, FirstName = "Bren", LastName = "Merrikin", Gender = Gender.Female, Age = 46 });
            memberList.Add(new ClubMember { Id = 19, FirstName = "Benoit", LastName = "Filler", Gender = Gender.Male, Age = 16 });
            memberList.Add(new ClubMember { Id = 20, FirstName = "Lucien", LastName = "Bottrell", Gender = Gender.Male, Age = 41 });
            memberList.Add(new ClubMember { Id = 21, FirstName = "Emmy", LastName = "Pechell", Gender = Gender.Male, Age = 61 });
            memberList.Add(new ClubMember { Id = 22, FirstName = "Merle", LastName = "Bennet", Gender = Gender.Female, Age = 42 });
            memberList.Add(new ClubMember { Id = 23, FirstName = "Solomon", LastName = "Sarrell", Gender = Gender.Male, Age = 61 });
            memberList.Add(new ClubMember { Id = 24, FirstName = "Shurlock", LastName = "Shreenan", Gender = Gender.Male, Age = 84 });
            memberList.Add(new ClubMember { Id = 25, FirstName = "Chadd", LastName = "Hanney", Gender = Gender.Male, Age = 80 });

            memberList.ForEach(member => Console.WriteLine(member));

            /* Insert your LINQ code here! */
            
            ClubMember clubMember = from member in memberList where member.Id == 1 select member;
            


            Console.ReadKey();
        }

    }
}