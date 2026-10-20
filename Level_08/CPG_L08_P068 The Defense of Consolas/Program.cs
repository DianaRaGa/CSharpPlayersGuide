// The Defense of Consolas
Console.Title = "The Defense of Consolas";

// App Presentation

Console.WriteLine("Welcome to the Defense App. Press any key to continue ");
//Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@"
                                  |>>>
                                  |
                    |>>>      _  _|_  _         |>>>
                    |        |;| |;| |;|        |
                _  _|_  _    \\.    .  /    _  _|_  _
               |;|_|;|_|;|    \\:. ,  /    |;|_|;|_|;|
               \\..      /    ||;   . |    \\.    .  /
                \\.  ,  /     ||:  .  |     \\:  .  /
                 ||:   |_   _ ||_ . _ | _   _||:   |
                 ||:  .|||_|;|_|;|_|;|_|;|_|;||:.  |
                 ||:   ||.    .     .      . ||:  .|
                 ||: . || .     . .   .  ,   ||:   |       \,/
                 ||:   ||:  ,  _______   .   ||: , |            /`\
                 ||:   || .   /+++++++\    . ||:   |
                 ||:   ||.    |+++++++| .    ||: . |
              __ ||: . ||: ,  |+++++++|.  . _||_   |
     ____--`~    '--~~__|.    |+++++__|----~    ~`---,              ___
-~--~                   ~---__|,--~'                  ~~----_____-~'   `~----~~

                       The Defense of Consolas
");
Console.WriteLine("Press any key to continue ");
Console.ReadKey();

Console.Clear();

// Asking the user for the target row

Console.Write("What is the target row? ");
int TargetRow = int.Parse(Console.ReadLine());

Console.Write("What is the target column? ");
int TargetColumn = int.Parse(Console.ReadLine());

Console.Clear();

// Compute the points to cover

Console.Write("Deploy to:");

Console.WriteLine("Squad member 1");
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Row:{TargetRow}, Column: {TargetColumn - 1}");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Squad member 2");
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Row:{TargetRow}, Column: {TargetColumn + 1}");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Squad member 3");
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Row:{TargetRow + 1}, Column: {TargetColumn}");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Squad member 4");
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Row:{TargetRow - 1}, Column: {TargetColumn}");


Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(@" 

INCOMING ATTACK 

");

Console.Beep(440, 200);
Console.Beep(440, 200);
Console.Beep(660, 400);

Console.WriteLine(@"
                             ____
                     __,-~~/~    `---.
                   _/_,---(      ,    )
               __ /        <    /   )  \___
- ------===;;;'====------------------===;;;===----- -  -
                  \/  ~""~""~""~""~""~\~""~)~""/
                  (_ (   \  (     >    \)
                   \_( _ <         >_>'
                      ~ `-i' ::>|--""
                          I;|.|.|
                         <|i::|i|`.
                        (` ^'""`-' "")

");

