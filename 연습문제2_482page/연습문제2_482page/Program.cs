using System;

namespace 연습문제2_482page
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;
        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class Program
    {
        static public void Congratulation(int number)
        {
            Console.WriteLine("축하합니다! " + number +"번째 고객 이벤트에 당첨되셨습니다.");
        }

        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(Congratulation);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);
        }
    }
}