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
    public int[] PlusOneV2(int[] digits) {
        int count = digits.Length -1;
        for(count = digits.Length -1; count >= 0; count--) {
            if(count >= 0 && digits[count] == 9) {
                digits[count] = 0;
            } else {
            digits[count]++;
            break;
            }
        }
            if( count < 0) {
                Array.Resize(ref digits, digits.Length+1);
                count = 0;
                digits[count]++;
            }
            foreach(int i in digits) {
                Console.Write($" {i} ");
            }
            
            return digits;
    }
    }