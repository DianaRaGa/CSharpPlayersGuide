// Reparing the Clocktower
Console.Title = "Repairing the Clocktower";

// App Presentation

Console.WriteLine("To reoair the Clocktower please press any key to continue ");
Console.WriteLine(@"
                 __________
                /_________/`-_
             _-'          `-_ /|
            {                } |
            |  ____________  | |
            | |    \/||    | | |
            | |    /\||    | | |
            | |            | | |
            | ||\/      |||| | |
            | ||/\ ,*.  |||| | |
            | |  ,'   `.   | | |
            | |    \ /| `. | | |
            | |_____V_|____| | |
            | |    : /     | | |
            | |    :/:     | | |
            | |    / :     | | |
            | |   /: @     | | |  _|_ .    |   _|_       |
            | |  / :       | | |   |  | /` |/   |  /\ /\ |/
            | |( ) :       | | |   |  | \, |\   |  \/ \/ |\
            | |    :       | | |
            | |    :       | | |
            | |    :       | | |
            | |    :       | | |
            | |    :       | | |
            | |    @       | | |
            | |____________| | |  
            |________________|/

          Repairing the Clocktower

");
Console.ReadKey();

Console.Clear();

// Aking the user for the number

Console.WriteLine("Please enter the number on the clock ");
int ClockNumber = int.Parse(Console.ReadLine());

if (ClockNumber % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");
