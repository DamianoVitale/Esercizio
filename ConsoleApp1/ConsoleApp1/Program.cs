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
            short scelta;
            do
            {
                Console.WriteLine("1: Inserire nuovo Contatto");
                Console.WriteLine("2: Visualizza Contatti");
                Console.WriteLine("3: Ricerca un contatto ");
                Console.WriteLine("4: Elimina un contato");
                Console.WriteLine("0: ESCI DAL PROGRAMMA");
                Console.Write("Inserisci l'opzione -> ");
                short.TryParse(Console.ReadLine(), out scelta);
                Console.WriteLine();

                switch (scelta)
                {
                    case 1:

                        Console.Write("Inserire nome Contatto: ");
                        contatti.Add(Console.ReadLine());
                        break;
                    case 2:

                        foreach (string contatto in contatti)
                        {
                            Console.WriteLine(contatto);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserisci Nome da ricercare: ");
                        if (contatti.Contains(Console.ReadLine()))
                        {
                            Console.WriteLine("Il contatto è presente nella lista.");
                        }
                        else
                        {
                            Console.WriteLine("Il contatto non è presente nella lista.");
                        }
                        break;
                    case 4:

                        Console.WriteLine("Inserire il nome del contatto da eliminare: ");
                        contatti.Remove(Console.ReadLine());
                        break;
                }

                Console.WriteLine();
            } while (scelta != 0);

        }
    }
}
