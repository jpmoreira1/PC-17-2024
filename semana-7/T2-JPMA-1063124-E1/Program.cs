double v0;
double aceleracion; 
double tiempo;  

Console.WriteLine("Ingrese la velocidad inicial");
v0 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la aceleración");
aceleracion = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo");
tiempo = Double.Parse(Console.ReadLine());

Console.WriteLine($"La velocidad final es {v0 + aceleracion * tiempo}");

