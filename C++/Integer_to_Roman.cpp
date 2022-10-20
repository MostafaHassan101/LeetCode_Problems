 #include <iostream>

 using namespace std;
  
  int main()
  {
    int n=3999;
    string ans="";
    while (n!=0){
    
        if(n>=1000)
        {
         ans+="M";
         n=n-1000;
        }
        if(n<1000 && n >= 500)
        {
            if(n>=900){
                ans+="CM";
                n=n-900;
            }
            else
            {
            ans+="D";
            n=n-500;
            }
        }
        if(n<500 && n >= 100)
        {
            if(n>=400)
            {
                ans+="CD";
                n=n-400;
            }
            else
            {
            ans+="C";
            n=n-100;
            }
        }
        if(n<100 && n >= 50)
        {
            if(n>=90)
            {
                ans+="XC";
                n=n-90;
            }
            else
            {
            ans+="L";
            n=n-50;
            }
        }
        if(n<50 && n >= 10)
        {
            if(n>=40)
            {
                ans+="XL";
                n=n-40;
            }
            else
            {
            ans+="X";
            n=n-10;
            }
        }
        if(n<10 && n >= 5)
        {
            if(n>=9)
            {
                ans+="IX";
                n=n-9;
            }
            else
            {
            ans+="V";
            n=n-5;
            }
        }
        if(n<5 && n >= 1)
        {
            if(n>=4)
            {
                ans+="IV";
                n=n-4;
            }
            else
            {
            ans+="I";
            n=n-1;
            }
        }
    }
    cout<<ans<<endl;
        
  return 0;
  }