using Xunit.Abstractions;
using ZombieLand.Tests.Fixtures;

namespace ZombieLand.Tests
{
    [Collection(GameStateFixtureCollection.CollectionName)]
    public class FixtureTests1
    {
        private readonly GameStateFixture fixture;
        private readonly ITestOutputHelper outputHelper;

        public FixtureTests1(GameStateFixture fixture, ITestOutputHelper outputHelper)
        {
            this.fixture = fixture;
            this.outputHelper = outputHelper;
        }


        [Fact]
        public void Teste1()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste2()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste3()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste4()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste5()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste6()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste7()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste8()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

        [Fact]
        public void Teste9()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
        }

    }
}
