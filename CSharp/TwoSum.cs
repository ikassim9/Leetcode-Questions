/* Given an Array find two numbers that add up to target.
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1]
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
   List<int> sum = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    
                        if (nums[i] + nums[j] == target)
                        {
                            sum.Add(i);


                            sum.Add(j);
                        }
                    
                }
            }


                    return sum.ToArray();
                }
            
        }
  
