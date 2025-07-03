namespace leetcode.exercices
{
    public static class LetterCombination
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
                return [];
                
            var dictionnary = new Dictionary<char, string>
            {
                ['2'] = "abc ",
                ['3'] = "def",
                ['4'] = "ghi",
                ['5'] = "jkl",
                ['6'] = "mno",
                ['7'] = "pqrs",
                ['8'] = "tuv",
                ['9'] = "wxyz"
            };

            var result = new List<string>();

            if (digits.Length == 1)
            {
                foreach (var v in dictionnary.FirstOrDefault(x => x.Key == digits[0]).Value)
                    result.Add($"{v}");

                return result;
            }

            else
            {
                result = [""];
                foreach (var d in digits)
                {
                    List<string> temp = new List<string>();
                    foreach (var combined in result)
                    {
                        foreach (var associated in dictionnary.FirstOrDefault(x => x.Key == d).Value)
                        {
                            temp.Add(combined + associated);
                        }
                    }
                    result = temp;
                }
                return result;
            }
        }

    }
}
