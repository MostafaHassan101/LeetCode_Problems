#include <bits/stdc++.h>
using namespace std;

class Solution {

int time_hh(string s){
    int h =(int) s[0] - 48;
    int h1=(int) s[1] - 48;
    return (h*10+h1);
}
int time_mm(string s){
    int m =(int) s[3] - 48;
    int m1=(int) s[4] - 48;
    return (m*10+m1);
}
public:
    bool haveConflict(vector<string>& event1, vector<string>& event2) {
    
    string ev1s=*event1.begin();
    string ev1e=*(event1.begin()+1);
    string ev2s=*event2.begin();
    string ev2e=*(event2.begin()+1);
        
    int t_ev1s = time_hh(ev1s)*60 + time_mm(ev1s);
    int t_ev1e = time_hh(ev1e)*60 + time_mm(ev1e);
    int t_ev2s = time_hh(ev2s)*60 + time_mm(ev2s);
    int t_ev2e = time_hh(ev2e)*60 + time_mm(ev2e);
        
    if(t_ev2s > t_ev1s)
    {
        if(t_ev2s > t_ev1e) return false;
    }
    else
    {
      if(t_ev1s > t_ev2e) return false;       
    }
        
    return true;
    }
};
int main(){

// test Solution
    // ["00:00","01:00"]
    vector<string>event1;
    event1.push_back("00:00");
    event1.push_back("01:00");

    // ["01:01","01:30"]
    vector<string>event2;
    event2.push_back("01:01");
    event2.push_back("01:30");

    Solution test;
    cout<<test.haveConflict(event1, event2);
    
    return 0;
}