namespace CalculadorGeometrica.Entities
{
    internal class Triangulos
    {
        public static double A { get; set; }
        public static double B { get; set; }
        public static double C { get; set; }

        public static double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
