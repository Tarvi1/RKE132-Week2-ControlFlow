// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use instagram.");
    }    

}
else
{
    Console.WriteLine("Could not read your age.");
}