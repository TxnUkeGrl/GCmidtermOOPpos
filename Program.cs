using System;

namespace midterm_pos_terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConesSoftServe.MenuTextFile.WriteFlavorMenu();

            ConesSoftServe.MenuTextFile.GetFlavorMenu();
        }
    }
}
