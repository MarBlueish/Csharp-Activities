// exercicio 1

int a, b, c;

Console.WriteLine("Insira dois números para verificação de pares");
Console.WriteLine("Insira o primeiro");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo");
b = int.Parse(Console.ReadLine());
c = a + b;

if (c % 2 == 0)
{
    Console.WriteLine("A soma é um número par");
}
else
{
    Console.WriteLine("A soma é um número ímpar");
}



// exercicio 2

float d, e, f;
int maxcasas = 3;

Console.WriteLine("Vamos inserir dois números para verificação de divisão");
Console.WriteLine("Insira o primeiro número");
d = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo número");                            
e = float.Parse(Console.ReadLine());
f = d / e;

string nmrdecimal = f.ToString("F" + maxcasas);
Console.WriteLine("O resultado é " +nmrdecimal);

// exercicio 3

float g, h;
float pi = 3.14f;

Console.WriteLine("Vamos começar com a verificação de número");
    
Console.WriteLine("Insira um número");
g = float.Parse(Console.ReadLine());

if (g > 10)
{
    Console.WriteLine("Erro, valor maior que o aceitável");
}
else
{
    h = (g * pi);    
    Console.WriteLine("O valor é " +h);
}

// exercicio 4

int j = 0;

for (int i = j; i < 11; i++)
{
    Console.WriteLine(i);
}

// exercicio 5

int soma = 0;

Console.WriteLine("Os primeiros 10 números naturais são:");
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");

    
    soma += i;
}

Console.WriteLine("A soma dos primeiros 10 números naturais é: " + soma);

// exercicio 6

int soma2 = 0;
int k;

Console.WriteLine("Vamos fazer a soma do número de termos");
Console.WriteLine("Indique o número de termos");
k = int.Parse(Console.ReadLine());

for (int i = 1; i <= k; i++)
{

    Console.Write(i + " ");


    
    soma2 += i;
}

Console.WriteLine("A soma dos termos é: " + soma2);

// exercicio 7

int soma3 = 0;
int media = 0;

Console.WriteLine("Os primeiros 10 números naturais são:");
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");


    soma3 += i;
    media = soma3 / i;

}



Console.WriteLine("A soma dos primeiros 10 números naturais é: " + soma3);
Console.WriteLine("A média dos 10 primeiros números é " +media);

// exercicio 8

int l;
int CONTADOR_CUBO = 0;
int resultado;

Console.WriteLine("Vamos fazer o cubo do número de termos");
Console.WriteLine("Indique o número de termos");
l = int.Parse(Console.ReadLine());

for (int i = 1; i <= l; i++) 
{

    resultado = i * i * i;
    Console.WriteLine("O resultado é " +resultado);

    
    CONTADOR_CUBO += i;
    
}

// exercicio 9

void func()
{
    int m;
    int CONTADOR_CUBO = 0;
    int resultado;

    Console.WriteLine("Vamos fazer o cubo do número de termos");
    Console.WriteLine("Indique o número de termos");
    m = int.Parse(Console.ReadLine());

    for (int i = 1; i <= l; i++) 
    {

        resultado = i * i * i;
        Console.WriteLine("O resultado é " +resultado);

    
        CONTADOR_CUBO += i;
    
    }
    
}

func();

// exercicio 11

float cotDolar = 1;
float cotReal = 0.20f;
float convValor;
float dinheiroFinal;

Console.WriteLine("Insira o valor em reais para conversão para dólar");
convValor = float.Parse(Console.ReadLine());

// sendo que o 1 dolar vale 0.20reais

dinheiroFinal = convValor * cotReal;

Console.WriteLine("O valor final é de " +dinheiroFinal);

// exercicio 12
int nrTab;
int cont;

Console.WriteLine("Vamos fazer uma tabuada");
Console.WriteLine("Escolha um número inteiro");
nrTab = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
 
     
    Console.WriteLine(nrTab + "x" + i + "=" + nrTab * i);
    

}

// exercicio 13
float peso = 0;
float altura = 0;

Console.WriteLine("Vamos calcular o seu IMC");
Console.WriteLine("Insira o seu peso, em kg, separado por virgula (ex: 78,3)");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Insira a sua altura, em metros, separado por virgula (ex: 1,78)");
altura = float.Parse(Console.ReadLine());

float IMC = peso / (altura * altura);

Console.WriteLine("O seu IMC é de " + IMC);

// exercicio 15
float resFat;
int inpFat;

Console.WriteLine("Vamos calcular o fatorial");  
Console.WriteLine("Insira o número a calcular");
inpFat = int.Parse(Console.ReadLine());

for (int i = 1; i <= l; i++) 
{

    resultado = i * i * i;
    Console.WriteLine("O resultado é " +resultado);

    
    CONTADOR_CUBO += i;
    
}









































