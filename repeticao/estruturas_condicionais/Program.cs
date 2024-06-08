
internal class Program
{
    public static void Main(string[] args)
    {
        //string teste = "22";

        Console.WriteLine(ReverseCase([3, 4, 10, 2, 1])[0]);
        static double[] ReverseCase(int[] seq )
        {   
            return new double[] {seq.Min(), seq.Max()};
        }
    }
}
