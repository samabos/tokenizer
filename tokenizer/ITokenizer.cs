using System;
using System.Collections.Generic;

namespace Tokenizer
{
    public interface ITokenizer
    {
        IList<string> GetTokens(string text);
    }
}
