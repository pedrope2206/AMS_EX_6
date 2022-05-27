string nome = "";
double H = 0;
double peso = 0;

Console.WriteLine($"Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine($"Olá, {nome}, vamos calcular seu peso ideal");

Console.WriteLine("");

Console.WriteLine("Digite a sua altura abaixo");
H = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

peso = (72.7 * H) -58;

Console.WriteLine($"{nome}, seu peso ideal é de: {peso}");
