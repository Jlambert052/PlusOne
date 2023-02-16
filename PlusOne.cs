public class Solution {
    public int[] PlusOne(int[] digits) {
        int count = digits.Length -1;
        while(count >= 0 && digits[count] == 9) {
            digits[count] = 0;
            count--;
        }
        if(count < 0)
        {
            Array.Resize(ref digits, digits.Length +1);
            count = 0;
        }
        digits[count]++;
        return digits;
    }
    }