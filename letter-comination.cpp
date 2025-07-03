#include <iostream>
using namespace std;
#include <map>
#include <vector>
#include <string>
#include <unordered_map>


vector<string> LetterCombinations(const string& digits) {

    if(digits.empty())
        return {};

    unordered_map<char, string> dictionnary = {
        {'2', "abc"}, 
        {'3', "def"}, 
        {'4', "ghi"},
        {'5', "jkl"}, 
        {'6', "mno"}, 
        {'7', "pqrs"},
        {'8', "tuv"}, 
        {'9', "wxyz"}
    };

    vector<string> result; 

    if (digits.length() == 1) {
        for (char v : dictionnary[digits[0]]) {
            result.push_back(string(1, v));
        }
        return result;
    }
    else {
        result = {""};
        for(char d: digits){
            vector<string> temp;
            for(string combined: result){
                for(char associatedLetter: dictionnary[d]){
                    temp.push_back(combined + associatedLetter);
                }
            }
            result = temp;
        }
        return result;
    }
}

int main(int argc, char* argv[]) {
  if (argc < 2) {
        cout << "Usage: " << argv[0] << " <digits>" << endl;
        return 1;
    }
    string digits = argv[1];
    vector<string> combos = LetterCombinations(digits);
    for (const string& s : combos) {
        cout << s << " ";
    }
    cout << endl;
    return 0;
}
