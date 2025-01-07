
Console.WriteLine("Operações: Soma = +, Subtração = -, Divisão = /, Multiplicação = *");

double? n1, n2;

Console.WriteLine("Digite um numero ");
n1 = double.Parse(Console.ReadLine());

string? operação;

Console.WriteLine("Digite uma operação ");
operação = (Console.ReadLine());

Console.WriteLine("Digite um numero ");
n2 = double.Parse(Console.ReadLine());

switch(operação)
{
    //Soma

    case "+":

     Console.WriteLine(n1 + n2);

    break;
    //Subtração

    case "-":

     Console.WriteLine(n1 - n2);

    break;

    //Divisão
     case "/":

     Console.WriteLine(n1 / n2);

    break;

    //Multiplicação

    case "*":

     Console.WriteLine(n1 * n2);

    break;

    default:
        Console.WriteLine("Operação invalida ");
        return;
}