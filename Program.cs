using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Informe o consumo médio do seu carro Km/L: ");
    float consumoMedio = float.Parse(Console.ReadLine());
    Console.Write("Informe a distância que será percorrida: ");
    float dist = float.Parse(Console.ReadLine());
    float consumoTotal = dist / consumoMedio;
    Console.Write("Informe o valor médio do combustível: ");
    float valorComb = float.Parse(Console.ReadLine());
    float valorCombTotal = consumoTotal * valorComb;
    
    Console.WriteLine("O seu carro irá consumir {0:N2}L.", consumoTotal);
    Console.WriteLine("Você gastará em média R${0:N2} reais", valorCombTotal);   
  }
}