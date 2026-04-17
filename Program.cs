namespace Classes
{
    public class Unit
    {
        public Unit (string input) { Name = input; Health = 100; Damage = 5; Armor = 0.6f; }
        public Unit () : this ("Unknown unit") {}

        private string Name { get; set; }
        private float Health { get; set; }
        private int Damage { get; set; }
        private float Armor { get; set; }

        public float GetRealHealth() { return Health * (1f + Armor); }

        public bool SetDamage(float damage)
        {
            Health = Health - damage * Armor;
            if (Health <= 0) { Health = 0; return true; }     
            else return false;
        }

        public void Display() { Console.WriteLine($"Name: {Name}; Health: {Health}; Damage: {Damage}; Armor: {Armor}."); }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Unit a = new Unit();
            Console.WriteLine("Created blank unit");
            a.Display();

            Unit b = new Unit("Named unit");
            Console.WriteLine("\nCreated named unit");
            b.Display();

            Console.WriteLine("\nChecking his health");
            Console.WriteLine($"Health: {b.GetRealHealth()}");

            Console.WriteLine("\nGiving him 10 damage");
            bool check = b.SetDamage(10);
            Console.WriteLine($"Real health: {b.GetRealHealth()}");
            Console.WriteLine($"Unit alive: {!check}");

            Console.WriteLine("\nGiving him 200 damage");
            check = b.SetDamage(200);
            Console.WriteLine($"Real health: {b.GetRealHealth()}");
            Console.WriteLine($"Unit alive: {!check}");
        }
    }
}
