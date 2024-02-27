string nombre = "";
string edad = "";
string carrera = "";
string carne = "";

Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
edad = Console.ReadLine();

Console.WriteLine("Ingrese su carrera");
carrera = Console.ReadLine();

Console.WriteLine("Ingrese su carné");
carne = Console.ReadLine();

Console.WriteLine($"Soy {nombre}, tengo {edad} años y estudio la carrera de {carrera}. \nMi número de carné es {carne}");
Console.ReadLine();
