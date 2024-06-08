using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Result.oddNumbers(3, 9);
    
    }

    class Result{

        public static List<int> oddNumbers(int l, int r)
        {

        List<int> notDivisible = [];
        for(int a = l; a <= r; a++){
            if(a%2 != 0) notDivisible.Add(a);
        }
        return notDivisible;
    }


        public static string timeWords(List<int> wait, int search)
        {
           if(wait.Find(x => x == search) == 0)return "NO";
            return "YES";
        }

        public static string[] changeNumbersInWords(int h, int m)
        {

            string hour = convert(h);
            string minutes = convert(m);

            return [hour, minutes];
        }

        public static string convert(int number)
        {
            string translated = "";
            string[] numberZeroTo13 = [
                "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen"
                ];
            if (number > 30) number = 60 - number;

            if ((number >= 1) && (number <= 13))
            {
                translated = numberZeroTo13[number];
            }
            else if ((number >= 4) && (number <= 19))
            {
                translated = numberZeroTo13[number] + "teen";
            }
            else if (number >= 20)
            {
                string lastNumber = number.ToString();

                int pos = int.Parse(lastNumber[1].ToString());
                translated = "twenty " + numberZeroTo13[pos];
            }
            else if ((number == 15) || (number == 45))
            {
                translated = "quarter";
            }
            else if (number == 30)
            {
                translated = "half";
            }


            return translated;
        }

    }
}