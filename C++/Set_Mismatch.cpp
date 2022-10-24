#include <bits/stdc++.h>
using namespace std;

class Solution {
public:
    vector<int> findErrorNums(vector<int>& nums) {  
    vector < int > ans;
    sort(nums.begin(),nums.end());
    int n =nums.size();
    int rep, loss, f , sum;
    sum=*(nums.end()-1);
    f=n*(n+1)/2;
        for(int  i= 0; i < n-1; i++)
        {
            sum+=nums[i];
           if(nums[i] == nums[i+1])
           {
                ans.insert(ans.begin(),nums[i]);
                rep=nums[i];
           }
        }
        loss = f - (sum - rep);
        ans.insert(ans.begin()+1,loss);
        return ans;
    }
};

int main()
{
// test solution
    vector<int>nums;
    nums.push_back(1);
    nums.push_back(2);
    nums.push_back(2);
    nums.push_back(4);

    Solution obj;
    vector<int> result=obj.findErrorNums(nums);
    for(int i= 0; i<result.size(); i++)
        cout<<result[i]<<' ';

    return 0;
}