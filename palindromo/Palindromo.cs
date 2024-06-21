using System;

namespace palindromo{

    public static class Palindromo{
        public static bool Show(int x){
            if(x<0){
                Console.WriteLine($"It's not a palindrome: {x}");
                return false;
            }
            string a = x.ToString();
            int b = a.Length;
            string c = "";
            for (int i = b;i>0;i--){
                c += a.Substring(i-1, 1);
            }
            if (a.Equals(c)){
                Console.WriteLine($"Perfect palindrome: {x}");
                return true;
            }
            else{
                Console.WriteLine($"It's not a palindrome: {x}");
                return false;
            }
        }
    }

}
