class Solution:
    def containsNearbyDuplicate(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :return_type: bool
        """
        seen = {}
        for index, element in enumerate(nums):
            if element in seen and index - seen[element] <= k:
                return True
            seen[element] = index
        return False
    

# Test Cases
nums = [1,2,3,1]
k = 3
s = Solution()
print(s.containsNearbyDuplicate(nums, k))

nums = [1,0,1,1] 
k = 1
print(s.containsNearbyDuplicate(nums, k))

nums = [1,2,3,1,2,3] 
k = 2
print(s.containsNearbyDuplicate(nums, k))
