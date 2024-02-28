namespace TestTaskForHighGroundTechnology
{
    public class Util
    {
        public static List<int> ParseInput(string list)
        {
            return new List<int>(Array.ConvertAll(list.Replace(" ", "").Split(","), int.Parse));
        }

        public static string GetFizzBuzzOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "fizz-buzz";
            else if (number % 3 == 0)
                return "fizz";
            else if (number % 5 == 0)
                return "buzz";
            else
                return number.ToString();
        }

        public static string GetFizzBuzzMuzzGuzzOutput(int number)
        {
            List<string> replacements = new List<string>();

            if (number % 3 == 0)
                replacements.Add("fizz");
            if (number % 5 == 0)
                replacements.Add("buzz");
            if (number % 4 == 0)
                replacements.Add("muzz");
            if (number % 7 == 0)
                replacements.Add("guzz");

            if (replacements.Count > 0)
                return string.Join("-", replacements);
            else
                return number.ToString();
        }

        public static string GetCatDogMuzzGuzzOutput(int number)
        {
            List<string> replacements = new List<string>();

            if (number % 3 == 0 && number % 5 == 0)
                replacements.Add("good-boy");
            else if (number % 3 == 0)
                replacements.Add("dog");
            else if (number % 5 == 0)
                replacements.Add("cat");
            if (number % 4 == 0)
                replacements.Add("muzz");
            if (number % 7 == 0)
                replacements.Add("guzz");

            if (replacements.Count > 0)
                return string.Join("-", replacements);
            else
                return number.ToString();
        }
    }
}
