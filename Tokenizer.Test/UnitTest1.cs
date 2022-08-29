
using System.Diagnostics;
using System.Linq;

namespace Tokenizer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITokenizer tokenizer = new Tokenizer();

            var resp = tokenizer.GetTokens("I Have a Lovely Wife");
            Console.WriteLine("result: "+string.Join(',',resp));
            Assert.IsNotNull(resp);
        }
    }
}