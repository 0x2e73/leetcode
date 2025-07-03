namespace leetcode.exercices
{
    public static class LetterCombination
    {
        public static IList<string> LetterCombinations(string digits)
        {
            // digits[i] is a digit in the range ['2', '9'].
            var dictionnary = new Dictionary<char, char[]>
            {
                ['2'] = new[] { 'a', 'b', 'c' },
                ['3'] = new[] { 'd', 'e', 'f' },
                ['4'] = new[] { 'g', 'h', 'i' },
                ['5'] = new[] { 'j', 'k', 'l' },
                ['6'] = new[] { 'm', 'n', 'o' },
                ['7'] = new[] { 'p', 'q', 'r', 's' },
                ['8'] = new[] { 't', 'u', 'v' },
                ['9'] = new[] { 'w', 'x', 'y', 'z' }
            };

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
