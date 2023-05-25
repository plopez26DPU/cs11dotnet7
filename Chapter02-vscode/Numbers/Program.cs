﻿//unsigned integer means positive whole number or 0
uint naturalNumber = 23;

//integer means negative or positive whole number or 0
int integerNumber = -23;

//float means single-precision floating point
//F suffix makes it a float literal
float realNumber = 2.3F;

//double means double-precision floating point
//double is the default type for a number value with a decimal point
double anotherRealNumber = 2.3; //double literal

//three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

//check the three variables have the same value
//both statements should output true
// Console.WriteLine($"{decimalNotation == binaryNotation}");
// Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
// Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
// Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

Console.WriteLine("Using doubles");
double a = 0.1;
double b = 0.2;
string compareDoubles = ((a + b) == 0.3) ? $"{a} + {b} equals {0.3}" : $"{a} + {b} does NOT {0.3}"; //ternary operator
Console.WriteLine(compareDoubles);

Console.WriteLine("Using decimals");
decimal c = 0.1M; //M suffix means a decimal literal value
decimal d = 0.2M;
string compareDecimals = ((c + d) == 0.3M) ? $"{c} + {d} equals {0.3}" : $"{c} + {d} does NOT {0.3}"; //ternary operator
Console.WriteLine(compareDecimals);