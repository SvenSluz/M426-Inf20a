using System.Linq;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            var result = ((input % 3 == 0) ? "Foo" : "") + ((input % 5 == 0) ? "Bar" : "") +
                         ((input % 7 == 0) ? "Qix" : "");

            var resultByChar = DetermineByChar(input);
            return (string.IsNullOrEmpty(result)
                ? string.IsNullOrEmpty(resultByChar) ? input.ToString() : resultByChar
                : result + resultByChar);
        }

        public string DetermineByChar(int input)
        {
            var result = "";
            foreach (var num in input.ToString())
            {
                switch (num)
                {
                    case '3':
                        result += "Foo";
                        break;
                    case '5':
                        result += "Bar";
                        break;
                    case '7':
                        result += "Qix";
                        break;
                }
            }

            return result;
        }
    }
}