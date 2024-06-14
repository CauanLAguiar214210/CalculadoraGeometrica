namespace CalculadorGeometrica.Entities
{
    internal class Retangulos
    {
        public static double Largura { get; set; }
        public static double Altura { get; set; }

        public static double Area(double largura, double altura)
        {
            return largura * altura;
        }

        public static double Perimetro(double largura, double altura)
        {
            return 2 * (altura + altura);
        }

        public static double Diagonal(double largura, double altura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
