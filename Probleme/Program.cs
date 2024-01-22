namespace Probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de persoane: ");
            int numarPersoane = int.Parse(Console.ReadLine());

            Person[] persoane = new Person[numarPersoane];

            for (int i = 0; i < numarPersoane; i++)
            {
                Console.WriteLine($"Introduceti informatiile pentru persoana {i + 1}:");

                Console.Write("Prenume: ");
                string prenume = Console.ReadLine();

                Console.Write("Nume de familie: ");
                string numeDeFamilie = Console.ReadLine();

                Console.Write("Anul nasterii: ");
                int anulNasterii = int.Parse(Console.ReadLine());

                persoane[i] = new Person(prenume, numeDeFamilie, anulNasterii);
            }

            Console.WriteLine("Informatiile persoanelor:");
        }
    }
}