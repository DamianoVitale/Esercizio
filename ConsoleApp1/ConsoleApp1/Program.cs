namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contatti = new List<string>();
            contatti.Add("Primo elemento");
            contatti.Add("Secondo elemento");
            contatti.Add("Terzo elemento");

            Console.Write("Inserire nome Contatto: ");
            contatti.Add(Console.ReadLine());

            foreach (string contatto in contatti)
            {
                Console.WriteLine(contatto);
            }
            Console.WriteLine("Inserisci Nome da ricercare: ");
             if (contatti.Contains(Console.ReadLine()))
            {
                Console.WriteLine("Il contatto è presente nella lista.");
            }
            else
            {
                Console.WriteLine("Il contatto non è presente nella lista.");
            }
        }
    }
}
