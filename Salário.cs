double x;
string salario = Console.ReadLine();
double.TryParse(salario, out x);


double novoSalario1 = x * 0.15;
double novoSalarioBruto1 = x + novoSalario1;

double novoSalario2 = x * 0.12;
double novoSalarioBruto2 = x + novoSalario2;

double novoSalario3 = x * 0.10;
double novoSalarioBruto3 = x + novoSalario3;

double novoSalario4 = x * 0.07;
double novoSalarioBruto4 = x + novoSalario4;

double novoSalario5 = x * 0.04;
double novoSalarioBruto5 = x + novoSalario5;


if(x <= 400){
    Console.WriteLine("Novo salario: " + novoSalarioBruto1.ToString("F2"));
    Console.WriteLine("Reajuste ganho: " + novoSalario1.ToString("F2"));
    Console.WriteLine("Em percentual: 15 %");
}


else if(x <= 800){
    Console.WriteLine("Novo salario: " + novoSalarioBruto2.ToString("F2"));
    Console.WriteLine("Reajuste ganho: " + novoSalario2.ToString("F2"));
    Console.WriteLine("Em percentual: 12 %");
}


else if(x <= 1200){
    Console.WriteLine("Novo salario: " + novoSalarioBruto3.ToString("F2"));
    Console.WriteLine("Reajuste ganho: " + novoSalario3.ToString("F2"));
    Console.WriteLine("Em percentual: 10 %");
}


else if(x <= 2000){
    Console.WriteLine("Novo salario: " + novoSalarioBruto4.ToString("F2"));
    Console.WriteLine("Reajuste ganho: " + novoSalario4.ToString("F2"));
    Console.WriteLine("Em percentual: 7 %");
}


else if(x > 2000){
    Console.WriteLine("Novo salario: " + novoSalarioBruto5.ToString("F2"));
    Console.WriteLine("Reajuste ganho: " + novoSalario5.ToString("F2"));
    Console.WriteLine("Em percentual: 4 %");
}
