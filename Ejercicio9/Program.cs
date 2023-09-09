//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números
//ingresados.

// 1 definir clase y metodod

public class Ejercicio9
{
    static void Main(string[] Args)
    {
        //2 Definir las variables

        int num1, num2, num3;
        // 3 capturar datos

        Console.WriteLine("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el sugundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tercer numero: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // 4 calculos

        if (num1 >= num2 && num1 >= num3) 
        {
            Console.WriteLine($"El numero mayor es: {num1}");
        }
        else if (num2 >= num3) 
        {
            Console.WriteLine($"El numero mayor es: {num2}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es: {num3}");
        }

    }
}