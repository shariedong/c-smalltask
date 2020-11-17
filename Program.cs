using System;

namespace smalltaskeric
{   
    class A 
        {
            private int _min;
            private int _max;
            private int num;
            public A (int a,int b)//类A定义一个有参的构造函数
            {
                _min = a;
                _max = b;
            }
            Random random_01=new Random();
            //max和min生成一个随机数赋值给num
            public int num1 => random_01.Next(_min,_max);   
            //num以属性的方式定义一个get方法来获得num的值
            //max和min生成一个随机数赋值给num
        }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please define a min number ");
            int minnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please define a max number ");
            int maxnumber = Convert.ToInt32(Console.ReadLine());

            var item = new A (minnumber,maxnumber);

            Console.WriteLine("please enter a guess number ");
            for(int i = 0; i <5; i++){
                int guessnumber = Convert.ToInt32(Console.ReadLine());
                if (guessnumber.Equals(Convert.ToInt32(item.num1))) {
                    break;
                }
            }

        }
    }



}
