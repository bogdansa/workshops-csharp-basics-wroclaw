namespace Source.Models
{
    public class Result<T>
    {
        public T Item { get; }
        public string ErrorMessage { get; }

        public Result(T item, string errorMessage = "")
        {
            Item = item;
            ErrorMessage = errorMessage;
        }
    }

    public class Pair<TFirst,TSecond> where TFirst : struct where TSecond : class
    {
        public TFirst First { get; }
        public TSecond Second { get; }
    }

    public class Triple<TThird> : Pair<int, string>
    {
        public TThird Third { get; }
    }

    public class Logger 
    {
        public void Log<T>(T value) where T : struct
        {

        }
    }
}