using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular Média para passar de ano!!");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Digite a primeira nota");
        int n1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");
        Console.WriteLine("Digite a segunda nota");
        int n2= Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("-----------------");
        Console.WriteLine("Digite a terceira nota");
        int n3= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");
        Console.WriteLine("Digite a quarta nota");
        int n4= Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("-----------------");    
       int Média = (n1 + n2 + n3 + n4) /4; 
        Console.WriteLine("Sua média é: " + Média);
        
        if(Média >= 6){
            Console.WriteLine("Você passou!!!!");
        }
        else{
            Console.WriteLine("Reprovado...");
        }





    }

}