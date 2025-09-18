#nullable enable

namespace ZombieLand.GameEngine
{
    public class PlayerCharacter
    {
        private int _health = 100;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Nickname { get; set; }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public bool IsNoob { get; set; }
        public bool IsInfected { get; set; }
        public List<string> Weapons { get; set; }

        public PlayerCharacter()
        {
            FirstName = GenerateRandomFirstName();
            IsNoob = true;
            IsInfected = false;

            CreateStartingWeapons();
        }

        public void Eat()
        {
            var healthIncrease = CalculateHealthIncrease();
            Health += healthIncrease;
        }

        private int CalculateHealthIncrease()
            => Random.Shared.Next(0, 101);

        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }

        private string GenerateRandomFirstName()
        {
            var possibleRandomStartingNames = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "G'Toth'lop",
                "Boldrakteethtop"
            };

            return possibleRandomStartingNames[Random.Shared.Next(0, possibleRandomStartingNames.Length)];
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
                //""
                //"Staff Of Wonder",
            };
        }
    }
}