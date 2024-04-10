namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contatti = new List<string>();
            contatti.Add("Damiano");
            contatti.Add("Mario");
            contatti.Add("Andrea");

            Console.Write("Inserire nome Contatto: ");
            contatti.Add(Console.ReadLine());

            foreach (string contatto in contatti)
            {
                Console.WriteLine(contatto);
            }
            Console.WriteLine("\nInserisci Nome da ricercare: ");
             if (contatti.Contains(Console.ReadLine()))
            {
                Console.WriteLine("\nIl contatto è presente nella lista.");
            }
            else
            {
                Console.WriteLine("\nIl contatto non è presente nella lista.");
            }

            Console.WriteLine("\nInserire il nome del contatto da eliminare: ");
            contatti.Remove(Console.ReadLine());

        }
    }
}
