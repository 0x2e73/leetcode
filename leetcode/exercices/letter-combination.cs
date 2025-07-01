namespace leetcode.exercices
{
    public static class LetterCombination
    {
        public static IList<string> LetterCombinations(string digits)
        {
            // digits[i] is a digit in the range ['2', '9'].
            var dictionnary = new Dictionary<char, char[]>();
            dictionnary.Add('2', ['a', 'b', 'c']);
            dictionnary.Add('3', ['d', 'e', 'f']);
            dictionnary.Add('4', ['g', 'h', 'i']);
            dictionnary.Add('5', ['j', 'k', 'l']);
            dictionnary.Add('6', ['m', 'n', 'o']);
            dictionnary.Add('7', ['p', 'q', 'r', 's']);
            dictionnary.Add('8', ['t', 'u', 'v']);
            dictionnary.Add('9', ['w', 'x', 'y', 'z']);

            var result = new List<string>();
            var digitLength = digits.Length;
            Console.WriteLine(digitLength);

            if (digitLength > 0 && digitLength > 1)
            {
                for (int i = 0; i < digitLength; i++)
                {
                    if (!(i + 1 > digitLength))
                    {

                        var firstDigit = dictionnary.FirstOrDefault(x => x.Key == digits[i]);
                        var secondDigit = dictionnary.FirstOrDefault(x => x.Key == digits[i + 1]);

                        for (int j = 0; j < firstDigit.Value.Count(); j++)
                        {
                            for (int k = 0; k < secondDigit.Value.Count(); k++)
                            {
                                result.Add($"{firstDigit.Value[j]}{secondDigit.Value[k]}");
                                Console.WriteLine($"{firstDigit.Value[j]}{secondDigit.Value[k]}");
                            }
                        }
                    }
                }
            }

            if (digitLength == 1)
            {
                foreach (var v in dictionnary.FirstOrDefault(x => x.Key == digits[0]).Value)
                    result.Add($"{v}");
            }

            return result;
        }

    }
}
