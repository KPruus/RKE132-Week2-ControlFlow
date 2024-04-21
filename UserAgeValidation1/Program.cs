// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal sisestada vanuse
//kui kasutaja vanus on väiksem kui 13, kuvatakse:
//"You are too young to use le webpage"
//muul juhul
//konsoolis kuvataks "Welcome to le webpage"

using System.ComponentModel.Design;

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You're too young!");
    }
}

else
{
    Console.WriteLine("Could not read your age.");
}

