namespace Classes
{
    public class Unit
    {
        private string _name;
        private float _health;

        public Unit (string input) { Name = input; Health = 100; }
        public Unit () : this ("Unknown unit") {}

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Damage
        {
            get { return 5; }
        }

        public float Armor
        {
            get { return 0.6f; }
        }
        
        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(int damage)
        {
            Health = Health - damage * Armor;

            if (Health <= 0)
            {
                Health = 0;
                return true;
            }     
            else 
                return false;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {_name}; Health: {Health}; Damage: {Damage}; Armor: {Armor}.");
        }
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

            Console.WriteLine("\nChecking his real health");
            Console.WriteLine($"Real health: {b.GetRealHealth()}");

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
