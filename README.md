# Rock_paper_scissors
A simple program in Console app .net framework C# 


Base description of my program:

- first we ask the user if he wants to play
 ```C#
Console.Write("\nDo you want to play Rock, paper, scissors? (yes/no) ");    

string answer = Console.ReadLine();
```
- and if his answer is yes, the program will continue, and if the answer is no, the program will end:
```C#
if (answer == "yes")          

else

{

    Environment.Exit(0);
    
}
```

but before this loop is another loop - for. Before this loop, the program asks the user how many rounds he wants to play
```C#
int rounds = int.Parse(Console.ReadLine());

for (int i = 0; i < rounds; i++)
```


After this the computer will ask us if we want to choose stone, scissors or paper
```C#
Console.WriteLine("\nEnter 1 for rock");

Console.WriteLine("\nEnter 2 for scissors");

Console.WriteLine("\nEnter 3 for paper");

int input = int.Parse(Console.ReadLine());
```


then there are several loops that control what the computer chose using a random number and what the user chose, and during 
this program the winning points are added to the computer and the user, where at the end these points will be evaluated 
and the winner will be written to the console.



Thank you for downloading my simple program for rock scissors and paper. Enjoy it!

<br></br>
<h3>If there are any problems write to my discord:</h3><a href="https://discordapp.com/users/869579499266793512" target="_blank" title="My discord account" id="logo" target="_blank" data-hveid="8"><img src="https://jablickar.cz/wp-content/uploads/2021/03/Discord-logo.png.webp" height="50" width="80"></a>
