#include <iostream>
#include <string>
using namespace std;
string Sumator(string str)
{
    int twoNumbers[2] = {0, 0};
    int index = str.length();
    int j = 0;
    string temp = "";
    string result = str;
    for (int i = 0; i < str.length(); ++i)
    {
        temp = str.substr(i, 1);
        
        if (isdigit(str[i])) 
        {
            twoNumbers[j] = twoNumbers[j] * 10 + stoi(temp);
            if (index > i) index = i;
            
        }
        else if (str[i] == '+') 
        {
            j = 1;
        }
        else 
        {
            //cout << twoNumbers[0] + twoNumbers[1] << " ";
            temp  = to_string(twoNumbers[0] + twoNumbers[1]);
            if (j) result.replace(result.length() - (str.length() - index),  i - index, temp);
            j = 0;
            index = str.length();
            twoNumbers[0] = 0;
            twoNumbers[1] = 0;
        }
    }
    if (j == 1)
    {
        temp  = to_string(twoNumbers[0] + twoNumbers[1]);
        if (j) result.replace(result.length() - (str.length() - index),  str.length() - index, temp);
        j = 0;
        index = str.length();
        twoNumbers[0] = 0;
        twoNumbers[1] = 0;
    }
    return result;
}

int main()
{
    cout<< Sumator("5+26-72+35gh32+45");

    return 0;
}
