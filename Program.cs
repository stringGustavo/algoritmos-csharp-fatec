using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feito por: Gustavo Santos, Aluno 1º ADS - FATEC Guaratinguetá-SP.");
            Console.WriteLine("Exercícios de Algoritmo do 1 ao 110.\n\nLista 01 - Exercícios do 001 ao 009;  [Exercícios Introdutórios]\nLista 02 - Exercícios do 010 ao 020;  [Funções Matemáticas Básicas]\nLista 03 - Exercícios do 021 ao 023;  [Condições Lógicas & 'if'/'else']\nLista 04 - Exercícios do 024 ao 033;  ['if'/'else']\nLista 05 - Exercícios do 034 ao 046;  ['if'/'else' & 'switch']\nLista 06 - Exercícios do 047 ao 053;  [Estrutura de Repetição 'while']\nLista 07 - Exercícios do 054 ao 063;  [Estrutura de Repetição 'while']\nLista 08 - Exercícios do 064 ao 071;  [Estrutura de Repetição 'while' || 'do/while']\nLista 09 - Exercícios do 072 ao 087;  [Estrutura de Repetição 'for']\nLista 10 - Exercícios do 088 ao 103;  [Array/Vetor]\nLista 11 - Exercícios do 104 ao 110;  [Array/Vetor]\n");

            Console.Write("Digite o número de um Exercício: ");
            double repeat = double.Parse(Console.ReadLine());

            while(repeat < 1 || repeat > 110)
            {
                Console.WriteLine("Digite um número entre 1 e 110!!");

                Console.Write("Digite o número de um Exercício: ");
                repeat = double.Parse(Console.ReadLine());
            }

            string exercicio = Convert.ToString(repeat);

            switch(exercicio)
            {
                case "1":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n01 – Elaborar um algoritmo que imprima a frase: 'Aprendendo Algoritmo'\n ---------------------------------");

                    Console.WriteLine("Aprendendo Algoritmo\n");
                }

                break;

                case "2":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n02 – Elabore um algoritmo que imprima a frase da maneira descrita abaixo, uma frase abaixo da outra: Aprendendo Algoritmo e Fazendo muito Exercício, Primeiro fazendo exercício em 'C#'\n ---------------------------------");

                    Console.WriteLine("Aprendendo Algoritmo\ne Fazendo muito Exercício,\nPrimeiro fazendo exercício em 'C#'.\n");
                }

                break;

                case "3":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("03 – Crie um algoritmo que leia dois nomes e imprima os nomes na sequência em que foram escritos e posteriormente os imprima na ordem inversa.\n ---------------------------------");

                    Console.Write("Digite um nome: ");
                    string nome1 = Console.ReadLine();

                    Console.Write("Digite outro nome: ");
                    string nome2 = Console.ReadLine();

                    Console.WriteLine(nome1 + nome2);
                    Console.WriteLine("\n" + nome2 + nome1);
                }

                break;

                case "4":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n04 – Crie um algoritmo que receba duas variáveis do tipo inteiro.\nAtribuir um valor para cada variável e posteriormente exibir este valor.\nPara finalizar, exibir a primeira variável acrescida de uma unidade e exibir a segunda variável decrescida de uma unidade.\n ---------------------------------");

                    Console.Write("Digite um número: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números digitados: " +n1+ " e " +n2+".");

                    n1 = n1 + 1;
                    n2 = n2 - 1;

                    Console.WriteLine("Primero número digitado + 1: " +n1+".");
                    Console.WriteLine("Segundo número digitado - 1: " +n2+".");
                }

                break;

                case "5":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n05 – Cria um algoritmo que receba 5 números do tipo double e exiba a soma com a seguinte frase:\n    'Os números digitados foram ..., ..., ..., ... e sua soma é ... .'\n ---------------------------------");

                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o terceiro número: ");
                    double n3 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o quarto número: ");
                    double n4 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o quinto número: ");
                    double n5 = double.Parse(Console.ReadLine());

                    double soma = n1 + n2 + n3 + n4 + n5;

                    Console.WriteLine("Os números digitados foram: " +n1+"," +n2+"," +n3+"," +n4+ " e " +n5+ " e sua soma é: " +soma+".");
                }

                break;

                case "6":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n06 – Ler dois números e exibir as seguintes mensagens:\nOs números digitados foram ... e .... .\nA soma dos números ... e ... é ... .\nA subtração dos números ... e ... é ... .\nA multiplicação dos números ... e ... é ... .\nA divisão dos números ... e ... é ... .\nA média dos números ... e ... é ... .\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    double soma = num1 + num2;
                    double subt = num1 - num2;
                    double mult = num1 * num2;
                    double div = num1 / num2;
                    double media = soma / 2;

                    Console.WriteLine("Os números digitados foram: " +num1+ " e " +num2+".");
                    Console.WriteLine("A soma dos números digitados é: " +soma+ ".");
                    Console.WriteLine("A subtração dos números digitados é : " +subt+".");
                    Console.WriteLine("A multiplicação dos números digitados é: " +mult+".");
                    Console.WriteLine("A divisão dos números digitados é: " +div+".");
                    Console.WriteLine("A média dos números digitados é: " +media+".");
                }

                break;

                case "7":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n07 – Ler um número inteiro e imprimir seu antecessor e seu sucessor.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int num = int.Parse(Console.ReadLine());

                    int num_ant = num - 1;
                    int num_suc = num + 1;

                    Console.WriteLine("O antecessor de " +num+ " é " +num_ant+".");
                    Console.WriteLine("O sucessor de " +num+ " é " +num_suc+".");
                }

                break;

                case "8":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n08 – Elabore um algoritmo que calcule a área e o perímetro de um quadrado.\n---------------------------------");

                    Console.Write("Digite o valor do lado do quadrado: ");
                    double lado = int.Parse(Console.ReadLine());

                    double area = lado * lado;
                    double perimetro = lado + lado + lado + lado;

                    Console.WriteLine("A área do quadrado é: " +area+".");
                    Console.WriteLine("O Perímetro do quadrado é: " +perimetro+".");
                }

                break;

                case "9":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n09 – Elabore um algoritmo que calcule a área e o perímetro de um retângulo.\n---------------------------------");

                    Console.Write("Digite o valor referente a base do retângulo: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor referente a altura do retângulo: ");
                    int a = int.Parse(Console.ReadLine());

                    int area = b * a;
                    int perimetro = a + b + a + b;

                    Console.WriteLine("Área: " + area + " Perímetro: " + perimetro);

                }

                break;

                case "10":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n10- Crie um Algoritmo que receba um número e imprima sua raiz quadrada.\n---------------------------------");

                    Console.Write("Digite um número para calcular sua raiz quadrada: " );
                    double raizq = double.Parse(Console.ReadLine());

                    Console.Write("A Raiz quadrada de " +raizq+" é ");
                    Console.Write(Math.Sqrt(raizq));
                }

                break;

                case "11":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n11 – Crie um Algoritmo que receba um número e imprima seu valor elevado a 2, elevado a 3, elevado a 4 e elevado a 5.\n---------------------------------");

                    Console.Write("Digite o número que deseja elevar: ");
                    double numero = double.Parse(Console.ReadLine());

                    Console.Write("" +numero+ " elevado ao quadrado é: ");
                    Console.WriteLine(Math.Pow(numero, 2));
                    Console.Write("" +numero+ " elevado ao cubo é: ");
                    Console.WriteLine(Math.Pow(numero, 3));
                    Console.Write("" +numero+ " elevado a quarta é: ");
                    Console.WriteLine(Math.Pow(numero, 4));
                    Console.Write("" +numero+ " elevado a quinta é: ");
                    Console.WriteLine(Math.Pow(numero, 5));      
                }

                break;

                case "12":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n12 – Crie um Algoritmo que receba um número e imprima sua raiz quadrada e sua raiz cúbica.\n---------------------------------");

                    Console.WriteLine("Digite o número que deseja elevar ao quadrado: ");
                    double numero = double.Parse(Console.ReadLine());

                    Console.Write("A raiz quadrada de " +numero+ " é: ");
                    Console.WriteLine(Math.Pow(numero, 2));
                    Console.Write("A raiz cúbica de " +numero+ " é: ");
                    Console.WriteLine(Math.Pow(numero, 1/ 3.0));
                }

                break;

                case "13":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n13 – Entrar com quatro números e imprimir a média ponderada, sabendo-se que os pesos são respectivamente 1, 2, 3 e 4.\n---------------------------------");
                    
                    Console.Write("Digite um número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    double n3 = double.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    double n4 = double.Parse(Console.ReadLine());

                    double media_p = (n1 + (n2 * 2) + (n3 * 3) + (n4 * 4)) / 10;

                    Console.Write("A média ponderada é: " +media_p+".");
                }

                break;

                case "14":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n14- Elabore um algoritmo que entre com valor do raio e calcule a área e o perímetro do círculo correspondente.\n---------------------------------");

                    Console.Write("Digite o valor do Raio do círculo: ");
                    double raio = double.Parse(Console.ReadLine());

                    double area = (3.14 * (raio * raio));
                    double perimetro = (2 * 3.14 * raio);

                    Console.WriteLine("O Perímetro do círculo é: " + perimetro +".");
                    Console.WriteLine("A Área do círculo é: " + area +".");
                }

                break;

                case "15":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n15 - Entrar com os lados A, B e C de um paralelepípedo.\nCalcular e imprimir o volume.\n---------------------------------");

                    Console.WriteLine("Calcule o volume do Paralelepípedo");

                    Console.Write("Digite o valor do Lado A: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do lado B: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do lado C: ");
                    double c = double.Parse(Console.ReadLine());

                    double volume = a * b * c;

                    Console.WriteLine("O Volume do Paralelepípedo é: " +volume+ ".");
                }

                break;

                case "16":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n16 - Elabore um algoritmo que calcule a área de um trapézio qualquer.\n---------------------------------");

                    Console.Write("Digite o valor da base maior do trapézio: ");
                    double bmaior = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da base menor do trapézio: ");
                    double bmenor = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da altura do trapézio: ");
                    double h = double.Parse(Console.ReadLine());

                    double area = (((bmaior + bmenor) * h) / 2);

                    Console.WriteLine("A Área do trapézio é: " +area+ "");
                }

                break;

                case "17":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n17 - Construa um algoritmo que possa calcular o volume de um prisma de base triangular.\n---------------------------------");

                    Console.Write("Digite o valor da Área da base do triângulo: ");
                    double areabase = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da Altura do triângulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    
                    double volume = areabase * altura;

                    Console.WriteLine("O Volume do triângulo é: " +volume+ ".");
                }

                break;

                case "18":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n18 - Crie um algoritmo que possa calcular a área de uma coroa de forma circular.\n---------------------------------");

                    Console.Write("Digite o valor do Raio Maior da coroa: ");
                    double raiomaior = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do Menor Raio da coroa: ");
                    double raiomenor = double.Parse(Console.ReadLine());

                    double areacircmaior = 3.14 * raiomaior * raiomaior;
                    double areacircmenor = 3.14 * raiomenor * raiomenor;
                    double area = areacircmaior - areacircmenor;

                    Console.WriteLine("A Área da coroa circular é: " +area+ ".");
                }

                break;

                case "19":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n19 - Elabore um algoritmo que possa calcular o volume de um cilindro.\n---------------------------------");

                    Console.Write("Digite o valor do Raio do Cilindro: ");

                    double raio = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da Altura do Cilindro: ");

                    double altura = double.Parse(Console.ReadLine());
                    double volume = 3.14 * (raio * raio) * altura;

                    Console.Write("O Volume do Cilindro é: " +volume+ ".");
                }

                break;

                case "20":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n20 - Elabore um algoritmo para calcular o volume e a área de uma esfera.\n---------------------------------");
    
                    Console.Write("Digite o valor do Raio da esfera: ");

                    double raio = double.Parse(Console.ReadLine());
                    double area = 4 * 3.14 * raio * raio;
                    double volume = 4 / 3.0 * 3.14 * raio * raio * raio;

                    Console.WriteLine("A Área da Esfera é: " +area+ " m².");
                    Console.WriteLine("O Volume da Esfera é: " +volume+ " cm³.");
                }

                break;

                case "21":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n21 – Entrar com quatro notas de um aluno e imprimir a média ponderada destas notas,\nsabendo-se que os pesos são respectivamente 3, 5, 6 e 6.\n\nImprima também se o aluno está aprovado ou reprovado sabendo-se\nque para ser aprovado a média deve ser maior que 6,00.\n---------------------------------");

                    Console.Write("Digite a primeira nota: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a segunda nota: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a terceira nota: ");
                    double n3 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a quarta nota: ");
                    double n4 = double.Parse(Console.ReadLine());

                    double notafinal = (((n1 * 3) + (n2 * 5) + (n3 * 6) + (n4 * 6)) / 20);

                    if (notafinal < 6) { Console.WriteLine("A nota final é: "+notafinal+ ".");
                    Console.WriteLine("Você não foi aprovado."); }

                    else { Console.WriteLine("A nota final é: " + notafinal + ".");
                    Console.WriteLine("Você foi aprovado.");
                    }
                }

                break;

                case "22":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n22 – Entrar com três números e imprimir a média aritmética. Imprima também se o aluno está aprovado ou reprovado sabendo-se que para ser aprovado a média deve ser maior ou igual à 7,50.\n---------------------------------");

                    Console.Write("Digite a sua primeira nota: ");
                    double nota1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a sua primeira nota: ");
                    double nota2 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a sua primeira nota: ");
                    double nota3 = double.Parse(Console.ReadLine());

                    double notafinal = ((nota1 + nota2 + nota3) / 3);

                    if (notafinal < 7.50) {
                        Console.WriteLine("Sua nota final é: "+notafinal+".");
                        Console.WriteLine("Você não foi aprovado."); }
            
                    else 
                    {
                        Console.WriteLine("Sua nota final é: " + notafinal + ".");
                        Console.WriteLine("Você foi aprovado."); }
                }

                break;

                case "23":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n23 - O algoritmo deve receber um número qualquer.\nSe o número for par o algoritmo deve imprimir seu valor e seu valor elevado ao quadrado.\nSe o número for ímpar o algoritmo deve imprimir seu valor e seu valor elevado ao cubo.\n---------------------------------");

                    Console.Write("Digite um número qualquer: ");
                    double num = double.Parse(Console.ReadLine());

                    if (num % 2 == 0) {
                        Console.WriteLine("O número " + num + " é par.");
                        Console.Write("O número " + num + " elevado ao quadrado é: ");
                        Console.WriteLine(Math.Pow(num, 2)); }

                    else { Console.WriteLine("O número " +num+ " é impar.");
                        Console.Write("O número " + num + " elevado ao cubo é: ");
                        Console.WriteLine(Math.Pow(num,3)+".");
                    }
                }

                break;

                case "24":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n24 - Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts,\nmas agora, todos incorporaram essa palavra em seu vocabulário.\n\nSabendo-se que 100 quilowatts de energia custa um sétimo do salário mínimo,\nfaça um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta por uma residência.\n\nCalcule e imprima:\n  - O valor em reais de cada quilowatt.\n  - O valor em reais a ser pago.\n  - O novo valor a ser pago por essa residência com um desconto de 10%.\n---------------------------------");

                    Console.Write("Quilowatts gastos: ");
                    double qwatt = double.Parse(Console.ReadLine());

                    double salario = 1212.00;
                    double umqwatt = salario / 7 / 100;
                    double valorpago = qwatt * umqwatt;
                    double desconto = valorpago * 0.10;
                    double valordesconto = valorpago - desconto;

                    Console.WriteLine("O valor do Quilowatt é: R$ " +Math.Round(umqwatt, 2, MidpointRounding.AwayFromZero)+ ".");
                    Console.WriteLine("O valor a ser pago é: R$ " +Math.Round(valorpago, 2, MidpointRounding.AwayFromZero)+ ".");
                    Console.WriteLine("O valor a ser pago com desconto é: R$ " +Math.Round(valordesconto, 2, MidpointRounding.AwayFromZero)+ ".");                    
                }

                break;

                case "25":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n25 - Criar um algoritmo que calcule e imprima a área e a hipotenusa de um triângulo retângulo.\nObservação: Os valores devem ser positivos.\n---------------------------------");

                    Console.Write("Digite o valor do cateto B: ");
                    double ctt1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do cateto A: ");
                    double ctt2 = double.Parse(Console.ReadLine());

                    double hipt = Math.Pow(ctt1, 2) + Math.Pow(ctt2, 2);
                    double hiptresult = Math.Sqrt(hipt);
                    double area = ctt1 * ctt2 / 2;

                    Console.WriteLine("O valor da Hipotenusa é: " +Math.Round(hiptresult, 2, MidpointRounding.AwayFromZero)+ ".");
                    Console.WriteLine("O valor da Área é: " +area+ ".");
                }

                break;

                case "26":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n26 - Digitar um valor qualquer e imprimir se o valor digitado é “Par” ou “Ímpar”.\nAtenção: os números dever ser maiores que zero.\n---------------------------------");

                    Console.Write("Digite um valor qualquer: ");
                    double num = double.Parse(Console.ReadLine());

                    if (num <= 0) {Console.WriteLine("Erro, digite um valor maior que zero!");}

                    else if (num % 2 == 0) {Console.WriteLine("O número " +num+ " é par.");}
            
                    else {Console.WriteLine("O número "+num+" é ímpar.");}
                }

                break;

                case "27":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n27 - Ler um número qualquer, positivo e maior que zero.\nSe o valor do número elevado à quarta for par e múltiplo de cinco o algoritmo deverá imprimir a seguinte mensagem:\n  - 'O número digitado foi __.'\n  - 'Seu valor elevado ao quadrado é __.'\n  - 'Seu valor elevado ao cubo é __.'\n  - 'Seu valor elevado a sétima é __.'\n\nSe o valor for ímpar o algoritmo deverá imprimir a seguinte mensagem:\n  - 'O número digitado foi __.'\n  - 'Sua raiz quadrada é __.'\n  - 'Sua raiz cúbica é __.'\n  - 'Sua raiz a sétima é __.'\n\nObservação: Se o usuário digitar um valor inválido o algoritmo deverá emitir uma mensagem de erro.\n---------------------------------");

                    Console.Write("Digite um número positivo: ");
                    double num = double.Parse(Console.ReadLine());

                    double num_elev_4 = Math.Pow(num, 4);
                    
                    if(num_elev_4 % 2 == 0 || num_elev_4 % 5 == 0){

                        double num_elev_2 = Math.Pow(num, 2);
                        double num_elev_3 = Math.Pow(num, 3);
                        double num_elev_7 = Math.Pow(num, 7);

                        Console.WriteLine("O número digitado foi: "+num+".");
                        Console.WriteLine("Seu valor elevado ao quadrado é: "+num_elev_2+".");
                        Console.WriteLine("Seu valor elevado ao cubo é: "+num_elev_3+".");
                        Console.WriteLine("Seu valor elevado a sétima é: "+num_elev_7+".");
                    }

                    if(num_elev_4 % 2 != 0){

                        double num_raiz_2 = Math.Sqrt(num);
                        double num_raiz_3 = Math.Pow(num, 1/3.0);
                        double num_raiz_7 = Math.Pow(num, 1/7.0);

                        Console.WriteLine("O número digitado foi: "+num+".");
                        Console.WriteLine("Sua raiz quadrada é: "+num_raiz_2+".");
                        Console.WriteLine("Sua raiz cúbica é: "+num_raiz_3+".");
                        Console.WriteLine("Sua raiz sétima é: "+num_raiz_7+".");
                    }
                }

                break;

                case "28":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n28 - Ler três números.\n  - Exibir os três números informando se eles são positivos, negativos ou nulos.\n  - Informar o maior número.\n---------------------------------");

                    Console.Write("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o terceiro número: ");
                    int num3 = int.Parse(Console.ReadLine());

                    if(num1 > 0)
                    {
                        Console.WriteLine(num1+" é Positivo.");

                    }else if(num1 < 0)
                    {
                        Console.WriteLine(num1+" é Negativo.");

                    }else
                    {
                        Console.WriteLine(num1+" é Nulo.");
                    }
                        // Primeiro número \\

                    if(num2 > 0)
                    {
                        Console.WriteLine(num2+" é Positivo.");

                    }else if(num2 < 0)
                    {
                        Console.WriteLine(num2+" é Negativo.");

                    }else
                    {
                        Console.WriteLine(num2+" é Nulo.");
                    }
                        // Segundo número \\

                    if(num3 > 0)
                    {
                        Console.WriteLine(num3+" é Positivo.");

                    }else if(num3 < 0)
                    {
                        Console.WriteLine(num3+" é Negativo.");

                    }else
                    {
                        Console.WriteLine(num3+" é Nulo.");
                    }
                        // Terceiro número \\

                    int maior = int.MinValue;

                    if(num1 > maior)
                    {
                        maior = num1;
                    }

                    if(num2 > maior)
                    {
                        maior = num2;
                    }

                    if(num3 > maior)
                    {
                        maior = num3;
                    }

                    Console.WriteLine("O maior número é: "+maior+".");
                }

                break;

                case "29":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n29 - Construir um algoritmo que leia dois valores numéricos e efetue sua adição.\nCaso o resultado da adição seja maior que 10, exibir os números digitados, o valor da adição e a raiz cúbica da adição.\nCaso contrário exibir somente os valores digitados e o valor da adição.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    double soma = n1 + n2;
                    double rcub = Math.Pow(soma, 1/3.0);

                    if(soma > 10){Console.WriteLine("Os números digitados foram: "+n1+ " e " +n2+".");
                    Console.WriteLine("A soma dos números é: " +soma+ ".");
                    Console.WriteLine("A raiz cúbica de " +soma+ " é " +Math.Round(rcub, 2, MidpointRounding.AwayFromZero)+".");}

                    else{Console.WriteLine("Os números digitados foram: "+n1+ " e " +n2+".");
                    Console.WriteLine("A soma dos números é: " +soma+ ".");} 
                }

                break;

                case "30":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n30 - Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.\nA fórmula de conversão é: F = C*(9.0/5.0)+32.0, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.\n---------------------------------");

                    Console.Write("Digite a temperatura em graus Celsius: ");
                    double tempc = double.Parse(Console.ReadLine());

                    double tempf = tempc * (9.0 / 5.0) + 32.0;

                    Console.WriteLine(tempc+"ºC são: "+Math.Round(tempf, 1, MidpointRounding.AwayFromZero)+"ºF.");
                }

                break;

                case "31":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n31 - Efetuar a leitura de três valores e apresentar como resultado final a soma dos quadrados dos três valores lidos.\nApresentar também se a soma é um número par ou ímpar.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    double n3 = double.Parse(Console.ReadLine());

                    double somaq = Math.Pow(n1, 2) + Math.Pow(n2, 2) + Math.Pow(n3, 2);

                    if(somaq % 2 == 0){Console.WriteLine("A soma dos quadrados de " +n1+ ", " +n2+ " e " +n3+ " é: " +somaq+".");
                    Console.WriteLine(somaq+ " é par.");}

                    else{Console.WriteLine("A soma dos quadrados de " +n1+ ", " +n2+ " e " +n3+ " é: " +somaq+".");
                    Console.WriteLine(somaq+ " é ímpar.");}
                }

                break;

                case "32":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n32 - Receber o salário de um funcionário, exibir o valor deste salário,\ncalcular e mostrar seu novo salário, sabendo que ele recebeu um aumento de 25%.\n---------------------------------");

                    Console.Write("Digite o salário do funcionario: ");
                    double salario = double.Parse(Console.ReadLine());

                    Console.Write("Digite a porcentagem do aumento: ");
                    double aumento = double.Parse(Console.ReadLine());

                    double pct = aumento / 100;
                    double valorpct = salario * pct; 
                    double sfinal = salario + valorpct;

                    Console.WriteLine("Seu novo salário será de: R$"+Math.Round(sfinal, 2, MidpointRounding.AwayFromZero)+".");
                }

                break;

                case "33":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n33 - Receber a altura do degrau de uma escada e a altura que o usuário deseja alcançar subindo a escada.\nCalcular e mostrar quantos degraus o usuário deverá subir para atingir seu objetivo,\nsem se preocupar com a altura do usuário.\n---------------------------------");

                    Console.WriteLine("Tamanho máximo do degrau recomendado é 18cm.");
                    Console.Write("Digite a altura do degrau em Cm: ");
                    double tmdegrau = double.Parse(Console.ReadLine());

                    Console.Write("Digite a altura a ser alcançada em metros: ");
                    double altura = double.Parse(Console.ReadLine());

                    double degraupcm = tmdegrau / 100;
                    double qntdegrau = altura / degraupcm;

                    Console.WriteLine("A escada terá: "+Math.Round(qntdegrau, 2, MidpointRounding.AwayFromZero)+" degraus.");
                }

                break;

                case "34":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n34 - Criar um algoritmo que calcule e imprima a área de um losango.\nSe os valores de entrada forem negativos ou iguais a zero o algoritmo deve imprimir uma mensagem de erro.\n---------------------------------");

                    Console.Write("Digite o valor da Diagonal 1: ");
                    double d1 = double.Parse(Console.ReadLine());
            
                    Console.Write("Digite o valor da Diagonal 2: ");
                    double d2 = double.Parse(Console.ReadLine());

                    double area = (d1 * d2) / 2;

                    if(d1 <= 0 || d2 <= 0){Console.WriteLine("Valores inválidos");}

                    else{Console.WriteLine("A área do Losango é: "+area+".");}
                }

                break;

                case "35":

                for (int x = 0; x < 1; x++)
                {
			Console.WriteLine("35 - Equação de segundo grau.\n---------------------------------");

            		Console.Write("Digite o valor de A: ");
            		double a = double.Parse(Console.ReadLine());
            
            		Console.Write("Digite o valor de B: ");
            		double b = double.Parse(Console.ReadLine());

            		Console.Write("Digite o valor de C: ");
            		double c = double.Parse(Console.ReadLine());

            		double delta = Math.Pow(b,2) - 4 * a * c;

            		double x1 = (- b + Math.Sqrt(delta)) / 2 * a;
            		double x2 = (- b - Math.Sqrt(delta)) / 2 * a; 
            		double xv = - b / 2 * a;
            		double yv = (- delta) / 4 * a;

            		if (delta < 0) {Console.Write("Não tem solução, pois o Delta é negativo.");
            		}

            		else {Console.WriteLine("O valor de delta é: "+delta+".");
            		Console.WriteLine("O valor de X1 é: " +x1+ ".");
           		Console.WriteLine("O valor de X2 é: " +x2+ ".");
            		Console.WriteLine("X do vértice é: " +xv+ ".");
            		Console.WriteLine("Y do vértice é: " +yv+".");
            		}
                }

                break;

                case "36":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("36 - Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo desconto.\nFaça um algoritmo que possa entrar com o valor de um produto e imprimir o novo valor tendo em vista que o desconto foi de 9%.\nO valor do produto não pode ser menor ou igual a zero.\n---------------------------------");

                    Console.Write("Digite o valor do produto: ");
                    double valorproduto = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do desconto: ");
                    double desc = double.Parse(Console.ReadLine());

                    double pct = desc / 100;
                    double valordesc = pct * valorproduto;
                    double valorf = valorproduto - valordesc;

                    if(valorproduto <= 0 || desc <= 0){Console.WriteLine("Valor inválido");}

                    else{Console.WriteLine("O valor do produto com desconto é de: R$"+Math.Round(valorf, 2, MidpointRounding.AwayFromZero)+".");}
                }

                break;

                case "37":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n37 - Efetuar a leitura de um número e apresentar o resultado do quadrado desse número.\nDepois verificar se este novo valor é maior que 10, menor que 10 ou igual a 10.\nSe for maior que 10 apresentar também sua Raiz Cúbica.\n---------------------------------");

                    Console.Write("Digite um valor qualquer: ");
                    double num = double.Parse(Console.ReadLine());

                    double num_elevado2 = Math.Pow(num, 2);
                    double num_elevado3 = Math.Pow(num, 1 / 3.0);

                    if(num_elevado2 > 10){Console.WriteLine(num+" elevado ao quadrado é "+num_elevado2+" maior que 10.");
                        Console.WriteLine("Sua raiz cúbica é: "+Math.Round(num_elevado3, 2, MidpointRounding.AwayFromZero)+".");}

                    else if(num_elevado2 < 10){Console.WriteLine(num+" elevado ao quadrado é "+num_elevado2+" menor que 10.");}
                    else {Console.WriteLine(num+" elevado ao quadrado é" +num_elevado2+ "igual a 10.");}
                }

                break;

                case "38":

                for (int x = 0; x < 1; x++)
                {    
                    Console.WriteLine("\n----------Exercício 29, Repetido!!----------\n");
                    Console.WriteLine("\n38 - Construir um algoritmo que leia dois valores numéricos e efetue sua adição.\nCaso o resultado da adição seja maior que 10, exibir os números digitados, o valor da adição e a raiz cúbica da adição.\nCaso contrário exibir somente os valores digitados e o valor da adição.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    double soma = n1 + n2;
                    double rcub = Math.Pow(soma, 1/3.0);

                    if(soma > 10){Console.WriteLine("Os números digitados foram: "+n1+ " e " +n2+".");
                    Console.WriteLine("A soma dos números é: " +soma+ ".");
                    Console.WriteLine("A raiz cúbica de " +soma+ " é " +Math.Round(rcub, 2, MidpointRounding.AwayFromZero)+".");}

                    else{Console.WriteLine("Os números digitados foram: "+n1+ " e " +n2+".");
                    Console.WriteLine("A soma dos números é: " +soma+ ".");} 

                }

                break;

                case "39":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n----------Exercício 32, Repetido!!----------\n");
                    Console.WriteLine("\n32 - Receber o salário de um funcionário, exibir o valor deste salário,\ncalcular e mostrar seu novo salário, sabendo que ele recebeu um aumento de 25%.\n---------------------------------");

                    Console.Write("Digite o salário do funcionario: ");
                    double salario = double.Parse(Console.ReadLine());

                    Console.Write("Digite a porcentagem do aumento: ");
                    double aumento = double.Parse(Console.ReadLine());

                    double pct = aumento / 100;
                    double valorpct = salario * pct; 
                    double sfinal = salario + valorpct;

                    Console.WriteLine("Seu novo salário será de: R$"+Math.Round(sfinal, 2, MidpointRounding.AwayFromZero)+".");
                }

                break;

                case "40":

                for (int x = 0; x < 1; x++)
                {     
                    Console.WriteLine("\n40 - Utilize a estrutura if ou switch.\nAlgoritmo CALCULADORA SIMPLES.\nEm um primeiro momento o algoritmo deve perguntar ao usuário que tipo de operação ele deseja efetuar:\nSoma;\nSubtração;\nMultiplicação;\nDivisão.\n\nEm um segundo momento o algoritmo deve solicitar que o usuário digite dois número e exibir o resultado desejado.\nCuidado com as divisões que tenham como denominador o número zero.\n---------------------------------");

                    double result = 0;

                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite a Operação: ");
                    string operation = Console.ReadLine();

                    while(operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {            
                        Console.Write("Digite a Operação: ");
                        operation = Console.ReadLine();
                    }

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    switch(operation)
                    {
                        case "+":
                        result = num1 + num2;
                        break;

                        case "-":
                        result = num1 - num2;
                        break;

                        case "*":
                        result = num1 * num2;
                        break;

                        case "/":
                        result = num1 / num2;
                        break;

                        default: Console.WriteLine("Operação inválida!");
                        break;
                    }

                    if(num2 == 0 && operation == "/")
                    {
                        Console.WriteLine("{0} {1} {2} = Não é possível dividir por zero.", num1, operation, num2);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
                    }
                }

                break;

                case "41":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n41 - Entrar com um número qualquer.\nSe o número for positivo, imprimir o número digitado e sua raiz quadrada.\nSe o número for negativo, imprimir o número digitado e seu valor elevado ao quadrado.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double num = int.Parse(Console.ReadLine());

                    if(num > 0)
                    {
                        Console.WriteLine("O número digitado foi: {0}", num);
                        Console.WriteLine("A raiz quadrada de {0} é: {1}", num, Math.Sqrt(num));   
                    }
                    else if(num < 0)
                    {
                        Console.WriteLine("O número digitado foi: {0}", num);
                        Console.WriteLine("{0} elevado ao quadrado é: {1}", num, Math.Pow(num, 2));
                    }
                    else
                    {
                        Console.WriteLine("O número digitado foi: {0}", num);
                    }
                }

                break;

                case "42":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n42 - Entrar com o nome e duas notas de um aluno.\nAs notas vão de zero a dez e o algoritmo deve imprimir o nome do aluno, suas notas e sua média.\nSe a nota for maior que 7 – imprimir “Aprovado”.\nSe a nota for menor que 5 – imprimir “Retido”.\nCaso contrário - imprimir “Recuperação”.\nSe as notas não estiverem no intervalo estabelecido o algoritmo deve emitir uma mensagem de erro.\n---------------------------------");

                    Console.Write("Digite o nome do Aluno(a): ");
                    string aluno = Console.ReadLine();

                    Console.Write("Digite a primeira nota: ");
                    double nota01 = Convert.ToDouble(Console.ReadLine());
            
                    Console.Write("Digite a segunda nota: ");
                    double nota02 = Convert.ToDouble(Console.ReadLine());

                    double notafinal = (nota01 + nota02) / 2;

                    if(nota01 > 10 || nota02 > 10 || nota01 < 0 || nota02 < 0){Console.WriteLine("Valores inválidos");}

                    else if(notafinal > 5 && notafinal < 7) {Console.WriteLine("{0} está de recuperação, sua nota é {1}", aluno, notafinal); }
                    else if(notafinal < 5) {Console.WriteLine("{0} está reprovado(a), sua nota é {1}.", aluno, notafinal); }
                    else if(notafinal >= 7) {Console.WriteLine("{0} está aprovado(a), sua nota é {1}.", aluno, notafinal);}
                }

                break;

                case "43":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n43 - Calculando o IMC – Índice de Massa Corporal.\nPara calcular o índice de massa corporal basta utiliza a fórmula abaixo e comparar o resultado com a tabela abaixo.\n\n  IMC = peso/altura²\n\nAtenção: Peso em Kg e Altura em Metros.\n\nTabela:\nAbaixo de 17 - Muito abaixo do peso.\nEntre 17 e 18,49 - Abaixo do peso.\nEntre 18,5 e 24,99 - Peso normal.\nEntre 25 e 29,99 Acima do peso.\nEntre 30 e 34,99 Obesidade I.\nEntre 35 e 39,99 Obesidade II (severa).\nAcima de 40 Obesidade III (mórbida).\n\nObservação:\nO peso e a altura não podem ser nulos ou negativos.\n---------------------------------");

                    Console.WriteLine("Calcule seu IMC.");

                    Console.Write("Digite sua altura: ");
                    double alt = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite seu peso: ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    double alt_elev = Math.Pow(alt, 2);
                    double imc = peso / alt_elev;

                    if (alt <= 0 || peso <= 0){Console.WriteLine("Valores inválidos");}
            
                    else if(imc < 17) {Console.WriteLine("Muito abaixo do peso");}  
                    else if (imc > 17 && imc < 18.49) {Console.WriteLine("Seu IMC é: {0}. Você está Abaixo do peso.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                    else if (imc > 18.5 && imc < 24.99) {Console.WriteLine("Seu IMC é: {0}. Você está com Peso Normal.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                    else if (imc > 25 && imc < 29.99) {Console.WriteLine("Seu IMC é: {0}. Você está Acima do Peso.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                    else if (imc > 30 && imc < 34.99) {Console.WriteLine("Seu IMC é: {0}. Você está com Obesidade 1.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                    else if (imc > 35 && imc < 39.99) {Console.WriteLine("Seu IMC é: {0}. Você está com Obesidade 2.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                    else {Console.WriteLine("Seu IMC é: {0}. Você está com Obesidade 3.", Math.Round(imc, 2, MidpointRounding.AwayFromZero));}
                }

                break;

                case "44":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n44 - Uma sorveteria vende três tipos de picolés.\nSabendo-se que o picolé do tipo 1 é vendido por R$ 1.50, o do tipo 2 por R$ 2.60\ne o do tipo 3 por R$ 3.75, faça um algoritmo que receba a quantidade comprada\ne o tipo do picolé (1, 2 ou 3) e imprima a quantidade vendida , o tipo, o preço e o total arrecadado.\n---------------------------------");

                    Console.Write("Digite a quantidade a ser comprada: ");
                    int qnt = int.Parse(Console.ReadLine());

                    Console.Write("Digite o tipo do picolé: ");
                    string tipo = Console.ReadLine();

                    switch(tipo)
                    {
                        case "1":

                            double tipo_1 = 1.50;
                            double total = qnt * tipo_1;
                            Console.WriteLine("\nQuantidade vendida: {0}\nTipo: 1\nPreço da Unidade: R${1}\nTotal: R${2}", qnt, tipo_1, total);

                        break;

                        case "2":

                            double tipo_2 = 2.60;
                            total = qnt * tipo_2;
                            Console.WriteLine("\nQuantidade vendida: {0}\nTipo: 2\nPreço da Unidade: R${1}\nTotal: R${2}", qnt, tipo_2, total);

                        break;

                        case "3":

                            double tipo_3 = 3.75;
                            total = qnt * tipo_3;
                            Console.WriteLine("\nQuantidade vendida: {0}\nTipo: 3\nPreço da Unidade: R${1}\nTotal: R${2}", qnt, tipo_3, total);

                        break;
                    }
                }

                break;

                case "45":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n45 - O cardápio de uma lanchonete é o seguinte:\n\nCódigo     Especificação     Preço unitário\n 100      Cachorro quente         4,50\n 101       Bauru simples          4,50\n 102        Bauru c/ovo           5,50\n 103        Hambúrguer            6,50\n 104       Refrigerante           3,50\n\nEscrever um algoritmo que leia o código do item pedido,\na quantidade e calcule o valor a ser pago por aquele lanche.\n\nConsidere que a cada execução somente será calculado um item.\n---------------------------------");

                    double result = 0;
            
                    Console.Write("Digite o código do item desejado: ");
                    string item = Console.ReadLine();

                    Console.Write("Digite a quantidade desejada: ");
                    double qnt = Convert.ToDouble(Console.ReadLine());

                    double c100 = 4.50;
                    double c101 = 4.50;
                    double c102 = 5.50;
                    double c103 = 6.50;
                    double c104 = 3.50;

                    if(qnt < 1) {Console.WriteLine("Quantidade inválida");}

                    switch (item){
                        case "100":
                            result = c100 * qnt;
                            Console.WriteLine("\nVocê escolheu {0} Cachorro quente - R$4,50.", qnt);
                            Console.WriteLine("O valor a ser pago é de R${0}", result);
                        break;
                
                        case "101":
                            result = c101 * qnt;
                            Console.WriteLine("\nVocê escolheu {0} Bauru Simples - R$4,50.", qnt);
                            Console.WriteLine("O valor a ser pago é de R${0}", result);
                        break;
                
                        case "102":
                            result = c102 * qnt;
                            Console.WriteLine("\nVocê escolheu {0} Bauru com Ovo - R$5,50.", qnt);
                            Console.WriteLine("O valor a ser pago é de R${0}", result);
                        break;
                
                        case "103":
                            result = c103 * qnt;
                            Console.WriteLine("\nVocê escolheu {0} Hambúrguer - R$6,50.", qnt);
                            Console.WriteLine("O valor a ser pago é de R${0}", result);
                        break;
                
                        case "104":
                            result = c104 * qnt;
                            Console.WriteLine("\nVocê escolheu {0} Refrigerante - R$3,50.", qnt);
                            Console.WriteLine("O valor a ser pago é de R${0}", result);
                        break;

                        default:
                            Console.WriteLine("\nCódigo inválido");
                        break;
                
                    }
                }

                break;

                case "46":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n46 - Um professor deseja um algoritmo pelo qual possa escolher que tipo de média deseja calcular a partir de três notas.\nFaça um algoritmo que leia as notas, a opção escolhida pelo usuário e calcule a média:\n1- aritmética;\n2- ponderada (pesos 3, 3, 4).\n---------------------------------");

                    Console.WriteLine("Tipos de média: (1) Média Aritmética, (2) Média Ponderada.");  
                    Console.Write("Escolha o tipo de média: ");
                    string type = Console.ReadLine();

                    Console.Write("Digite o nome do Aluno: ");
                    string aluno = Console.ReadLine();

                    Console.Write("Digite a primeira nota: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a segunda nota: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a terceira nota: ");
                    double nota3 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch(type){

                        case "1":
                            result = (nota1 + nota2 + nota3) / 3;
                            Console.WriteLine("A média Aritmética do aluno(a) {0} é: {1}", aluno, result);
                        break;

                        case "2":
                            result = ((nota1 * 3) + (nota2 * 3) + (nota3 * 4)) / 10;
                            Console.WriteLine("A média Ponderada do aluno(a) {0} é: {1}.", aluno, result);
                        break;

                        default:
                            Console.WriteLine("tipo inválido");
                        break;

                    }
                }

                break;

                case "47":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n47 - Criar um algoritmo para imprimir a soma de todos os números de 0 à 100.\n---------------------------------");

                    int n = 0;
                    int soma = 0;

                    while(n <= 100){

                        soma += n;

                        Console.Write("| {0} |", soma);
                        n++;
                    }       
                }

                break;

                case "48":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n48 - Criar um algoritmo que receba um número obrigatoriamente maior que zero\ne imprima todos os números de zero até o número digitado.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    int nplus = 0;

                    if(num <= 0){Console.WriteLine("Valor inválido");}

                    else{
                        while(nplus <= num) {
                            Console.WriteLine(nplus);
                            nplus++;
                        }
                    }
                }

                break;

                case "49":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n49 - Criar um algoritmo que receba dois números e imprima os números compreendidos entre estes números.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    while (num1 > num2){

                        num2++;     
                        if(num2 < num1){Console.WriteLine(num2);}
                    }

                    while (num2 > num1){

                        num1++;
                        if(num1 < num2){Console.WriteLine(num1);}
                    }
                }

                break;

                case "50":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n50 - Criar um algoritmo que receba dois números e imprima a soma dos valores compreendidos entre estes números.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int num1 = int.Parse(Console.ReadLine());
            
                    Console.Write("Digite um número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int soma = 0;

                    if(num1 < num2){ 
                
                        while (num1 <= num2){

                        soma += num1;

                        Console.WriteLine(soma);
                        num1++;
                        }
                    }

                    else { 
                
                        while (num2 <= num1){

                        soma += num2;

                        Console.WriteLine(soma);
                        num2++;
                        }
                    }
                }

                break;

                case "51":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n51 - Criar um algoritmo que receba dois números e imprima a soma dos valores pares compreendidos entre estes números.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    int n2 = int.Parse(Console.ReadLine());

                    int soma = 0;

                    while (n1 < n2) {

                        n1++;

                        if(n1 % 2 == 0){

                            soma += n1;

                            Console.Write("Par + {0} | ", n1);
                            Console.WriteLine("Soma: {0}", soma);
                        }

                        else{Console.WriteLine("Ímpar {0}", n1);}
                    }

                    while(n2 < n1){

                        n2++;

                        if(n2 % 2 == 0){

                            soma += n2;

                            Console.Write("Par + {0} |", n2);
                            Console.WriteLine("Soma: {0}", soma);
                        }
                        else{Console.WriteLine("Ímpar {0}",n2);}
                    }
                }

                break;

                case "52":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n52 - Elabore um programa que faça leitura de vários números inteiros, até que se digite um número negativo.\nO programa tem que retornar o maior e o menor número lido.\n---------------------------------");

                    int maior = 0, menor = int.MaxValue, num = 0;

                    while(num >= 0){

                    Console.Write("Digite um número: ");
                    num = int.Parse(Console.ReadLine());

                        // Console.WriteLine("{0} |", num);
                        if(num < menor){

                            if(num >= 0)
                            {menor = num;}
                        }

                        if(num > maior){
                            maior = num;
                        }
                    }

                    Console.WriteLine("O maior número é: {0}", maior);
                    Console.WriteLine("O menor número é: {0}", menor);
                }

                break;

                case "53":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n53 - Criar um algoritmo que entre com cinco números e imprima o quadrado de cada número.\nAtenção:\n - Utilizar obrigatoriamente uma estrutura de repetição.\n - Não utilizar cinco variáveis.\n---------------------------------");

                    int num = 0;

                    int va = 0;

                    while (va < 5)
                    {
                        Console.Write("Digite um número: ");
                        num = int.Parse(Console.ReadLine());

                        double num1 = Math.Pow(num, 2);

                        Console.WriteLine("O quadrado de {0} é {1}", num, num1);
                        va++;
                    }
                }

                break;

                case "54":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n54 - Faça um programa que calcule e mostre a soma dos 50 primeiros números pares positivos.\n---------------------------------");

                    int nump = 1;
                    int soma = 0;

                    while (nump <= 100)
                    {
                        nump++;

                        if(nump % 2 == 0)
                        {
                            //Console.WriteLine("{0}", nump);
                            soma += nump;
                            Console.Write("{0} | ", soma);
                        }
                    }
                }

                break;

                case "55":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n55 - Faça um programa que receba vários números, calcule e mostre:\n - A soma dos números digitados.\n - A quantidade de números digitados.\n - A média dos números digitados.\n - O maior número digitado.\n - O menor número digitado.\n - A média dos números pares.\n - Finalize a entrada de dados caso o usuário informe o valor 0.\n---------------------------------");

                    int num = 1, maior = 0, vap = 0, menor = int.MaxValue, va = 0, soma = 0, somap = 0, media = 0, mediap = 0, cont = 1;

                    while(num != 0){

                        Console.Write("Digite o {0}º número: ", cont);
                        num = int.Parse(Console.ReadLine());
                
                        soma += num;

                        if(num != 0){             
                            va++; cont++;
                        }

                        if(num % 2 == 0){
                            vap++;
                        }

                        if(num < menor){

                            if(num != 0)
                            {
                                menor = num;
                            }
                        }

                        if(num > maior){
                        maior = num;
                        }

                        if(num % 2 == 0){

                            somap += num;

                            mediap = somap / vap;
                        }
                        media = soma / va;
                    }
            
                Console.WriteLine("Números digitados: {0}", va);
            Console.WriteLine("Soma dos números: {0}", soma);
            Console.WriteLine("Média dos números: {0}", media);
            Console.WriteLine("Média dos números pares: {0}", mediap);
            Console.WriteLine("Maior número: {0}", maior);
            Console.WriteLine("Menor número: {0}", menor);
                }

                break;

                case "56":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n56 - Faça um programa que some todos os números abaixo de 1000 que são múltiplos de 3 e de 5.\n---------------------------------");

                    int num = 1000, soma = 0;
            
                    while(num >= 1){

                        if(num % 3 == 0 && num % 5 == 0 && num > 0){

                            soma += num;
                            Console.Write(" {0} |", num);

                        }
                        num--;
                    }
                }

                break;

                case "57":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n57 - Imprimir todos os números pares , múltiplos de 5 e 7 de 1 até 100.\nImprimir também a soma destes números.\n---------------------------------");

                    int num = 1, soma = 0;

                    while(num <= 100){

                        if(num % 2 == 0 || num % 5 == 0 || num % 7 == 0){

                        soma += num;
                        Console.Write(" {0} |", num);
                        }   
                        num++;
                    }

                    Console.WriteLine(" Soma: {0}.", soma);
                }

                break;

                case "58":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n58 - Imprimir em ordem decrescente todos os números múltiplos de 3 e de 5 compreendidos entre 30 e 300.\n---------------------------------");

                    int num = 300;

                    while(num >= 30){

                        if(num % 3 == 0 || num % 5 == 0){

                            Console.Write(" {0} |", num);
                        }   
                        num--;
                    }
                }

                break;

                case "59":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n59 - Ler dois números e imprimir todos os números pares e múltiplos de 7 compreendidos\nentre os números digitados pelo usuário.\nAtenção:\no usuário pode digitar o primeiro número menor que o segundo e vice-versa.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite outro: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    while (num1 < num2)
                    {
                        if (num1 % 2 == 0 || num1 % 7 == 0)
                        {
                            Console.Write(" {0} |", num1);
                        }
                        num1++;    
                    }

                    while (num2 < num1)
                    {
                        if (num2 % 2 == 0 || num2 % 7 == 0)
                        {
                            Console.Write(" {0} |", num2);
                        }
                        num2++;
                    }
                }

                break;

                case "60":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n60 - Criar um algoritmo que imprima a soma dos números ímpares de 1 a 200.\n---------------------------------");

                    int num = 1;

                    while (num < 200)
                    {
                        if (num % 2 != 0)
                        {
                            Console.Write(" {0} |", num);
                        }
                        num++;
                    }
                }

                break;

                case "61":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n61 - Imprimir todos os números ímpares de 1000 até 150 em ordem decrescente.\n---------------------------------");

                    int num = 150;

                    while (num < 1000)
                    {
                        if (num % 2 != 0)
                        {
                            Console.Write(" {0} |", num);
                        }
                        num++;
                    }
                }

                break;

                case "62":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n62 - Criar um algoritmo que imprima uma tabela de conversão de polegadas para centímetros.\nDeseja-se que na tabela conste valores de 1 polegada até 20 polegadas inteiras.\nCada polegada possui 25,4 mm.\n---------------------------------");

                    int count = 1;

                    double inch = 2.54;

                    while(count <= 20){

                        Console.WriteLine("{0}\" = {1}Cm", count, Math.Round(inch, 2, MidpointRounding.AwayFromZero));
                        inch += 2.54;
                        count++;
                    }
                }

                break;

                case "63":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n63 - Criar um algoritmo que leia um número que será o limite superior de um intervalo e o incremento.\nImprimir todos os números no intervalo de 0 até esse número.\nSuponha que os dois números lidos são obrigatoriamente maiores que zero.\nExemplo:\n - Limite superior: 20.\n - Incremento: 5.\n - Saída: 0, 5, 10, 15, 20.\n---------------------------------");
                    
                    int num = 0;

                    Console.Write("Digite o valor do limite superior: ");
                    int lim = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do Incremento: ");
                    int i = int.Parse(Console.ReadLine());

                    while(num <= lim)
                    {
                        Console.Write("| {0} |", num);
                        num += i;
                    }
                }

                break;

                case "64":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n64 - Crie um algoritmo que, dado dois números informados pelo usuário\n(obrigatoriamente maior que zero e menor ou igual a cem), informe qual é o menor deles.\n---------------------------------");

                    int menor = int.MaxValue;

                    Console.Write("Digite o primeiro número: ");
                    int n1 = int.Parse(Console.ReadLine());

                    while(n1 < 1 || n1 > 100)
                    {
                        Console.Write("Digite o primeiro número: ");
                        n1 = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Digite o segundo número: ");
                    int n2 = int.Parse(Console.ReadLine());

                    while(n2 < 1 || n2 > 100)
                    {
                        Console.Write("Digite o segundo número: ");
                        n2 = int.Parse(Console.ReadLine());
                    }

                    if(n1 < menor)
                    {
                        menor = n1;
                    }

                    if(n2 < menor)
                    {
                        menor = n2;
                    }

                    Console.WriteLine("Menor número: {0}", menor);
                }

                break;

                case "65":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n65 - Crie um algoritmo que, dado o nível de alerta de risco, imprima se ele for GRAVE.\nO nível de alerta é um número que varia de 0 a 10.\nO nível é considerado GRAVE quando ele é superior a 9.\n---------------------------------");

                    Console.Write("Digite o nível de alerta de 0 a 10: ");
                    int level = Convert.ToInt32(Console.ReadLine());

                    if (level < 0 || level > 10)
                    {
                        Console.WriteLine("Valor inválido");
                    }

                    else
                    {
                        while (level >= 0)
                        {
                            if (level >= 9)
                            {
                                Console.WriteLine("Nível: GRAVE");
                                break;
                            }

                            if(level == 8)
                            {
                                Console.WriteLine("Nível: ALTO");
                                break;
                            }

                            if (level >= 5)
                            {
                                Console.WriteLine("Nível: NORMAL");
                                break;
                            }

                            if (level < 5)
                            {
                                Console.WriteLine("Nível: BAIXO");
                                break;
                            }
                        }
                    }
                }

                break;

                case "66":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n66 - Faça um algoritmo que leia dois valores inteiros A e B e maiores que zero.\nSe os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.\nAo final de qualquer um dos cálculos deve-se atribuir o resultado\npara uma variável C e mostrar seu conteúdo na tela.\n---------------------------------");

                    
                    Console.Write("Digite o primerio número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    if(num1 <= 0 || num2 <= 0){
                        Console.WriteLine("ERRO 01 - Valores inválidos, digite um número maior que Zero.");
                    }

                    else if(num1 == num2) {
                        int nsum = num1 + num2;

                        Console.WriteLine("{0} + {1} = {2}", num1, num2, nsum);
                    }

                    else {
                        int nmult = num1 * num2;

                        Console.WriteLine("{0} * {1} = {2}", num1, num2, nmult);
                    }
                }

                break;

                case "67":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n67 - Faça um algoritmo que leia uma variável e some 5 ao número caso ele seja par ou some 8 caso seja ímpar.\nDeve-se imprimir o resultado desta operação.\n---------------------------------");

                    Console.Write("Digite um número: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    int count = 1, even = 5, odd = 8;

                    while (count <= 1) {
                
                        count++;

                        if(number % 2 == 0) {
                            int result = number + even;
                            Console.WriteLine("Resultado: {0}", result);
                        }

                        else {
                            int result = number + odd;
                            Console.WriteLine("Resultado: {0}", result);
                        }
                    }
                }

                break;

                case "68":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n68 - Tendo como dados de entrada a altura e o sexo de uma pessoa,\nconstrua um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:\n - para homens: (72.7 * h) – 58;\n - para mulheres: (62.1 * h) – 44.7.\n---------------------------------");

                    double ideal = 0;

                    Console.WriteLine("Calculo de peso ideal.");

                    Console.Write("Digite sua altura em metros 'Exemplo: 1,42': ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite 'm' se você for do sexo Masculino, Digite 'f' se você for do sexo Feminino.");
                    string gen = Console.ReadLine();

                    switch(gen){

                        case "m":
                            ideal = (72.7 * height) - 58;
                            Console.WriteLine("seu peso ideal é: {0}Kg", Math.Round(ideal, 2, MidpointRounding.AwayFromZero));
                        break;

                        case "f":
                            ideal = (62.1 * height) - 44.7 ;
                            Console.WriteLine("Seu peso ideal é: {0}Kg", Math.Round(ideal, 2, MidpointRounding.AwayFromZero));
                        break;

                        default:
                            Console.WriteLine("Valor digitado inválido");
                        break;
                    }
                }

                break;

                case "69":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n69 - Faça um algoritmo que percorra todos os números de 1 até 100.\nPara os números ímpares, deve ser impresso um '*',\ne para os números pares, deve ser impresso dois '**'.\n---------------------------------");

                    int number = 1;

                    while(number <= 100){

                        if(number % 2 == 0){

                            Console.Write(" **{0} |", number);
                        }

                        if(number % 2 != 0){

                            Console.Write(" *{0} |", number);
                        }

                        number++;
                    }
                }

                break;

                case "70":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n70 - Faça um algoritmo que percorra todos os números de 1 até 100.\nPara os números múltiplos de 4, imprima a palavra 'PI' e para os outros imprima o próprio número.\n---------------------------------");

                    int number = 1;

                    while(number <= 100){

                        if(number % 4 == 0){
                            Console.Write(" PI {0} |", number);
                        }

                        else {
                            Console.Write(" {0} |", number);
                        }
                        number++;
                    }
                }

                break;

                case "71":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n71 - Entrar com 10 números e imprimir a metade de cada número.\n---------------------------------");

                    int count = 1;
                    double num = 0, result = 0;

                    while(count <= 10){

                        Console.Write("Digite o {0}º número: ", count);
                        num = Convert.ToDouble(Console.ReadLine());

                        result = num / 2;

                        Console.WriteLine("A metade de {0} é {1}.", num, result);

                        count++;
                    }
                }

                break;

                case "72":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n72 - Utilizando a estrutura for crie um algoritmo que entre com cinco\nnúmeros e imprimir o quadrado de cada número.\n---------------------------------");

                    double num = 0, result = 0;
                    int scnd_count = 1;

                    for (int count = 1; count <= 5; count++, scnd_count++)
                    {
                        Console.Write("\nInforme o {0}° número: ", scnd_count);
                        num = Convert.ToDouble(Console.ReadLine());

                        result = Math.Pow(num, 2);

                        Console.WriteLine("O quadrado de {0} é {1}", num, result);
                    }
                }

                break;

                case "73":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n73 - Utilizando a estrutura for crie um algoritmo que imprima todos os números pares no intervalo 1-10.\n---------------------------------");

                    for (int num = 1; num <= 10; num++)
                    {
                        if(num % 2 == 0)
                        {
                            Console.Write("| {0} |", num);
                        }
                    }
                }

                break;

                case "74":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n74 - Utilizando a estrutura for imprima todos os números de 1 até 100.\n---------------------------------");

                    for(int num = 1; num <= 100; num++)
                    {
                        Console.Write("| {0} |", num);
                    }
                }

                break;

                case "75":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n75 - Utilizando a estrutura for imprima todos os números de 100 até 1.\n---------------------------------");

                    for(int num = 100; num >= 1; num--)
                    {
                        Console.Write("| {0} |", num);
                    }
                }

                break;

                case "76":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n76 - Utilizando a estrutura for imprima os múltiplos de 5, no intervalo de 1 até 500.\n---------------------------------");

                    for(int num = 1; num <= 500; num++)
                    {
                        if(num % 5 == 0)
                        {
                            Console.Write("| {0} |", num);
                        }
                    }
                }

                break;

                case "77":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n77 - Utilizando a estrutura for imprima o quadrado dos números de 1 ate 20.\n---------------------------------");

                    double quad = 0;

                    for(int num = 1; num <= 20; num++)
                    {
                        quad = Math.Pow(num, 2);
                        Console.Write("| {0} |", quad);
                    }
                }

                break;

                case "78":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n78 - Utilizando a estrutura for crie um algoritmo que imprima os números pares no intervalo de 1 a 600.\n---------------------------------");

                    for (int num = 1; num <= 600; num++)
                    {
                        if (num % 2 == 0)
                        {
                            Console.Write("| {0} |", num);
                        }
                    }
                }

                break;

                case "79":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n79 - Utilizando a estrutura for crie um algoritmo que imprima os números de 120 a 300.\n---------------------------------");

                    for(int num = 120; num <= 300; num++)
                    {
                        Console.Write("| {0} |", num);
                    }
                }

                break;

                case "80":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n80 - Utilizando a estrutura for crie um algoritmo que imprima todos os números de 1 ate 100 e a soma deles.\n---------------------------------");

                    int sum = 0;
                    for(int num = 1; num <= 100; num++)
                    {
                        Console.Write("| {0} |", num);
                        sum += num;
                    }

                    Console.WriteLine("\n Soma = {0}", sum);
                }

                break;

                case "81":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n81 - Utilizando a estrutura for entre com 10 números e imprimir a metade de cada número.\n---------------------------------");

                    int count = 1;
                    double half = 0;

                    for (double num = 1; count <= 10; num++, count++)
                    {
                        Console.Write("Informe o {0}° número: ", count);
                        num = double.Parse(Console.ReadLine());

                        half = num / 2;

                        Console.WriteLine("| {0} |", half);
                    }
                }

                break;

                case "82":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n82 - Utilizando a estrutura for entre com quatro números e imprimir o cubo e a raiz cúbica de cada número.\n---------------------------------");

                    double rcub = 0, num = 0, cub = 0;

                    for(int count = 1; count <= 4; count++)
                    {
                        Console.Write("\nDigite o {0}° número: ", count);
                        num = Convert.ToDouble(Console.ReadLine());

                        cub = Math.Pow(num, 3);

                        Console.Write("Cubo: | {0} |\n", cub);

                        rcub = Math.Pow(num, 1 / 3.0);

                        Console.Write("Raiz Cúbica | {0} |\n", rcub);
                    }
                }

                break;

                case "83":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n83 - Utilizando a estrutura for crie um algoritmo que imprima uma tabela de conversão de polegadas para centímetros.\nDeseja-se que na tabela conste valores desde 1 polegada até 20 polegadas inteiras.\nCada polegada vale 2,54cm.\n---------------------------------");

                    double inch = 2.54;

                    for(int i = 1; i <= 20; i++)
                    {
                        Console.WriteLine("{0}\" = {1}cm", i, Math.Round(inch, 2, MidpointRounding.AwayFromZero));
                        inch += 2.54;
                    }
                }

                break;

                case "84":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n84 - Utilizando a estrutura for crie um algoritmo que leia um número que será o limite superior\nde um intervalo e imprimir todos os números ímpares menores do que esse número.\n\nExemplo:\nLimite superior: 15.\nSaída: 1 3 5 7 9 11 13.\n---------------------------------");

                    Console.Write("Digite um valor para o limite superior: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for(int i = 1; i < num; i++)
                    {
                        if(i % 2 != 0)
                        {
                            Console.Write("| {0} |", i);
                        }
                    }
                }

                break;

                case "85":

                for (int x = 0; x < 1; x++)
                { 
                    Console.WriteLine("\n85 - Utilizando a estrutura for crie um algoritmo que leia um número que servirá para controlar\nos números pares que serão impressos a partir de 2.\n\nExemplo:\nQuantos: 4.\nSaída: 2 4 6 8.\n---------------------------------");

                    int control_c = 0;

                    Console.Write("Digite quantos números pares você deseja que apareça: ");
                    int control = int.Parse(Console.ReadLine());

                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("{0} ", i);

                            control_c++;

                            if(control_c == control)
                            {
                                i = int.MaxValue - 1;
                            }
                        }
                    }

                    Console.WriteLine("");
                }

                break;

                case "86":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n86 - Utilizando a estrutura for crie um algoritmo que leia um número e imprima\ntodos os números de 1 até o número lido e o seu produto.\n\nExemplo:\nnúmero: 3.\nSaída: 1 2 3.\n6 (produto).\n---------------------------------");

                    int sum = 0;

                    Console.Write("Digite um número: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write("| {0} |", i);
                        sum += i;
                    }
                    Console.WriteLine("\nProduto: {0}", sum);
                }

                break;

                case "87":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n87 - Utilizando a estrutura for crie um algoritmo que imprima a soma dos números pares entre 25 e 200.\n---------------------------------");

                    int sum = 0;
            
                    for(int num = 25; num <= 200; num++)
                    {
                        if (num % 2 == 0)
                        {
                            sum += num;
                        }
                    }

                    Console.WriteLine("Soma = {0}", sum);
                }

                break;

                case "88":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n88 - Escreva uma aplicação no qual o usuário deverá informar 10 números inteiro e maiores que Zero em um vetor.\nPosteriormente exiba separadamente os números pares e os números ímpares exibidos pelo usuário.\n---------------------------------");

                    int[] num = new int[10];

                    for (int i = 0, num_count = 1; i < num.Length; i++, num_count++)
                    {
                        Console.Write("Digite o {0}° número: ", num_count);
                        num[i] = int.Parse(Console.ReadLine());

                        while(num[i] <= 0)
                        {
                            Console.WriteLine("Digite um número positivo maior que Zero!!");

                            Console.Write("Digite o {0}° número: ", num_count);
                            num[i] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.Write("\nNúmeros Pares: ");
                    for (int i = 0; i < num.Length; i++)
                    {
                        if(num[i] % 2 == 0)
                        {
                            Console.Write("| {0} |", num[i]);
                        }
                    }

                    Console.Write("\nNúmeros Ímpares: ");
                    for (int i = 0; i < num.Length; i++)
                    {
                        if(num[i] % 2 != 0)
                        {
                            Console.Write("| {0} |", num[i]);
                        }
                    }

                    Console.Write("\n");
                }

                break;

                case "89":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n89 - Dada uma sequência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.\n---------------------------------");

                    int[] num = new int[5];

                    for(int i = num.Length - 1, c = 1; i >= 0; i--,c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());
                    }

                    for(int i = 0; i < num.Length; i++)
                    {
                        Console.Write("| {0} |", num[i]);
                    }

                    Console.Write("\n");
                }

                break;

                case "90":

                for (int z = 0; z < 1; z++)
                {
                    Console.WriteLine("\n90 - Considere um vetor de 10 números inteiros positivos maiores que zero e um único\nnúmero inteiro, também positivo e maior que zero. Faça um programa para:\n - ler pelo teclado o vetor;\n - ler pelo teclado o número X;\n - dizer quantos números no vetor são maiores que X , menores que X e iguais a X.\n\n---------------------------------");

                    int[] num = new int[10];

                    int c = 1, x = 0;

                    for (int i = 0; i < num.Length; i++, c++)
                    {
                        if (i == 0)
                        {
                            Console.Write("Digite o número X: ");
                            x = Convert.ToInt32(Console.ReadLine());

                            while(x <= 0)
                            {
                                Console.WriteLine("Digite um número positivo maior do que zero!!");

                                Console.Write("Digite o número X: ");
                                x = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                        Console.Write("Digite o {0}° número: ", c);
                        num[i] = Convert.ToInt32(Console.ReadLine());

                        while (num[i] <= 0)
                        {
                            Console.WriteLine("Digite um número positivo maior do que zero!!");

                            Console.Write("Digite o {0}° número: ", c);
                            num[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nMaiores que X: ");
                    for (int i = 0; i < num.Length; i++)
                    {
                        if(num[i] > x)
                        {
                            Console.Write("| {0} |", num[i]);
                        }
                    }

                    Console.Write("\nMenores que X: ");
                    for (int i = 0; i < num.Length; i++)
                    {
                        if(num[i] < x)
                        {
                            Console.Write("| {0} |", num[i]);
                        }
                    }

                    Console.Write("\nIguais a X: ");
                    for (int i = 0; i < num.Length; i++)
                    {
                        if(num[i] == x)
                        {
                            Console.Write("| {0} |", num[i]);
                        }
                    }

                    Console.Write("\n\n");
                }

                break;

                case "91":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n91 - Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que\ntenha idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza.\nForam inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade.\nTais informações foram armazenadas em 2 vetores distintos.\nFaça um programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária.\n---------------------------------");

                    Console.Write("Digite a quantidade de participantes: ");
                    int size = int.Parse(Console.ReadLine());

                    string[] names = new string[size];

                    int[] ages = new int[size];

                    for(int i = 0, c = 1; i < size; i++, c++)
                    {
                        Console.Write("\nDigite o nome da {0}ª modelo: ", c);
                        names[i] = Console.ReadLine();

                        Console.Write("\nDigite a idade da {0}ª modelo: ", c);
                        ages[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("\nModelos Aptas: ");

                    for(int i = 0; i < size; i++)
                    {
                        if (ages[i] >= 18 && ages[i] <= 20)
                        {
                            Console.WriteLine("{0} - {1} Anos.", names[i], ages[i]);
                        }
                    }
                }

                break;

                case "92":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n92 - Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50).\nDetermine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições.\n---------------------------------");

                    int[] v1 = new int[10] {5,6,2,8,33,66,12,10,14,2};

                    int[] v2 = new int[10] {2,6,9,8,32,66,12,21,14,1};

                    Console.WriteLine("V1 = {0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}",v1[0],v1[1],v1[2],v1[3],v1[4],v1[5],v1[6],v1[7],v1[8],v1[9]);
                    Console.WriteLine("V2 = {0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}",v2[0],v2[1],v2[2],v2[3],v2[4],v2[5],v2[6],v2[7],v2[8],v2[9]);


                    for(int i = 0; i < v1.Length; i++)
                    {
                        if(v1[i] == v2[i])
                        {
                            Console.Write("| {0} |", v2[i]);
                        }
                    }
                }

                break;

                case "93":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n93 - Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N\nalunos e calcular a média aritmética das notas. Contar quantos alunos estão com a nota acima de 7,0.\nObs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem:\nNão há nenhum aluno com nota acima de 5.\n---------------------------------");

                    int[] student = new int[10];

                    int c = 1, qntd_n7 = 0, qntd_n5 = 0;
                    double sum = 0, average = 0;

                    for(int i = 0; i < student.Length; i++, c++)
                    {
                        Console.Write("Digite a nota do {0}° Aluno: ", c);
                        student[i] = Convert.ToInt32(Console.ReadLine());

                        while(student[i] < 0 || student[i] > 10)
                        {
                            Console.WriteLine("Digite uma nota de 0 a 10 !!");

                            Console.Write("Digite a nota do {0}° Aluno: ", c);
                            student[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        if(student[i] > 7)
                        {
                            qntd_n7++;
                        }

                        if(student[i] <= 5)
                        {
                            qntd_n5++;
                        }
                    }

                    for (int i = 0; i < student.Length; i++)
                    {
                        sum += student[i];
                        average = sum / student.Length;
                    }

                    Console.WriteLine("\nMédia das Notas: {0} ", Math.Round(average, 1));

                    if (qntd_n5 == student.Length)
                    {
                        Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de Alunos com nota acima de 7: {0}", qntd_n7);
                    }
                }

                break;

                case "94":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n94 - Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4.\nO vetor terá no máximo 100 posições.\nSair do programa quando for digitado -1.\n---------------------------------");

                    int[] num = new int[100];

                    int c = 1, n1 = 0, n3 = 0, n4 = 0;

                    for(int i = 0; i < num.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());

                        if(num[i] < 0)
                        {
                            i = num.Length;
                        }
                    }

                    for(int i = 0; i < num.Length; i++)
                    {
                        if(num[i] == 1)
                        {
                            n1++;
                        }

                        if(num[i] == 3)
                        {
                            n3++;
                        }

                        if(num[i] == 4)
                        {
                            n4++;
                        }
                    }

                    Console.Write("Números '1' Digitados: {0}\nNúmeros '3' Digitados: {1}\nNúmeros 4 Digitados: {2}", n1, n3, n4);

                    Console.Write("\n");
                }

                break;

                case "95":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n95 - Durante uma corrida de automóveis com N voltas de duração foram anotados para um\n piloto, na ordem, os tempos registrados (em segundos) em cada volta.\nFazer um programa para ler os tempos das N voltas, calcular e imprimir:\n - melhor tempo;\n - a volta em que o melhor tempo ocorreu;\n - tempo médio das N voltas.\n---------------------------------");

            double[] lap = new double[5];

            double c = 1, fastest = int.MaxValue, best = 0, sum = 0, average = 0;

            for (int i = 0; i < lap.Length; i++, c++)
            {
                Console.Write("Tempo da {0}ª volta: ", c);
                lap[i] = Convert.ToDouble(Console.ReadLine());
            }

                    for (int i = 0; i < lap.Length; i++)
                    {
                        if(lap[i] < fastest)
                        {
                            fastest = lap[i];
                            best = i + 1;
                        }

                        sum += lap[i];
                        average = sum / lap.Length;
                    }

                    Console.WriteLine("Melhor Tempo: {0}s", fastest);
                    Console.WriteLine("Melhor volta: {0}ª Volta", best);
                    Console.WriteLine("Média das voltas: {0}", average);
                }

                break;

                case "96":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n96 - Fazer um programa para ler um vetor de inteiros positivos de 50 posições.\nImprimir a quantidade de números pares e de múltiplos de 5.\n---------------------------------");

                    int[] num = new int[50];

                    int c = 1, even = 0, mult5 = 0;

                    for(int i = 0; i < num.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());
                    }

                    for(int i = 0; i < num.Length; i++)
                    {
                        if(num[i] % 2 == 0)
                        {
                            even++;
                        }

                        if(num[i] % 5 == 0)
                        {
                            mult5++;
                        }
                    }

                    Console.Write("Pares = {0}\nMúltiplos de 5 = {1}", even, mult5);
                    Console.Write("\n");
                }

                break;

                case "97":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n97 - Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média.\nImprimir também o maior. A quantidade de números lidos será definida pelo usuário.\n---------------------------------");

                    int size = 0;

                    Console.Write("Digite o tamanho do Array: ");
                    size = int.Parse(Console.ReadLine());

                    while(size < 1)
                    {
                        Console.WriteLine("Digite um tamanho maior que 0 !");

                        Console.Write("Digite o tamanho do Array: ");
                        size = int.Parse(Console.ReadLine());
                    }

                    int[] num = new int[size];

                    double c = 1, biggest = int.MinValue, sum = 0, average = 0;

                    for(int i = 0; i < num.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());

                        if (num[i] > biggest)
                        {
                            biggest = num[i];
                        }

                        sum += num[i];
                        average = sum / num.Length;
                    }

                    Console.Write("Maior número = {0}\nMédia = {1}", biggest, average);
                    Console.Write("\n");
                }

                break;

                case "98":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n98 - Escreva um algoritmo que solicite ao usuário a entrada de 5 números, e que exiba o somatório desses números na tela.\nApós exibir a soma, o programa deve mostrar também os números que o usuário digitou, um por linha.\n---------------------------------");

                    int[] num = new int[5];

                    int c = 1;
                    double sum = 0;

                    for(int i = 0; i < num.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());

                        sum += num[i];

                        Console.WriteLine("\nSoma = {0}", sum);
                    }

                    for (int i = 0, c2 = 1; i < num.Length; i++, c2++)
                    {
                        Console.WriteLine("{0}º Número digitado = {1}", c2, num[i]);
                    }
                        Console.Write("\n");
                }

                break;

                case "99":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n99 - Escreva um algoritmo que solicite ao usuário a entrada de 5 nomes, e que exiba a lista desses nomes na tela.\nApós exibir essa lista, o programa deve mostrar também os nomes na ordem inversa em que o usuário os digitou, um por linha.\n---------------------------------");

                    string[] nome = new string[5];

                    for(int i = 0, c = 1; i < nome.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º nome: ", c);
                        nome[i] = Console.ReadLine().ToLower();
                    }

                    Console.WriteLine("Nomes: ");
                    for (int i = 0, c = 1; i < nome.Length; i++,c++)
                    {
                        Console.WriteLine("{0}º {1}", c, nome[i]);
                    }

                    Console.Write("\n");
                    Console.WriteLine("Nomes Invertidos: ");
                    for (int i = nome.Length - 1, c = nome.Length; i >= 0; i--, c--)
                    {
                        Console.WriteLine("{0}º {1}", c, nome[i]);
                    }
                }

                break;

                case "100":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n100 - Crie um programa que solicite a entrada de 10 números pelo usuário,\narmazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5.\n---------------------------------");

                    int[] num = new int[10];

                    for (int i = 0, c = 1; i < num.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        num[i] = int.Parse(Console.ReadLine());
                    }

                    int[] num_mult5 = new int[10];

                    for (int i = 0, c2 = 1; i < num_mult5.Length; i++, c2++)
                    {
                        num_mult5[i] = num[i] * 5;
                        Console.WriteLine("{0} | {1}", num[i], num_mult5[i]);
                    }
                }

                break;

                case "101":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n101 - Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:\num somente para números pares, e outro somente para números ímpares.\nApós, exiba os valores dos dois vetores na tela, em sequência.\nObs.: As posições que não receberem valores exibirão o número zero.\n---------------------------------");

                    int[] num_even = new int[10];

                    int[] num_odd = new int[10];

                    for(int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        int num = int.Parse(Console.ReadLine());

                        if(num % 2 == 0)
                        {
                            num_even[i] = num;
                        }

                        else
                        {
                            num_odd[i] = num;
                        }
                    }

                    Console.Write("\n");

                    for (int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        Console.Write("Array Par {0}º Posição - {1} |", c, num_even[i]);
                        Console.Write("Array Ímpar {0}º Posição - {1}\n", c, num_odd[i]);
                    }

                    Console.Write("\n");
                }

                break;

                case "102":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n102 - Modifique o programa anterior para não aceitar a entrada do número zero, e requisitar a digitação de outro número neste caso.\n---------------------------------");

                    int[] num_even = new int[10];

                    int[] num_odd = new int[10];

                    for (int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        int num = int.Parse(Console.ReadLine());

                        while(num == 0)
                        {
                            Console.WriteLine("Digite um número diferente de 0 !!");
                            Console.Write("Digite o {0}º número: ", c);
                            num = int.Parse(Console.ReadLine());
                        }

                        if (num % 2 == 0)
                        {
                            num_even[i] = num;
                        }

                        else
                        {
                            num_odd[i] = num;
                        }
                    }

                    Console.Write("\n");

                    for (int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        Console.Write("Array Par {0}º Posição - {1} |", c, num_even[i]);
                        Console.Write(" Array Ímpar {0}º Posição - {1}\n", c, num_odd[i]);
                    }

                    Console.Write("\n");
                }

                break;

                case "103":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n103 - Modifique novamente o programa anterior, de modo a não exibir na saída os números zero\nque são mostrados para todas as posições que não receberam nenhum valor durante a atribuição.\n---------------------------------");

                    int[] num_even = new int[10];

                    int[] num_odd = new int[10];

                    for (int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        Console.Write("Digite o {0}º número: ", c);
                        int num = int.Parse(Console.ReadLine());

                        while (num == 0)
                        {
                            Console.WriteLine("Digite um número maior que 0 !!");
                            Console.Write("Digite o {0}º número: ", c);
                            num = int.Parse(Console.ReadLine());
                        }

                        if (num % 2 == 0)
                        {
                            num_even[i] = num;
                        }

                        else
                        {
                            num_odd[i] = num;
                        }
                    }

                    Console.Write("\n");

                    for (int i = 0, c = 1; i < num_even.Length; i++, c++)
                    {
                        if (num_even[i] != 0)
                        {
                            Console.Write("Array Par {0}º Posição - {1} |", c, num_even[i]);
                            Console.Write(" Array Ímpar {0}º Posição -   \n", c);
                        }

                        if (num_odd[i] != 0)
                        {
                            Console.Write("Array Par {0}º Posição -   |", c);
                            Console.Write(" Array Ímpar {0}º Posição - {1}\n", c, num_odd[i]);
                        }
                    }

                    Console.Write("\n");
                }

                break;

                case "104":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n104 - Faça um programa que leia uma string e a imprima cada letra separada por um traço [-].\n---------------------------------");

                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();

                    for(int i = 0; i < nome.Length; i++)
                    {
                        Console.Write("{0}", nome[i]);

                        if(i < nome.Length - 1){

                            Console.Write("-");
                        }
                    }
                }

                break;

                case "105":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n105 - Faça um programa que receba um nome, calcule e retorne quantas letras tem esse nome.\n---------------------------------");

                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Esse nome tem {0} Caracteres.",nome.Length);
                }

                break;

                case "106":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n106 - Faça um programa que receba uma palavra e a imprima de trás-para-frente.\n---------------------------------");

                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();

                    for(int i = nome.Length - 1; i >= 0 ; i--)
                    {
                        Console.Write(" {0} ", nome[i]);
                    }

                    Console.Write("\n\n");
                }

                break;

                case "107":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n107 - Faça um programa que receba do usuário uma string.\nPosteriormente programa deve imprimir a string sem suas vogais.\n---------------------------------");

                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine().ToUpper();

                    for(int i = 0; i < nome.Length; i++)
                    {
                        if (nome[i] != 'A' && nome[i] != 'E' && nome[i] != 'I' && nome[i] != 'O' && nome[i] != 'U')
                        {
                            Console.Write("{0} ", nome[i]);
                        }
                    }
                }

                break;

                case "108":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n108 - Ler uma frase e contar quantos caracteres são espaços em brancos.\nLembre-se que uma frase é um conjunto de caracteres (vetor).\n---------------------------------");

                    int blank = 0;

                    Console.Write("Digite uma frase: ");
                    string ph = Console.ReadLine();

                    for(int i = 0; i < ph.Length; i++)
                    {
                        if(ph[i] == ' ')
                        {
                            blank++;
                        }
                    }

                    Console.WriteLine("Quantidade de espaços em branco = {0}", blank);
                }

                break;

                case "109":

                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("\n109 - Faça um programa que leia uma frase qualquer e imprima a\nfrase e a quantidade de espaços em branco esta frase possui.\n---------------------------------");

                    int blank = 0;

                    Console.Write("Digite uma frase: ");
                    string ph = Console.ReadLine();

                    for (int i = 0; i < ph.Length; i++)
                    {
                        if (ph[i] == ' ')
                        {
                            blank++;
                        }
                    }

                    Console.WriteLine("{0}\n", ph);
                    Console.WriteLine("Quantidade de espaços em branco = {0}", blank);
                }

                break;

                case "110":

                    for (int x = 0; x < 1; x++)
                    {
                        Console.WriteLine("\n110 - Fazer um programa que leia uma frase e imprima somente as vogais.\n---------------------------------");

                        Console.Write("Digite uma frase: ");
                        string ph = Console.ReadLine().ToUpper();

                        for(int i = 0; i < ph.Length; i++)
                        {
                            if (ph[i] == 'A' || ph[i] == 'E' || ph[i] == 'I' || ph[i] == 'O' || ph[i] == 'U')
                            {
                                Console.Write(" {0} ", ph[i]);
                            }
                        }

                    Console.Write("\n");
                    }

                break;
            }
        }
    }
}
