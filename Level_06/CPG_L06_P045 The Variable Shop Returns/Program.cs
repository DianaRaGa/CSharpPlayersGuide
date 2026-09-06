// The Variable Shop

// Integer Types //


// 1. short between -32,000 and +32,000 (Int16)
short aShortType = -56;
Console.WriteLine("variable = " + aShortType + " type = " + aShortType.GetType());
aShortType = -890;
Console.WriteLine("variable = " + aShortType + " type = " + aShortType.GetType());

// 2. int 4 bytes and between -2 billion and +2 billion (Int32)
int anIntegerType = 10_000;
Console.WriteLine("variable = " + anIntegerType + " type = " + anIntegerType.GetType());
anIntegerType = 760;
Console.WriteLine("variable = " + anIntegerType + " type = " + anIntegerType.GetType());

// 3. long between -9 quintillion and +9 quintillion (bilioin of a billion (˶°ㅁ°)!! (Int64)
long aLongVariable = -7_000_000_000_000_000_000;
Console.WriteLine("variable = " + aLongVariable + " type = " + aLongVariable.GetType());
aLongVariable = -3_060_040_040_040_060_643;
Console.WriteLine("variable = " + aLongVariable + " type = " + aLongVariable.GetType());

// 4. ushort between 0 and 4,294,967,295 (Int16)
uint aUShortType = 298_000_980;
Console.WriteLine("variable = " + aUShortType + " type = " + aUShortType.GetType());
aUShortType = 2_780_980;
Console.WriteLine("variable = " + aUShortType + " type = " + aUShortType.GetType());


// 5. uint between 0 and 65,535 (Int32)
ushort aUIntType = 37_000;
Console.WriteLine("variable = " + aUIntType + " type = " + aUIntType.GetType());
aUIntType = 7_454;
Console.WriteLine("variable = " + aUIntType + " type = " + aUIntType.GetType());

// 6. ulong between 0 and 18 quintillion (bilioin of a billion (˶°ㅁ°)!!!!!!!! (Int64)
ulong aULongVariable = 14_000_000_000_000_000_000;
Console.WriteLine("variable = " + aULongVariable + " type = " + aULongVariable.GetType());
aULongVariable = 9_046_056_030_006_000_000;
Console.WriteLine("variable = " + aULongVariable + " type = " + aULongVariable.GetType());

// 7. sbyte between -128 and +127 (SByte)
sbyte aSByteVariable = 15;
Console.WriteLine("variable = " + aSByteVariable + " type = " + aSByteVariable.GetType());
aSByteVariable = 1;
Console.WriteLine("variable = " + aSByteVariable + " type = " + aSByteVariable.GetType());

// 8. byte between 0 and 255 (Int16)
byte aByteType = 78;
Console.WriteLine("variable = " + aByteType + " type = " + aByteType.GetType());
aByteType = 111;
Console.WriteLine("variable = " + aByteType + " type = " + aByteType.GetType());

// 9. char 
char aEmoji = 'z';
Console.WriteLine("variable = " + aEmoji + " type = " + aEmoji.GetType());
aEmoji = '⭐';
Console.WriteLine("variable = " + aEmoji + " type = " + aEmoji.GetType());

// 10. string
string aString = "ʕ•ᴥ•ʔ";
Console.WriteLine("variable = " + aString + " type = " + aString.GetType());
aString = "ʕっ•ᴥ•ʔっ💕";
Console.WriteLine("variable = " + aString + " type = " + aString.GetType());

// 11. float
float aFloat = 0.00000000000007F;
Console.WriteLine("variable = " + aFloat + " type = " + aFloat.GetType());
aFloat = 0.4364453407F;
Console.WriteLine("variable = " + aFloat + " type = " + aFloat.GetType());

// 12. double
double aDouble = 589.8468453483756845785785467345675457;
Console.WriteLine("variable = " + aDouble + " type = " + aDouble.GetType());
aDouble = 67679.846745674576456363453453453453434654764765475675674535634523452353463576675457;
Console.WriteLine("variable = " + aDouble + " type = " + aDouble.GetType());

// 13. decimal
decimal aDdecimal = 589.8468453483756467345675457M;
Console.WriteLine("variable = " + aDdecimal + " type = " + aDdecimal.GetType());
aDdecimal = 9.8468455M;
Console.WriteLine("variable = " + aDdecimal + " type = " + aDdecimal.GetType());


// 14. bool
bool aBool = true;
Console.WriteLine("variable = " + aBool + " type = " + aBool.GetType());
aBool = false;
Console.WriteLine("variable = " + aBool + " type = " + aBool.GetType());
