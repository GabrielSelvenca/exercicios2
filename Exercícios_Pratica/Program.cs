using Exercícios_Pratica;

Console.WriteLine("------------- MENU DE EXERCICIOS -------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("----------- Exercicios disponíveis -----------");
Console.WriteLine("\nEx1 - [1]\nEx2 - [2]\nEx3 - [3]\nEx4 - [4]\nEx5 - [5]\nEx6 - [6]\nEx7 - [7]\n");
Console.WriteLine("----------------------------------------------");

string escolha = Console.ReadLine();

switch (escolha)
{
    case "1": Console.Clear(); new Ex1(); break;

    case "2": Console.Clear(); new Ex2(); break;

    case "3": Console.Clear(); new Ex3(); break;

    case "4": Console.Clear(); new Ex4(); break;

    case "5": Console.Clear(); new Ex5(); break;
    
    case "6": Console.Clear(); new Ex6(); break;

    case "7": Console.Clear(); new Ex7(); break;

    default:
        Console.WriteLine("Escolha inválida.");
        break;
}
