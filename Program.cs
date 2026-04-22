using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Unit
    {
        Random random = new Random();
        //public Unit (string input) { Name = input; Health = 100; Damage = 5; Armor = 0.6f; }
        public Unit (string input) { Name = input; Health = 100; Damage = new Interval(random.Next(0,100),random.Next(10,100)); Armor = 0.6f; }
        public Unit () : this ("Unknown unit") {}

        public float Health { get; set; }
        private string Name { get; }
        //private int Damage { get; }
        private Interval Damage { get; }
        private float Armor { get; }

        public float GetRealHealth() { return Health * (1f + Armor); }

        public bool SetDamage(float damage)
        {
            Health = Health - damage * Armor;
            if (Health <= 0) { Health = 0; return true; }     
            else return false;
        }

        public void Display() { Console.WriteLine($"Name: {Name}; Health: {Health}; Damage: {Damage.Min()}-{Damage.Max()}; Armor: {Armor}."); }
    }

    public class Weapon
    {
        private Weapon (string name) { Name = name; Durability = 1; }
        //public Weapon (string name, int min, int max) : this (name) { SetDamageParameters(min, max); }
        public Weapon (string name, Interval interval) : this (name) { SetDamageParameters(interval); }

        private string Name { get; set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        private float Durability { get; }

        /*public void SetDamageParameters (int min, int max)
        {
            if ( min > max ) { (min, max) = (max, min); Console.WriteLine($"Damage for {Name} has been set as {min}-{max}");}
            if ( min < 1 ) { min = 1; Console.WriteLine("Minimal damage has been set as 1"); }
            if ( max <= 1 ) { max = 10; Console.WriteLine("Maximal damage has been set as 10"); }

            MinDamage = min; 
            MaxDamage = max; 
        }*/

        public void SetDamageParameters (Interval interval)
        {
            MinDamage = interval.Min(); 
            MaxDamage = interval.Max(); 
        }

        public int GetDamage()
        {
            return MinDamage+MaxDamage/2;
        }

        public void Display() { Console.WriteLine($"Name: {Name}; Damage: {MinDamage}-{MaxDamage}; Durability: {Durability}.\n"); }

    }

    public struct Interval
    {
        private int minValue;
        private int maxValue;

        public Interval (int min, int max)
        {
            minValue = min;
            maxValue = max;

            if ( minValue > maxValue ) { (minValue, maxValue) = (maxValue, minValue); Console.WriteLine("Min <=> Max");}
            if ( minValue < 0 ) { minValue = 0; Console.WriteLine("Min has been set as 0"); }
            if ( maxValue < 0 ) { maxValue = 0; Console.WriteLine("Max has been set as 0"); }
            if ( minValue == maxValue ) {maxValue += 10; Console.WriteLine("Max value increased by 10"); } 
        }

        public int Min() { return minValue; }
        public int Max() { return maxValue; }
        public int Get() { var rand = new Random(); return rand.Next(minValue, maxValue); }
    }

    public struct Room
    {
        public Unit Unit { get; set; }
        public Weapon Weapon { get; set; }

        public Room (Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }

    public class Dungeon
    {
        Room[] rooms;

        public Dungeon()
        {
            Random random = new Random(); 
            rooms = new Room[random.Next(3,5)];
            Interval interval;
        
            for (int i = 0; i < rooms.Length; i++)
            {
                interval = new Interval(random.Next(1,10), random.Next(10,100));
                Unit unit = new Unit($"Unit {i+1}");
                Weapon weapon = new Weapon($"Weapon {i+1}", interval);
                rooms[i] = new Room(unit, weapon);
            }
        }

        public void ShowRooms() 
        { 
            Console.WriteLine($"\nCreated {rooms.Length} rooms\n");

            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"Room {i+1}");
                Console.Write("Unit - ");
                rooms[i].Unit.Display();
                Console.Write("Weapon - ");
                rooms[i].Weapon.Display(); 
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();
        }
    }
}
