using System;

namespace Loop{
    class program{
        static void Main(String[] args){
            int n = 0;
            float s = 1; 
            float x = 0;
            float giaiThua = 1;
            float luyThua = 1;

            Console.WriteLine("Tinh tong S = 1 + 1!/X + 2!/X^2 + … + N!/X^N");
            Console.WriteLine("n = "); n = Console.nextInt();
            Console.WriteLine("x = "); x = Console.nextFloat();

            if(x != 0){
                for (int i = 1; i <= n; i++){
                    giaiThua = giaiThua*i;
                    luyThua = luyThua*x;
                    s = s + giaiThua/luyThua;                       
                }
                Console.WriteLine("Tong S = " + s);
            }

            if(x == 0 && n == 0){
                Console.WriteLine("S = 1");
            }
            
            else{
                Console.WriteLine("Khong xac dinh tong S");
            }
        }
    }
}

/*  Write a program that, for a given two integer numbers N and X, 
    calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N 
    */