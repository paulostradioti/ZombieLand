using ZombieLand.GameEngine;

namespace ZombieLand.Tests
{
    public class EnemyFactoryShould
    {
        #region Type
        [Fact]
        public void CreateNormalEnemyCorrecly()
        {
            var sut = new EnemyFactory();
            var enemy = sut.Create("Zombie");

            var result = Assert.IsType<NormalEnemy>(enemy);
            Assert.IsAssignableFrom<Enemy>(enemy);
        }
        #endregion

        #region References
        [Fact]
        public void CreateNewEnemyEverytime()
        {
            var sut = new EnemyFactory();

            var enemy1 = sut.Create("Zombie");
            var enemy2 = sut.Create("Zombie");

            // Assert.Same
            Assert.NotSame(enemy1, enemy2);
            Assert.False(object.ReferenceEquals(enemy1, enemy2));
        }
        #endregion

        #region Exceptions
        [Fact]
        public void ThrowExceptionWhenZombieNameIsNull()
        {
            var sut = new EnemyFactory();

            Action action = () => sut.Create(null);

            Assert.Throws<ArgumentNullException>("name", action);
        }
        #endregion

        #region Exceptions
        [Fact]
        public void ThrowExceptionWhenZombieBossNameIsInvalid()
        {
            var sut = new EnemyFactory();

            Action action = () => sut.Create("Zombie", isBoss: true);

            Assert.Throws<EnemyCreationException>(action);
            Assert.ThrowsAny<Exception>(action);
        }
        #endregion
    }
}
