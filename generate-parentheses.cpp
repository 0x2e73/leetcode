#include <iostream>
using namespace std;
#include <map>
#include <vector>
#include <string>
#include <unordered_map>


vector<string> generateParenthesis(int n)
{
    //TO implement
    // Example 1:

    // Input: n = 3
    // Output: ["((()))","(()())","(())()","()(())","()()()"]
    // Example 2:

    // Input: n = 1
    // Output: ["()"]
    // see: https://leetcode.com/problems/generate-parentheses/description/?envType=problem-list-v2&envId=backtracking
    
}

int main(int argc, char *argv[])
{

    string digits = argv[1];
    vector<string> combos = LetterCombinations(digits);
    for (const string &s : combos)
    {
        cout << s << " ";
    }
    cout << endl;
    return 0;
}
