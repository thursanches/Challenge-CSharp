namespace Challange;

class Program
{
    static void Main()
    {
        //There are six challenges, all of which are commented. To test, just uncomment the specific one.
        //OBS: To test #03, you need to use the class ContasMatematicas.cs


        /*Desafio 01*/

        Console.WriteLine("Escreva seu nome: ");
        string name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Você não digitou seu nome!");
        }
        else
        {
            Console.WriteLine($"Olá, {name.Replace(" ", "")}! Seja muito bem-vindo(a)!");
        }

        /*
        Desafio 02

        Console.WriteLine("Escreva seu nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Escreva seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"O nome é {name.Replace(" ", "")} {sobrenome.Replace(" ", "")}");
        */

        /*
        Dasafio 03
         
        Console.WriteLine("Digite o número 1");
        string valorOne = Console.ReadLine();
        int valor1 = int.Parse(valorOne);

        Console.WriteLine("Digite o número 2");
        string valorTwo = Console.ReadLine();
        int valor2 = int.Parse(valorTwo);

        var matematica = new OperacoesMatematicas();

        matematica.Somar(valor1, valor2);
        matematica.Subtrair(valor1, valor2);
        matematica.Multiplicar(valor1, valor2);
        
        if (valor2 != 0)
        {
            matematica.Dividir(valor1, valor2);
        } else
        {
            Console.WriteLine("Não é possível efetuar a divisão pois o divisor é igual a 0.");
        }

        matematica.Media(valor1, valor2);
        */

        /*
        Desafio 04

        Console.WriteLine("Digite uma ou mais palavras.");
        string palavras = Console.ReadLine();
        string novapalavras = palavras.Replace(" ", "");

        if (!string.IsNullOrEmpty(novapalavras))
        {
            int contador = novapalavras.Length;

            Console.WriteLine("O número de caracteres digitados é: " + contador);
        };

        Console.WriteLine("O número de caracteres totais são de: " + palavras.Length);
        */

        /*
        Desafio 05
        
        //Forma 1
        Console.WriteLine("Digite a placa de um veículo");
        string placa = Console.ReadLine();

        string regex = @"[A-Za-z]{3}[0-9]{4}";

        bool isValid = Regex.IsMatch(placa, regex);

        if (!isValid)
        {
            Console.WriteLine("Falso");
        } else
        {
            Console.WriteLine("Verdadeiro");
        }
        
        // Forma 2
        Console.WriteLine("Digite uma placa válida");
        string placa = Console.ReadLine();

        bool valida = true;

        if (placa.Length != 7)
        {
            valida = false;
        } else
        {
            for ( int i = 0; i <3; i++)
            {
                if (placa[i] >= 'A' && placa[i] <= 'Z' && placa[i] >= 'a' && placa[i] <= 'z')
                {
                    valida = true;
                }

                if (placa[i] >= '0' && placa[i] <= 9)
                {
                    valida = true;
                }
            }
        }
        Console.WriteLine("A placa é válida ? " + valida);
        */

        /*
        Desafio 06
        

        Console.WriteLine("Digite o formato desejado (1, 2, 3 ou 4):\n");
        Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2. Apenas a data no formato \"01/03/2024\".");
        Console.WriteLine("3. Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4. A data com o mês por extenso.");

        DateTime date = DateTime.Now;
        string opcao = Console.ReadLine();
        int escolha = int.Parse(opcao);

        switch(escolha)
        {
            case 1:
                Console.WriteLine(date.ToString("F"));
                break;

            case 2:
                Console.WriteLine(date.ToString("dd/mm/yyyy"));
                break;

            case 3:
                Console.WriteLine(date.ToString("HH:mm"));
                break;

            case 4:
                Console.WriteLine(date.ToString("dddd, dd MMMM yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Você não escolheu uma opção!");
                break;
        }
        */
    }
}