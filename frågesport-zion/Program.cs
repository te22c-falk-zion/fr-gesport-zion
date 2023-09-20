﻿using System;

int points = 0;
Console.WriteLine("Welcome to sparkle sparkle fun time trivia!!! :33");

Console.WriteLine("1: What is cuter???");
Console.WriteLine("a) Cats (<-- this one!!)  b) Dogs :/  c) Blobfish....");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
  points++;
  Console.WriteLine("CORRECT, YOU'RE SO AMAZING!!!");
}
else
{
  Console.WriteLine("...");
}


Console.WriteLine("2: okay so now like what is better??");
Console.WriteLine("a) Magical girls (SO CUTE!!)  b) Cats again (SUPER CUTE!!)  c) 1945 ");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
  points++;
  Console.WriteLine("AWESOME SACUE!!!");
}
else
{
  Console.WriteLine("uh...");
}


Console.WriteLine("3: AITA?");
Console.WriteLine("I was shopping at Walmart, looking for a plastic bag for a single onion. I ran across the flower display and saw a set of roses that I thought were beautiful together and I wanted my wife to have them."); 
Console.WriteLine("Later that night, I was told that 'I brought her homework' because now she has to do something with them to make them presentable (adding an element that makes them presentable)i.e. baby's breath, greenery etc."); 
Console.WriteLine("It sounded like 'either go to a florist or don't bother buying me cheap flowers' Are cheap flowers a no-no? (Fyi...Married 19 years)");
Console.WriteLine("a) No b) Yes ");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("YIPPE!!! You have common sense!");
}
else
{
  Console.WriteLine("I can see what you're getting at. You're wrong and selfish but I can see it.");
}


Console.WriteLine($"Let me count for a sec :33, you got...");
Console.WriteLine($"{points} points...");
if (points == 0)
{
  Console.WriteLine("...");
}
else if (points < 3)
{
  Console.WriteLine("Well...you tried?");
}
else 
{
  Console.WriteLine("OMGEEE CONGRATULATIONS!!! You got them all right!!! :DDD");
}

Console.WriteLine("Press a key to leave :3");
Console.ReadKey();
