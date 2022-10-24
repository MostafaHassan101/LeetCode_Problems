#include <bits/stdc++.h>
using namespace std;

long long sum = 1;
long long recur( int n)
{   
    // Base Cases
    if(n==1) return 1;
    
    //Logic
    // sum *= n ;
    //recall function
    // recur(n-1);
// return sum;
return n*recur(n-1);
}

int main(){
    int n=4;
    long long sum=0;
    cout<<__LONG_LONG_MAX__<<endl;
    cout<<recur(n);
    for (int i=0; i<=n; i++)
    sum+=i;

    cout<<endl<<sum;

return 0;
}