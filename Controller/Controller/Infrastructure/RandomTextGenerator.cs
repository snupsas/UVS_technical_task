namespace Controller.Infrastructure
{
    using System;
    using System.Text;

    public static class RandomTextGenerator
    {
        const int lengthFrom = 5;
        const int lenghtTo = 11;

        public static string GetRandomString()
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            return Calculate(rnd);
        }

        public static string GetRandomString(int seed)
        {
            var rnd = new Random(seed);
            return Calculate(rnd);
        }

        private static string Calculate(Random rnd)
        {
            var builder = new StringBuilder();
            var length = rnd.Next(lengthFrom, lenghtTo);

            for (int i = 0; i < length; i++)
            {
                builder.Append(Convert.ToChar(rnd.Next(33, 127)));
            }

            return builder.ToString();
        }
    }
}
