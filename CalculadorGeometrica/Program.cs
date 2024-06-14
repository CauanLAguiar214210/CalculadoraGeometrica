using CalculadorGeometrica.Entities;
using System.Globalization;

namespace CalculadorGeometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char acao;
            
            do
            {
                Console.Write("Menu:\n(T)#Triangulos \n(R)#Retanguls \n(E)#Esferas \n(F)#Finalizar e Sair \n\nSelecione a forma:");
                acao = char.Parse(Console.ReadLine());

                if (acao == 'T')
                {
                    Console.Write("Entre com as medidas do triângulo X: \nA:");
                    Triangulos.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("B:");
                    Triangulos.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("C:");
                    Triangulos.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Área de X = " + Triangulos.Area().ToString("F4", CultureInfo.InvariantCulture) + "\n");
                }
                else if (acao == 'R')
                {
                    Console.Write("Largura: ");
                    Retangulos.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    Retangulos.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area = Retangulos.Area(Retangulos.Altura, Retangulos.Largura);
                    double perimetro = Retangulos.Perimetro(Retangulos.Altura, Retangulos.Largura);
                    double diagonal = Retangulos.Diagonal(Retangulos.Altura, Retangulos.Largura);

                    Console.WriteLine("\nArea: " + area.ToString("F2"));
                    Console.WriteLine("Perimetro: " + perimetro.ToString("F2"));
                    Console.WriteLine("Diagonal: " + diagonal.ToString("F2"));
                    Console.ReadLine();
                }
                else if (acao == 'E')
                {
                    Console.WriteLine("Entre com o valor do raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double circ = Esferas.Circunferencia(raio);
                    double volume = Esferas.Volume(raio);

                    Console.WriteLine("\nCircunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor de PI: " + Esferas.Pi.ToString("F2", CultureInfo.InvariantCulture));
                    Console.ReadLine();
                }

            } while (acao != 'F');
        }
    }
}
