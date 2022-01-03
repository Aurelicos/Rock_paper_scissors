# Rock_paper_scissors
A simple program in Console app .net framework C# 

Base description od my program:

Console.Write("\nDo you want to play Rock, paper, scissors? (yes/no) ");    - first we ask the user if he wants to play

string answer = Console.ReadLine();

if (answer == "yes")          - and if his answer is yes, the program will continue, and if the answer is no, the program will end:

else
{
    Environment.Exit(0);
}

but before this loop is another loop - for. Before this loop, the program asks the user how many rounds he wants to play

int rounds = int.Parse(Console.ReadLine());
for (int i = 0; i < rounds; i++)


After this the computer will ask us if we want to choose stone, scissors or paper

Console.WriteLine("\nEnter 1 for rock");
Console.WriteLine("\nEnter 2 for scissors");
Console.WriteLine("\nEnter 3 for paper");
int input = int.Parse(Console.ReadLine());


then there are several loops that control what the computer chose using a random number and what the user chose, and during 
this program the winning points are added to the computer and the user, where at the end these points will be evaluated 
and the winner will be written to the console.


Thank you for downloading my simple program for rock scissors and paper. Enjoy it!
