/*
11) Escreva um algoritmo para ler o número de eleitores de um município, 
o número de votos brancos, nulos e válidos. Calcule e escreva o percentual 
que cada um representa em relação ao total de eleitores. 
*/

Console.WriteLine("Bem-vindo(a)! Você acessou a calculadora de percentual eleitoral. \n" +
    "Com ela você poderá estimar a porcentagem de votos válidos, brancos e nulos da \n" +
    "eleição da sua cidade.");

Console.WriteLine();
Console.WriteLine("Para começarmos, informe o nome do seu Município: ");
string cidade = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Para começarmos, informe a sigla do Estado do seu Município: ");
string estado = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Informe o número total de eleitores que votaram em seu Município: ");
double eleitoresVotantes = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informe o número total de votos brancos contabilizados: ");
double votosBrancos = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informe o número total de votos nulos contabilizados: ");
double votosNulos = double.Parse(Console.ReadLine());

double votosValidos;
votosValidos = eleitoresVotantes - votosBrancos - votosNulos;

Console.WriteLine();
Console.WriteLine("As informações recebidas foram:");
Console.WriteLine();
Console.WriteLine("O Município e o Estado informados são: " + cidade + "-" + estado + ".");
Console.WriteLine();
Console.WriteLine("O número total de eleitores votantes no munícipio " + cidade + " foi de: " + eleitoresVotantes + " votos.");
Console.WriteLine("O número de votos brancos do Municipío " + cidade + " foi de: " + votosBrancos + " votos.");
Console.WriteLine("O número de votos nulos do Municipío " + cidade + " foi de: " + votosNulos + " votos.");
Console.WriteLine("O número total de votos válidos do Municipío " + cidade + " foi de: " + votosValidos + " votos.");

double porcentagemValidos, porcentagemBrancos, porcentagemNulos;

porcentagemValidos = (votosValidos / eleitoresVotantes) * 100;
porcentagemBrancos = (votosBrancos / eleitoresVotantes) * 100;
porcentagemNulos = (votosNulos / eleitoresVotantes) * 100;

Console.WriteLine();
Console.WriteLine("Resultado do percentual de votos válidos, brancos e nulos com relação \n" +
    "ao total de eleitores do Município " + cidade + "-" + estado + ":");
Console.WriteLine();
Console.WriteLine("O percentual de votos válidos do Município é de: " + porcentagemValidos.ToString("F0") + "%.");
Console.WriteLine("O percentual de votos brancos do Município é de: " + porcentagemBrancos.ToString("F0") + "%.");
Console.WriteLine("O percentual de votos nulos do Município é de: " + porcentagemNulos.ToString("F0") + "%.");

Console.WriteLine();
Console.WriteLine("Agradecemos por utilizar a nossa calculadora. Volte sempre!");

/*
Resolução do Professor Alexandre:

/// <summary>
/// armazena a quantidade de eleitores digitada pelo usuário
/// </summary>
int numeroEleitores;

/// <summary>
/// armazena a quantidade de votos em branco digitada pelo usuário
/// </summary>
int numeroVotosBrancos;

/// <summary>
/// armazena a quantidade de votos nulos digitada pelo usuário
/// </summary>
int numeroVotosNulos;

/// <summary>
/// armazena o número de votos válidos, calculados no sistema
/// </summary>
int numeroValidos;

/// <summary>
/// armazena a porcentagem de votos em branco
/// </summary>
float porcentagemVotosBrancos;

/// <summary>
/// armazena a porcentagem votos nulos
/// </summary>
float porcentagemVotosNulos;

/// <summary>
/// armazena a porcentagem votos válidos: numero de eleitores menos a
/// soma dos votos nulos e em branco
/// </summary>
float porcentagemVotosValidos;

Console.Write("Informe a quantidade de eleitores: ");
numeroEleitores = int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos brancos: ");
numeroVotosBrancos = int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos nulos: ");
numeroVotosNulos = int.Parse(Console.ReadLine());

//lembre que há abstenções... CUIDADO....
numeroValidos = numeroEleitores - (numeroVotosBrancos + numeroVotosNulos);

//numeroEleitores -> 100%
//numeroVotosBrancos -> porcentagemVotosBrancos
porcentagemVotosBrancos = numeroVotosBrancos * 100 / numeroEleitores;

//numeroEleitores -> 100%
//numeroVotosNulos -> porcentagemVotosNulos
porcentagemVotosNulos = numeroVotosNulos * 100 / numeroEleitores;

porcentagemVotosValidos = 100 - (porcentagemVotosBrancos + porcentagemVotosNulos);

Console.WriteLine("Votos nulos (%): " + porcentagemVotosNulos);
Console.WriteLine("Votos em branco (%): " + porcentagemVotosBrancos);
Console.WriteLine("Votos válidos (%): " + porcentagemVotosValidos);
*/