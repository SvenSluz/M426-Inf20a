namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public static string Determine(int input)
        {
            var result = ((input % 3 == 0) ? "Foo" : "") + ((input % 5 == 0) ? "Bar" : "") +
                         ((input % 7 == 0) ? "Qix" : "");

            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }
    }
}