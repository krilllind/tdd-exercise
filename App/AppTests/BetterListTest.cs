using Xunit;
using App;

namespace AppTests
{
    public class BetterListTest
    {
        [Fact]
        public void BetterList_ShoudBeCreated()
        {
            var list = new BetterList();
            Assert.NotNull(list);
        }
    }
}