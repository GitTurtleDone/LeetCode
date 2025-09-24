#include <iostream>

class Solution {
public:
    int hammingWeight(uint32_t n) {
        int count = 0;
        while (n) {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
};

int main() {
    Solution sol;
    uint32_t n;
    std::cout << "Enter an integer: ";
    std::cin >> n;
    std::cout << "Number of 1 bits: " << sol.hammingWeight(n) << std::endl;
    return 0;
}