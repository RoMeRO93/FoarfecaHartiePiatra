using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // generam un numar random intre 0 si 2
        Random random = new Random();
        int numar_random = random.Next(3); // 0, 1 sau 2

        // atribuim piatra, hartie, foarfeca in functie de numarul random
        string computer = "";
        if (numar_random == 0)
        {
            computer = "piatra";
        }
        if (numar_random == 1)
        {
            computer = "hartie";
        }
        if (numar_random == 2)
        {
            computer = "foarfeca";
        }

        // luam optiunea de la utilizator
        Console.WriteLine("Alege piatra, hartie, foarfeca");
        string utilizator = Console.ReadLine();

        // afisam ce a ales computer-ul
        Console.WriteLine("Calculatorul a ales " + computer);

        // evaluam situatiile posibile
        if (computer == utilizator)
        {
            Console.WriteLine("Egalitate! Ati ales la fel");
        }
        if (computer == "piatra" && utilizator == "hartie")
        {
            Console.WriteLine("Ai castigat! Hartia infasoara piatra");
        }
        if (computer == "piatra" && utilizator == "foarfeca")
        {
            Console.WriteLine("Ai pierdut! Piatra strica foarfeca");
        }
        if (computer == "hartie" && utilizator == "piatra")
        {
            Console.WriteLine("Ai pierdut! Hartia infasoara piatra");
        }
        if (computer == "hartie" && utilizator == "foarfeca")
        {
            Console.WriteLine("Ai castigat! Foarfeca taie hartia");
        }
        if (computer == "foarfeca" && utilizator == "piatra")
        {
            Console.WriteLine("Ai castigat! Piatra strica foarfeca");
        }
        if (computer == "foarfeca" && utilizator == "hartie")
        {
            Console.WriteLine("Ai pierdut! Foarfeca taie hartia");
        }
    }
}
