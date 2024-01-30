// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Exploring unary operators
int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is a {b}");
#endregion
#region Exploring unary operators
int c = 3;
int d = ++c;
Console.WriteLine($" c is {c}, d is {d}");
#endregion

int e = 11; 
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");
#region
var p1 = 6;
p1 += 3;
p1 -= 3;
p1 *= 3;
p1 /= 3;
#endregion
string? authorName = Console.ReadLine();
// prompt user to enter an author name.
// The maxLength variable will be the length of authorName if it is
// not null, or 30 if authorName is null.
int maxLength = authorName?.Length ?? 30;
authorName ??= "unknown";

bool p = true;
bool q = false;
Console.WriteLine($"AND | p | q ");
Console.WriteLine($"p | {p & p,-5} | {p & q,-5}");
Console.WriteLine($"q | {q & p,-5} | {q & p,-5}");
Console.WriteLine();
Console.WriteLine($"OR | p | q ");
Console.WriteLine($"p | {p | p,-5} | {p | q,-5}");
Console.WriteLine($"q | {q | p,-5} | {q | q,-5}");
Console.WriteLine();
Console.WriteLine($"XOR | p | q ");
Console.WriteLine($"p | {p ^ p,-5} | {p ^ q,-5}");
Console.WriteLine($"q | {q ^ p,-5} | {q ^ q,-5}");

Console.WriteLine();

int x = 10;
int y = 6;
Console.WriteLine($"Expression | Decimal | Binary");
Console.WriteLine($"------------------------------");
Console.WriteLine($"x | {x,7} | {x:B8}");
Console.WriteLine($"x | {y,7} | {y:B8}");
Console.WriteLine($"x $ y | {x & y,7} | {x & y:B8}");
Console.WriteLine($"x | y | {x | y,7} | {x | y:B8}");
Console.WriteLine($"x ^ y | {x ^ y,7} | {x ^ y:B8}");
