/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      double area, pi, raio;
    Console.WriteLine("Digite o raio");
    raio = double.Parse(Console.ReadLine());
    // Definição do valor de π
         pi = 3.14159;
         area = pi * Math.Pow(raio, 2);

        // Saída: Exibindo o resultado com 4 casas decimais
        Console.WriteLine($"A={area:F4}");
        
  }
}