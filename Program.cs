while (true) //Irá executar as instruções abaixo enquanto for True.
{
Console.WriteLine("Digite o seu nome:"); //Solicitando ao usuário o seu nome.
string? nome = Console.ReadLine();//Criando uma variável "nome" em que recebe o valor digitado pelo usuário.

Console.WriteLine("Digite sua idade:"); //Solicitando ao usuário a sua idade.
int idade = Convert.ToInt32(Console.ReadLine()); //Criando uma variável "idade" em que recebe o valor digitado pelo usuário.

Console.WriteLine("Digite sua altura:"); //Solicitando ao usuário a sua altura.
double altura = Convert.ToDouble(Console.ReadLine()); //Criando uma variável "altura" em que recebe o valor digitado pelo usuário.

Console.WriteLine("Digite seu peso:"); //Solicitando ao usuário o seu peso.
double peso = Convert.ToDouble(Console.ReadLine()); //Criando uma variável "peso" em que recebe o valor digitado pelo usuário.

double IMC = peso / (altura * altura); //Calculando o IMC

string faixa_etaria; //Criando uma variável que recebe uma das instruções abaixo.
if (idade <= 13) //Se a idade do usuário for menor que 13, a variável "faixa_etaria" recebe o valor "Criança".
{
    faixa_etaria = "Criança";
}
else if (idade <= 18) //Se a idade do usuário for menor que 18, a variável "faixa_etaria" recebe o valor "Adolescente".
{
    faixa_etaria = "Adolescente";
}
else //Se a idade do usuário não for nenhuma das opções anteriores, a variável "faixa_etaria" recebe o valor "Adulto".
{
    faixa_etaria = "Adulto";
}

string situacao; //Criando uma variável que recebe uma das instruções abaixo.
if (IMC < 18.5) //Se o IMC do usuário resultar menor que 18.5, a variável "situacao" recebe o valor de "Abaixo do peso".
{
    situacao = "Abaixo do peso";
}
else if (IMC >= 18.5 && IMC <= 24.9)//Se o IMC do usuário resultar maior/igual a 18.5 e menor ou igual a 24.9, a variável "situacao" recebe o valor de "Abaixo do peso".
{
    situacao = "Normal";
}
else //Se o IMC do usuário não resultar em nenhuma da opções anteriores, a variável "situacao" recebe o valor de "Sobrepeso".
{
    situacao = "Sobrepeso";
}

Console.WriteLine("\nRELATÓRIO:"); //Gerando o relatório
Console.WriteLine("Nome:" + nome); //Concatenação de strings
Console.WriteLine("Idade:" + idade); //Concatenação 
Console.WriteLine($"Faixa etária: {faixa_etaria}"); //Interpolação 
Console.WriteLine($"IMC: {situacao}"); //Interpolação 

Console.WriteLine("\nGostaria de gerar um novo relatório? s/n"); //Perguntando ao usuário se gostaria de gerar um novo relatório.
String? novo = Console.ReadLine(); //Criando uma variável "novo" que recebe o valor digitado pelo usuário.
if (novo == "n") //Se o usuário digitar "n" o programa irá finalizar, caso contrário irá reiniciar.
{
    break;
}
}


