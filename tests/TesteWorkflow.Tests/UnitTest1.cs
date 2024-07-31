using LibTeste;

namespace TesteWorkflows.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello", new TesteWorkflow().GetHello());
        }
    }
}