// Description
//Use a do-while loop to output "Hello, World!" in a loop.
//Each time you output "Hello, World!" ask the user whether they would like to continue.


using System;
using System.Data.SqlTypes;

string input;
string inputB;
do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Do you want to continue? y/n");
    input = Console.ReadLine();


} while(input == "y");

Console.WriteLine("Goodbye!");

//Description
//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
//After that loop finishes, use another loop to output all the numbers from 0 to that number.

Console.WriteLine("Enter a number:");
int inputNum = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Do you want to continue? y/n");
    inputB = Console.ReadLine();

    for (int i = inputNum; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    for (int i = 0; i <= inputNum; i++)
    {
        Console.WriteLine(i);
    }
} while(inputB == "y");

Console.WriteLine("Goodbye!");

/*A door has a keypad entry. The combination to get in is 13579. 
 * Write a while loop (not a do while loop) that asks the user to enter a key code. 
 * The loop will repeat as long as the user enters the wrong code. 
 * After the user enters the correct code, the program will print out a welcome message.

Hint: There are many ways to accomplish this, but one way is to create a boolean variable that represents if the door is locked or unlocked. 
Then think about real life, when you approach a door with a keypad, what state is it initially in before you type anything into the keypad?
*/

KeyPadEntry();

static void KeyPadEntry()
{
    int keyCode = 0;
    ; while (keyCode != 13579)
    {
        Console.WriteLine("Enter the Key Code:");
        keyCode = int.Parse(Console.ReadLine());
        if (keyCode != 13579)
        {
            Console.WriteLine("Please enter the correct code");
        }
    }
    Console.WriteLine("Welcome home!");
}

/*Continue the previous exercise, but now add a limited number of tries, say 5.
 * After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message, 
 * it prints a message warning that there were too many incorrect attempts. 
 * (But if the user entered the correct number, it will still print the welcome message as before.)
 */

KeyPadEntry2();

static void KeyPadEntry2()
{
    int keyCode = 0;
    int tries = 5;
    Console.WriteLine("Enter the Key Code:");

    for (int i = 0; i <= tries; i++)
    {
        keyCode = int.Parse(Console.ReadLine());
        if(keyCode == 13579)
        {
            Console.WriteLine("Welcome home!");
            break;
        }
        else if (i == 5)
        {
            Console.WriteLine("Too many incorrect attempts");
            
        } else
        {
            Console.WriteLine("Please enter the correct code");
        }

    }
    
}

/* Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do while loop.*/


KeyPadEntry3();

static void KeyPadEntry3()
{
    int keyCode = 0;
    int tries = 0;
    Console.WriteLine("Enter the Key Code:");
    do
    {
        if (tries == 5)
        {
            Console.WriteLine("Too many incorrect attempts");
            
        }
        else
        {
            keyCode = int.Parse(Console.ReadLine());
            if(keyCode != 13579)
            {
                Console.WriteLine("Please enter the correct code");
            }
            tries++;
        }
    } while (keyCode != 13579 || tries >= 5);
    
    if(keyCode == 13579)
    {
        Console.WriteLine("Welome home!");
    }
}
