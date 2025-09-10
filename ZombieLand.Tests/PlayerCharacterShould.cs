using ZombieLand.GameEngine;

namespace ZombieLand.Tests
{
    public class PlayerCharacterShould
    {
        #region Booleans
        [Fact]
        public void BeNoobWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void BeNotInfectedWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.False(sut.IsInfected);
        }
        #endregion

        #region Strings
        [Fact]
        public void HaveNonEmptyFirstNameWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.False(string.IsNullOrEmpty(sut.FirstName), "O nome não deve ser nulo ao criar um personagem.");
            Assert.NotNull(sut.FirstName); // Redundante
        }

        [Fact]
        public void HaveEmptyLastNameWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.Null(sut.LastName);
        }

        [Fact]
        public void HaveCorrectFullName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            Assert.Equal("Claire Redfield", sut.FullName, ignoreCase: true);
            Assert.Equal("Claire Redfield", sut.FullName, StringComparer.OrdinalIgnoreCase);
            Assert.Equal("Claire Redfield", sut.FullName, StringComparer.InvariantCultureIgnoreCase);
        }


        [Fact]
        public void HaveNameStartingWithClaire()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            Assert.StartsWith("Claire", sut.FullName, StringComparison.OrdinalIgnoreCase);
        }


        [Fact]
        public void HaveNameEndingWithRedfield()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            Assert.EndsWith("Redfield", sut.FullName, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void HaveFullNameContainingSpace()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            Assert.Contains(" ", sut.FullName);
        }


        [Fact]
        public void HaveFullNameStartingWithCapitalLetters()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Claire";
            sut.LastName = "Redfield";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }
        #endregion

        #region Numbers
        [Fact]
        public void HaveFullHealthWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.Equal(100, sut.Health);
        }

        [Fact]
        public void HaveNonZeroHealthWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.NotEqual(0, sut.Health);
        }


        [Fact]
        public void IncreaseHealthWhenEats()
        {
            var sut = new PlayerCharacter();

            sut.Eat();

            Assert.InRange(sut.Health, 101, 200);
        }
        #endregion

        #region Collections
        [Fact]
        public void HaveLongBowlWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.Contains("Long Bow", sut.Weapons);
        }

        [Fact]
        public void NotHaveStaffOfWonderWhenCreated()
        {
            var sut = new PlayerCharacter();
            Assert.DoesNotContain("Staff Of Wonder", sut.Weapons);
        }

        [Fact]
        public void HaveOneSwordWhenCreated()
        {
            var sut = new PlayerCharacter();
            
            Assert.Contains(sut.Weapons, weapon => weapon.Contains("sword", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void HaveOnlyValidWeaponsWhenCreated()
        {
            var sut = new PlayerCharacter();

            Assert.All(sut.Weapons, LancaExcecaoSeForStringEmpty);
            Assert.All(sut.Weapons, item => Assert.False(string.IsNullOrWhiteSpace(item)));
        }

        // Passado no lugar do Action (recebe parametro de entrada mas nao tem retorno)
        private void LancaExcecaoSeForStringEmpty(string obj) 
        {
            if (string.IsNullOrEmpty(obj))
                throw new Exception();
        }

        [Fact]
        public void HaveDefaultWeaponsWhenCreated()
        {
            var sut = new PlayerCharacter();

            var expectedWeapons = new[] 
            { 
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };

            // Comparação 1 a 1
            Assert.Equal(expectedWeapons, sut.Weapons); 
        }
        #endregion
    }
}