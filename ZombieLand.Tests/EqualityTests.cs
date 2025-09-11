using ZombieLand.GameEngine;

namespace ZombieLand.Tests
{
    public class EqualityTests
    {
        [Fact]
        public void Reference_Equality()
        {
            var enemy1 = new NormalEnemy() { Name = "Zombinho Legal" };
            var enemy2 = new NormalEnemy() { Name = "Zombinho Legal" };


            Assert.Equal(enemy1, enemy2);
            Assert.True(enemy1 == enemy2);
        }

        [Fact]
        public void HashSet()
        {
           var set = new HashSet<NormalEnemy>();

            var enemy1 = new NormalEnemy() { Name = "Zombinho Legal" };
            var enemy2 = new NormalEnemy() { Name = "Zombinho Legal" };

            Assert.Equal(enemy1, enemy2);
            Assert.True(enemy1 == enemy2);

            // Set está VAZIO

            set.Add(enemy1); // Adiciona o primeiro elemento
            set.Add(enemy2); // Espero que o set reconheça que é "IGUAL" ao primeiro, e 
                             //  não adicione a duplicidade
        }
    }
}
