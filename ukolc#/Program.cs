
using ukolc_;

namespace SimpleEnemyFight{
    public class Program {
        static void Main(string[] args) {
            Enemy franta = new Enemy("Franta", 5, 30);
            Enemy pepa = new Enemy("Pepa", 3, 40);

            franta.Attack(pepa);
            pepa.Attack(franta);

            Console.WriteLine(franta);
            Console.WriteLine(pepa);
        }
    }
}