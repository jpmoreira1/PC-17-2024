/* 
Pablo Moreira
1063124
Fibonacci
*/


int n = 0;
int a = 0;
int b = 1;
int c = 0;
int i = 2;
string resultado = "";

Console.WriteLine("Ingresa un numero");
n = int.Parse(Console.ReadLine());

resultado += a + "";
resultado += b + "";

while (i < n)
{
    c = a + b;
    a = b;
    b = c;
    resultado += c + "";
    i++;
}

Console.WriteLine(resultado);
