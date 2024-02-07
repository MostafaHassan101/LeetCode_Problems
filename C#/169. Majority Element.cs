// 169. Majority Element
public class Solution {
    public int MajorityElement(int[] nums) {
        int r = 0, n = nums.Length;
        if(n <= 2) return nums[0];
        
        Array.Sort(nums);
        for(int i = 1 ; i < n; i++){
            if(nums[i-1] == nums[i])
                r++;
            if(n/2 == r) return nums[i];
        }
        return -1;
    }
}

public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int candidate = 0;
        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
    }
}

// other Solution 

public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}

// other Solution

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map.Add(num, 1);
            } else {
                map[num]++;
            }
            if (map[num] > nums.Length / 2) {
                return num;
            }
        }
        return -1;
    }
}