namespace _2_1_Oppgave_3_if_else_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 13;
            int numb2 = 18;
            bool isTheNumb30 = false; // Sjekker om summen er 30 eller ikke. I dette tilfellet; false.
            int sum = numb1 + numb2; // Legger sammen summen av numb1 og numb2.

            if (sum == 30) // Hvis nummerene er 30, blir de returnert "true".
            {
                isTheNumb30 = true;
                Console.WriteLine("Sum av nummerene ER 30, og verdien er: " + isTheNumb30);
            }
            else // Hvis nummerene ikke blir 30, blir de returnert "false".
            {
                Console.WriteLine("Sum av nummerene er IKKE 30, og verdien er: " + sum + " aka " + isTheNumb30);
            }
        }
    }
}
