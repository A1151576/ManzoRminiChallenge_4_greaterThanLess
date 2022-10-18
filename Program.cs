/*
Rafael Manzo
Mini 4 push to git hub.
10/18/2022
*/
Console.Clear();
bool playover = true;
while (playover)
{

    Console.WriteLine("Hello, we are going to see if one number is greater than the other.");
    Console.WriteLine("Input your first number.");

string number1 = Console.ReadLine();
int number1a = Convert.ToInt32(number1);

Console.WriteLine("Ok, lets enter the second number.");
string number2 = Console.ReadLine();

int number2a = Convert.ToInt32(number2);

if( number1a > number2a ){
    Console.WriteLine("Your first number is greater than the second.");
}else{
    Console.WriteLine("Your first number is less than the first.");
}
Console.WriteLine("Would you like to play again? type no to quit or any key to play again.");
string answer01 = Console.ReadLine();
if (answer01 == "no")
{
    playover = false;
}
}