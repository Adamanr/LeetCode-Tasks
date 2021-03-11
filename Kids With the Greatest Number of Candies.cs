public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {        
        bool[] aqua = new bool[candies.Length];
        int z = candies.Max();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= z)
            {
                aqua[i] = true;
            }
            else
            {
                aqua[i] = false;
            }
        }
        return aqua;
    }
}
