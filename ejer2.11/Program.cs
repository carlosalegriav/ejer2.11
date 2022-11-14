namespace ejerciciodosonce
{
    public class program
    {
        public static void Main()
        {
            double pago, metrosP, La, Lb, Lc, mt, Tolprec;
            Console.WriteLine("Ingrese el lado Ancho de la alberca");
            La=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado Largo de la alberca");
            Lb =double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de la alberca");
            Lc =double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del agua por metro cubico");
            mt = double.Parse(Console.ReadLine());

            metrosP=La*Lb*Lc;
            Tolprec = metrosP * mt;
            Console.WriteLine($"La cantidad de metros cubicos son : {metrosP}");
            Console.WriteLine($"La cantidad de metros cubicos son : {Tolprec}");



        }
    }
}
