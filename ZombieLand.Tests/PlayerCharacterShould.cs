using FluentAssertions;
using Xunit.Abstractions;
using ZombieLand.GameEngine;
using ZombieLand.Tests.TestData;

namespace ZombieLand.Tests
{
    public class PlayerCharacterShould
    {
        public ITestOutputHelper OutputHelper { get; }

        public PlayerCharacterShould(ITestOutputHelper outputHelper)
            => OutputHelper = outputHelper;

        #region Booleans
        //[Fact(Skip = "Precisa de uma melhoria")]
        [Fact]
        [Trait("Category", "Boolean")]
        public void BeNoobWhenCreated()
        {
            OutputHelper.WriteLine("Aqui vai uma informacão importante para o log");

            var sut = new PlayerCharacter();

            //Assert.True(sut.IsNoob);
            sut.IsNoob.Should().BeTrue();
        }

        [Fact]
        [Trait("Category", "Boolean")]
        public void BeNotInfectedWhenCreated()
        {
            var sut = new PlayerCharacter();


            //Assert.False(sut.IsInfected);
            sut.IsInfected.Should().BeFalse();
        }
        #endregion

        #region Strings
        [Fact]
        [Trait("Category", "String")]
        public void HaveNonEmptyFirstNameWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.False(string.IsNullOrEmpty(sut.FirstName), "O nome não deve ser nulo ao criar um personagem.");
            //Assert.NotNull(sut.FirstName); // Redundante
            sut.FirstName.Should().NotBeNull();
            sut.FirstName.Length.Should().BeGreaterThanOrEqualTo(1);
        }

        [Fact]
        [Trait("Category", "String")]
        public void HaveEmptyLastNameWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.Null(sut.LastName);
            sut.LastName.Should().BeNull();
        }

        [Fact]
        [Trait("Category", "String")]
        public void HaveCorrectFullName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            //Assert.Equal("Claire Redfield", sut.FullName, ignoreCase: true);
            //Assert.Equal("Claire Redfield", sut.FullName, StringComparer.OrdinalIgnoreCase);
            //Assert.Equal("Claire Redfield", sut.FullName, StringComparer.InvariantCultureIgnoreCase);
            sut.FullName.Should().BeEquivalentTo("Claire Redfield"); // para strings, ignora o casing

            // Para COLEÇÕES ignora a ordem
        }

        [Fact]
        [Trait("Category", "String")]
        public void HaveNameStartingWithClaire()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            //Assert.StartsWith("Claire", sut.FullName, StringComparison.OrdinalIgnoreCase);
            //sut.FullName.Should().StartWithEquivalentOf("Claire");

            sut.FullName.Should()
                .StartWithEquivalentOf("Claire").And
                .EndWithEquivalentOf("Redfield").And
                .ContainEquivalentOf(" ");
        }


        [Fact]
        [Trait("Category", "String")]
        public void HaveNameEndingWithRedfield()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            //Assert.EndsWith("Redfield", sut.FullName, StringComparison.OrdinalIgnoreCase);
            sut.FullName.Should().EndWithEquivalentOf("Redfield");
        }

        [Fact]
        [Trait("Category", "String")]
        public void HaveFullNameContainingSpace()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "claire";
            sut.LastName = "redfield";

            //Assert.Contains(" ", sut.FullName);
            sut.FullName.Should().ContainEquivalentOf(" ");
        }


        [Fact]
        [Trait("Category", "String")]
        public void HaveFullNameStartingWithCapitalLetters()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Claire";
            sut.LastName = "Redfield";

            //Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);`
            sut.FullName.Should().MatchRegex("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+");
        }
        #endregion

        #region Numbers
        [Fact]
        public void HaveFullHealthWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.Equal(100, sut.Health);
            sut.Health.Should().Be(100);
        }

        [Fact]
        public void HaveNonZeroHealthWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.NotEqual(0, sut.Health);
            sut.Health.Should().NotBe(0);
        }


        [Fact]
        public void IncreaseHealthWhenEats()
        {
            var sut = new PlayerCharacter();

            sut.Eat();

            //Assert.InRange(sut.Health, 101, 200);
            sut.Health.Should().BeInRange(101, 200);
        }
        #endregion

        #region Collections
        [Fact]
        public void HaveLongBowlWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.Contains("Long Bow", sut.Weapons);
            sut.Weapons.Should().Contain("Long Bow");
        }

        [Fact]
        public void NotHaveStaffOfWonderWhenCreated()
        {
            var sut = new PlayerCharacter();

            //Assert.DoesNotContain("Staff Of Wonder", sut.Weapons);
            sut.Weapons.Should().NotContain("Staff Of Wonder");
        }

        [Fact]
        public void HaveOneSwordWhenCreated()
        {
            var sut = new PlayerCharacter();

            // Predicado -> Pelo menos um Item da coleção DEVE satisfazer o predicado
            //Assert.Contains(sut.Weapons, weapon => weapon.Contains("sword", StringComparison.OrdinalIgnoreCase));
            sut.Weapons.Should().Contain(weapon => weapon.Contains("sword", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void HaveOnlyValidWeaponsWhenCreated()
        {
            var sut = new PlayerCharacter();

            // Predicado -> TODOS os Items da coleção DEVEM satisfazer o predicado
            //Assert.All(sut.Weapons, LancaExcecaoSeForStringEmpty);
            //Assert.All(sut.Weapons, item => Assert.False(string.IsNullOrWhiteSpace(item)));
            sut.Weapons.Should().OnlyContain(weapon => !string.IsNullOrWhiteSpace(weapon));

            void LancaExcecaoSeForStringEmpty(string obj)
            {
                if (string.IsNullOrEmpty(obj))
                    throw new Exception();
            }
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
            //Assert.Equal(expectedWeapons, sut.Weapons);
            sut.Weapons.Should().Equal(expectedWeapons); // Ordem faz diferença
            sut.Weapons.Should().BeEquivalentTo(expectedWeapons); // Ordem NÃO faz diferença
        }
        #endregion

        [Theory]
        [InlineData(10, 90)]
        [InlineData(15, 85)]
        [InlineData(75, 25)]
        [InlineData(200, 1)]
        public void DecreaseHealthWhenTakesDemage(int demage, int expectedHealth)
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(demage);

            sut.Health.Should().Be(expectedHealth);
        }

        [Theory]
        [MemberData(nameof(DataForMemberDataTests.GetInternalData), MemberType = typeof(DataForMemberDataTests))]
        public void DecreaseHealthWhenTakesDemage_WithInternalData(int demage, int expectedHealth)
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(demage);

            sut.Health.Should().Be(expectedHealth);
        }

        [Theory]
        [MemberData(nameof(DataForMemberDataTests.Data), MemberType = typeof(DataForMemberDataTests))]
        public void DecreaseHealthWhenTakesDemage_WithInternalDataViaProperty(int demage, int expectedHealth)
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(demage);

            sut.Health.Should().Be(expectedHealth);
        }

        [Theory]
        [MemberData(nameof(DataForMemberDataTests.GetExternalData), MemberType = typeof(DataForMemberDataTests))]
        public void DecreaseHealthWhenTakesDemage_WithExternalData(int demage, int expectedHealth)
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(demage);

            sut.Health.Should().Be(expectedHealth);
        }
    }
}