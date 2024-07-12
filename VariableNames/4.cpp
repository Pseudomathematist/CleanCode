#include <iostream>
#include <string>

std::string find_substring(std::string str1, std::string str2) {
    std::string result = str1;
    int len = str2.length();
    int indexOfSubstrStart = 0;
    indexOfSubstrStart = result.find(str2, indexOfSubstrStart);
    while (indexOfSubstrStart != std::string::npos) {
        result.insert(indexOfSubstrStart, "(");
        result.insert(indexOfSubstrStart + len + 1, ")");
        indexOfSubstrStart = result.find(str2, indexOfSubstrStart + len + 3);
    }
    return result;
}

int main() {
    std::string str1 = "3000300233.300.1", str2 = "300";
    std::cout << find_substring(str1, str2);
    return 0;
}
