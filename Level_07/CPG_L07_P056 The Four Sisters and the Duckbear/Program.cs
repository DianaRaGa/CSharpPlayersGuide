// The Four Sisters and the Duckbear

// PResenting the app

Console.WriteLine("Hi and welcome to the egg diveder app");
Console.WriteLine(@"
                            +&-
                           _.-^-._    .--.
                        .-'   _   '-. |__|
                       /     |_|     \|  |
                      /               \  |
                     /|     _____     |\ |
                      |    |==|==|    |  |
  |---|---|---|---|---|    |--|--|    |  |
  |---|---|---|---|---|    |==|==|    |  |
 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
");
Console.WriteLine("Can you tell me the total eggs colected today?");

// Getting the variable

int TotalEggs = int.Parse(Console.ReadLine());

// Calculations

Console.WriteLine("The total egg each sister should have is");
int RemainderEggs = TotalEggs % 4;
int EggsForEachSister = (TotalEggs -  RemainderEggs) / 4;

// Result

Console.WriteLine("For each sisters: " + EggsForEachSister + " For the duckbear: " + RemainderEggs);

// Answer to the question is: Total eggs count 1, 2, 3, 6, 7, 11