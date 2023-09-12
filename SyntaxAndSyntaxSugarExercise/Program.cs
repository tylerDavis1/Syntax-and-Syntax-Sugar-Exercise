namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }


            //inferred typing 
            // string interpolation 
            // ternary operator

            var reponse = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater that or equal to nine";
            Console.WriteLine(response);
            
        }
    }
}
