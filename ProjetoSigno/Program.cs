using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signo
{
    class Program
    {
        static char opcao; // Declaração da variável char
        static string nome; // Declaração das variáveis do tipo string
        static int dia, mes, ano; // Declaração das variáveis do tipo int (inteiro)

        static void Main(string[] args) // Começo do método main
        {
            do // Inicio do comando de repetição do... while
            {
                Menu();
                Digitacao();
                Estacao();
                Signo();

                Console.WriteLine("A idade até o final de 2022 será de {0} anos", 2022 - ano); // Cálculo da idade ao final de 2021        
                Console.WriteLine("\n-------------------------------------------------------"); // Linha para melhor estética do programa
                Console.Write("\nDeseja executar o programa novamente? (S/N): ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out opcao) || opcao != 'S' && opcao != 'N') // Consistência da opção aceitável
                {
                    Console.Write("\nA opção deve ser S ou N! Digite novamente: "); // Caso a opção for inválida, é pedido ao usuário digitar novamente
                }
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey(); // paradinha
            } while (opcao != 'N');     // Fim do comando de repetição do... while
        } // Fim do método main

        static void Menu() // método menu
        {
            Console.Clear(); // Comando que limpa a tela após a repetição do programa
            Console.WriteLine("Projeto Signo"); // Identidade do programa
            Console.WriteLine("Programadores: João Victor e Lucas"); // Nome dos programadores
        } // fim do método menu

        static void Digitacao() // método digitacao
        {
            Console.Write("\nDigite o nome: "); // É pedido ao usuário para digitar o nome
            nome = (Console.ReadLine()); // Leitura da variável nome
            while (nome.Length < 3) // Consistência do número de caracteres da variável nome
            {
                Console.Write("O nome deve conter mais de 3 caracteres. Digite novamente: "); // Caso o nome for inválido é pedido ao usuário digitar novamente
                nome = (Console.ReadLine()); // Leitura da variável nome
            }
            Console.Write("Digite o dia do nascimento: "); // É pedido ao usuário para digitar o dia do nascimento
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)  // Consistência do dia aceitável
            {
                Console.Write("O dia do nascimento deve ser um número (inteiro) e entre 1 e 31! Digite novamente: "); // Caso o dia for um valor inválido, a consistência permite o usuário para digitar mais uma vez (entre 1 e 31)
            }

            Console.Write("Digite o mês do nascimento: "); // É pedido ao usuário para digitar o mês do nascimento
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12 || dia > 28 && mes == 2)   // Consistência do mês aceitável
            {
                Console.Write("Data inválida! Digite novamente: "); // Caso o mês for um valor inválido, a consistência permite o usuário para digitar mais uma vez (entre 1 e 12)
            }

            Console.Write("Digite o ano do nascimento: "); // É pedido ao usuário para digitar o ano do nascimento
            while (!int.TryParse(Console.ReadLine(), out ano) || ano < 1900 || ano > 2100)   // Consistência do ano aceitável
            {
                Console.Write("O ano do nascimento deve ser um número (inteiro) e entre 1900 e 2100! Digite novamente: "); // Caso o ano for um valor inválido, a consistência permite o usuário para digitar mais uma vez (entre 1900 e 2100)
            }
            Console.WriteLine("\n-------------------------------------------------------"); // Linha para melhor estética do programa
            Console.WriteLine("\nNome: {0}", nome); // Mensagem responsável por exibir o nome na tela
        } // fim do método digitacao

        static void Estacao() // método estacao
        {
            switch (mes) // Inicio do switch
            {
                case 1: // Inicio do case 1
                    Console.WriteLine("Nasceu na estação de Verão"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Verão
                    break; // Fim do case 1

                case 2: // Inicio do case 2
                    Console.WriteLine("Nasceu na estação de Verão");  // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Verão
                    break;  // Fim do case 2

                case 3: // Inicio do case 3
                    if (dia > 19)
                        Console.WriteLine("Nasceu na estação de Outono"); // Caso o dia do nascimento for maior que 19 no mês de Março, a pessoa nasceu na estação de Outono
                    else
                        Console.WriteLine("Nasceu na estação de Verão");  // Caso contrário, a pessoa nasceu na estação de Verão
                    break;  // Fim do case 3

                case 4: // Inicio do case 4
                    Console.WriteLine("Nasceu na estação de Outono"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Outono
                    break;  // Fim do case 4

                case 5: // Inicio do case 5
                    Console.WriteLine("Nasceu na estação de Outono"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Outono
                    break;  // Fim do case 5

                case 6: // Inicio do case 6
                    if (dia > 20)
                        Console.WriteLine("Nasceu na estação de Inverno"); // Caso o dia do nascimento for maior que 20 no mês de Junho, a pessoa nasceu na estação de Inverno
                    else
                        Console.WriteLine("Nasceu na estação de Outono"); // Caso contrário, a pessoa nasceu na estação de Outono
                    break;  // Fim do case 6

                case 7: // Inicio do case 7
                    Console.WriteLine("Nasceu na estação de Inverno"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Inverno
                    break;  // Fim do case 7

                case 8: // Inicio do case 8
                    Console.WriteLine("Nasceu na estação de Inverno"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Inverno
                    break;  // Fim do case 8

                case 9: // Inicio do case 9
                    if (dia > 22)
                        Console.WriteLine("Nasceu na estação da Primavera"); // Caso o dia do nascimento for maior que 22 no mês de Setembro, a pessoa nasceu na estação de Primavera
                    else
                        Console.WriteLine("Nasceu na estação de Inverno"); // Caso contrário, a pessoa nasceu na estação de Inverno
                    break;  // Fim do case 9

                case 10: // Inicio do case 10
                    Console.WriteLine("Nasceu na estação da Primavera"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Primavera
                    break;  // Fim do case 10

                case 11: // Inicio do case 11
                    Console.WriteLine("Nasceu na estação da Primavera"); // Mensagem sobre a estação do ano a pessoa nasceu, no caso, Primavera
                    break;  // Fim do case 11

                case 12: // Inicio do case 12
                    if (dia > 20)
                        Console.WriteLine("Nasceu na estação de Verão"); // Caso o dia do nascimento for maior que 20 no mês de Dezembro, a pessoa nasceu na estação de Verão
                    else
                        Console.WriteLine("Nasceu na estação da Primavera"); // Caso contrário, a pessoa nasceu na estação de Primavera
                    break;  // Fim do case 12

            }  // Fim do switch
        } // fim do método estacao

        static void Signo() // método signo
        {
            switch (mes) // Inicio do switch
            {
                case 1: // Inicio do case 1
                    if (dia > 20)
                        Console.WriteLine("O signo é de Aquário"); // caso o dia do nascimento for maior que 20 no mês de Janeiro, é informado o signo de Aquário
                    else
                        Console.WriteLine("O signo é Capricórnio"); // Caso contrário, é informado o signo de Capricórnio                  
                    break; // Fim do case 1

                case 2: // Inicio do case 2
                    if (dia > 19)
                        Console.WriteLine("O signo é Peixes"); // Caso o dia do nascimento for maior que 19 no mês de Fevereiro, é informado o signo de Peixes
                    else
                        Console.WriteLine("O signo é Aquário"); // Caso contrário, é informado o signo de Aquário                    
                    break;  // Fim do case 2

                case 3: // Inicio do case 3
                    if (dia > 20)
                        Console.WriteLine("O signo é Áries"); // Caso o dia do nascimento for maior que 20 no mês de Março, é informado o signo de Áries
                    else
                        Console.WriteLine("O signo é Peixes");  // Caso contrário, é informado o signo de Peixes
                    break;  // Fim do case 3

                case 4: // Inicio do case 4
                    if (dia > 20)
                        Console.WriteLine("O signo é Touro"); // Caso o dia do nascimento for maior que 20 no mês de Abril, é informado o signo de Touro
                    else
                        Console.WriteLine("O signo é Áries"); // Caso contrário, é informado o signo de Áries
                    break;  // Fim do case 4

                case 5: // Inicio do case 5
                    if (dia > 20)
                        Console.WriteLine("O signo é Gêmeos"); // Caso o dia do nascimento for maior que 20 no mês de Maio, é informado o signo de Gêmeos
                    else
                        Console.WriteLine("O signo é Touro"); // Caso contrário, é informado o signo de Touro
                    break;  // Fim do case 5

                case 6: // Inicio do case 6
                    if (dia > 20)
                        Console.WriteLine("O signo é Câncer"); // Caso o dia do nascimento for maior que 20 no mês de Junho, é informado o signo de Câncer
                    else
                        Console.WriteLine("O signo é Gêmeos"); // Caso contrário, é informado o signo de Gêmeos
                    break;  // Fim do case 6

                case 7: // Inicio do case 7
                    if (dia > 21)
                        Console.WriteLine("O signo é Leão"); // Caso o dia do nascimento for maior que 21 no mês de Julho, é informado o signo de Leão
                    else
                        Console.WriteLine("O signo é Câncer"); // Caso contrário, é informado o signo de Câncer
                    break;  // Fim do case 7

                case 8: // Inicio do case 8
                    if (dia > 22)
                        Console.WriteLine("O signo é Virgem"); // Caso o dia do nascimento for maior que 22 no mês de Agosto, é informado o signo de Virgem
                    else
                        Console.WriteLine("O signo é Leão"); // Caso contrário, é informado o signo de Leão
                    break;  // Fim do case 8

                case 9: // Inicio do case 9
                    if (dia > 22)
                        Console.WriteLine("O signo é Libra"); // Caso o dia do nascimento for maior que 22 no mês de Setembro, é informado o signo de Libra
                    else
                        Console.WriteLine("O signo é Virgem"); // Caso contrário, é informado o signo de Virgem
                    break;  // Fim do case 9

                case 10: // Inicio do case 10
                    if (dia > 22)
                        Console.WriteLine("O signo é Escorpião"); // Caso o dia do nascimento for maior que 22 no mês de Outubro, é informado o signo de Escorpião
                    else
                        Console.WriteLine("O signo é Libra"); // Caso contrário, é informado o signo de Libra
                    break;  // Fim do case 10

                case 11: // Inicio do case 11
                    if (dia > 21)
                        Console.WriteLine("O signo é Sagitário"); // Caso o dia do nascimento for maior que 21 no mês de Novembro, é informado o signo de Sagitário
                    else
                        Console.WriteLine("O signo é Escorpião"); // Caso contrário, é informado o signo de Escorpião
                    break;  // Fim do case 11

                case 12: // Inicio do case 12
                    if (dia > 21)
                        Console.WriteLine("O signo é Capricórnio"); // Caso o dia do nascimento for maior que 21 no mês de Dezembro, é informado o signo de Capricórnio
                    else
                        Console.WriteLine("O signo é Sagitário"); // Caso contrário, é informado o signo de Sagitário
                    break;  // Fim do case 12
            }  // Fim do switch
        } // fim do método signo
    } // Foram testados diversos valores e o programa está normal
}
