// The Dominion of Kings

// Presenting the app

Console.WriteLine("Hi Kings Melik, Casik, and Balik; Welcome to the Dominion of Kings Calculator");
Console.WriteLine(@"
                                                  !_
                                                  |*~=-.,
              Dominion of Kings Calculator        |_,-'`
                                                  |
                                                  |
                                                 /^\
                   !_                           /   \
                   |*`~-.,                     /,    \
                   |.-~^`                     /#""     \
                   |                        _/##_   _  \_
              _   _|  _   _   _            [ ]_[ ]_[ ]_[ ]
             [ ]_[ ]_[ ]_[ ]_[ ]            |_=_-=_ - =_|
           !_ |_=_ =-_-_  = =_|           !_ |=_= -    |
           |*`--,_- _        |            |*`~-.,= []  |
           |.-'|=     []     |   !_       |_.-""`_-     |
           |   |_=- -        |   |*`~-.,  |  |=_-      |
          /^\  |=_= -        |   |_,-~`  /^\ |_ - =[]  |
      _  /   \_|_=- _   _   _|  _|  _   /   \|=_-      |
     [ ]/,    \[ ]_[ ]_[ ]_[ ]_[ ]_[ ]_/,    \[ ]=-    |
      |/#""     \_=-___=__=__- =-_ -=_ /#""     \| _ []  |
     _/##_   _  \_-_ =  _____       _/##_   _  \_ -    |\
    [ ]_[ ]_[ ]_[ ]=_0~{_ _ _}~0   [ ]_[ ]_[ ]_[ ]=-   | \
    |_=__-_=-_  =_|-=_ |  ,  |     |_=-___-_ =-__|_    |  \
     | _- =-     |-_   | ((* |      |= _=       | -    |___\
     |= -_=      |=  _ |  `  |      |_-=_       |=_    |/+\|
     | =_  -     |_ = _ `-.-`       | =_ = =    |=_-   ||+||
     |-_=- _     |=_   =            |=_= -_     |  =   ||+||
     |=_- /+\    | -=               |_=- /+\    |=_    |^^^|
     |=_ |+|+|   |= -  -_,--,_      |_= |+|+|   |  -_  |=  |
     |  -|+|+|   |-_=  / |  | \     |=_ |+|+|   |-=_   |_-/
     |=_=|+|+|   | =_= | |  | |     |_- |+|+|   |_ =   |=/
     | _ ^^^^^   |= -  | |  <&>     |=_=^^^^^   |_=-   |/
     |=_ =       | =_-_| |  | |     |   =_      | -_   |
     |_=-_       |=_=  | |  | |     |=_=        |=-    |
^^^^^^^^^^`^`^^`^`^`^^^""""""""""""""""^`^^``^^`^^`^^`^`^``^`^``^``^^
");

// Aking King Melik for his kingdom
Console.WriteLine("King Malik, could you provide the next information please?");
Console.WriteLine("How many provinces are in your kingdom?");
int MelikProvinces = int.Parse(Console.ReadLine());

Console.WriteLine("How many duchies are in your kingdom?");
int MelikDuchies = int.Parse(Console.ReadLine());

Console.WriteLine("How many estates are in your kingdom?");
int MelikEstates = int.Parse(Console.ReadLine());

// Aking King Casik for his kingdom
Console.WriteLine("King Casik, could you provide the next information please?");
Console.WriteLine("How many provinces are in your kingdom?");
int CasikProvinces = int.Parse(Console.ReadLine());

Console.WriteLine("How many duchies are in your kingdom?");
int CasikDuchies = int.Parse(Console.ReadLine());

Console.WriteLine("How many estates are in your kingdom?");
int CasikEstates = int.Parse(Console.ReadLine());

// Aking King Balik for his kingdom
Console.WriteLine("King Balik, could you provide the next information please?");
Console.WriteLine("How many provinces are in your kingdom?");
int BalikProvinces = int.Parse(Console.ReadLine());

Console.WriteLine("How many duchies are in your kingdom?");
int BalikDuchies = int.Parse(Console.ReadLine());

Console.WriteLine("How many estates are in your kingdom?");
int BalikEstates = int.Parse(Console.ReadLine());

// Making the sum of points per king
int MelikTotalScore = (MelikProvinces * 6) + (MelikDuchies * 3) + (MelikEstates * 1);

int CasikTotalScore = (CasikProvinces * 6) + (CasikDuchies * 3) + (CasikEstates * 1);

int BalikTotalScore = (BalikProvinces * 6) + (BalikDuchies * 3) + (BalikEstates * 1);

// Results!
Console.WriteLine("The results are: ");
Console.WriteLine("King Melik: " + MelikTotalScore + " King Casik: " + CasikTotalScore + " King Balik: " + BalikTotalScore);