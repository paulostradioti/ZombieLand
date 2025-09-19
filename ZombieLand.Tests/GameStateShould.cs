using System.Runtime.CompilerServices;
using Xunit.Abstractions;
using ZombieLand.Tests.Fixtures;

namespace ZombieLand.Tests
{
    public class GameStateShould : IClassFixture<GameStateFixture>
    {
        private readonly GameStateFixture fixture;
        private readonly ITestOutputHelper outputHelper;

        public GameStateShould(GameStateFixture fixture, ITestOutputHelper outputHelper)
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
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");

        }

        [Fact]
        public void Teste2()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste3()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste4()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste5()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste6()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste7()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste8()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }

        [Fact]
        public void Teste9()
        {
            fixture.State.Players.First().TakeDamage(1);
            fixture.State.Players.ForEach(x => outputHelper.WriteLine(x.Health.ToString()));

            outputHelper.WriteLine(fixture.State.Id.ToString());
            outputHelper.WriteLine($"pid={Environment.ProcessId} " + Environment.NewLine +
                                    $"thread={Thread.CurrentThread.ManagedThreadId} " + Environment.NewLine +
                                    $"tfm={System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription} " + Environment.NewLine +
                                    $"asm={typeof(GameStateShould).Assembly.Location} " + Environment.NewLine +
                                    $"fixture#{RuntimeHelpers.GetHashCode(fixture)} " + Environment.NewLine +
                                    $"state#{RuntimeHelpers.GetHashCode(fixture.State)} " + Environment.NewLine +
                                    $"id={fixture.State.Id}");
        }
    }
}
