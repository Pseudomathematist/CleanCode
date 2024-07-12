#include <iostream>
#include <vector>

void enlarge(std::vector<int> & vec) {
    int oldSize = vec.size();
    int newSize = 2 * oldSize - 1;

    for (size_t i = 0; i < oldSize - 1; ++i) {
        int averageNeighborValue = (vec[i] + vec[i + 1]) / 2;
        vec.insert(vec.begin() + i * 2 + 1, averageNeighborValue);
    }
}

int main() {
    std::vector<int> numbers = {1, 2, 3, 4, 5};
    enlarge(numbers);

    for (int x : numbers) {
        std::cout << x << " ";
    }

    return 0;
}
