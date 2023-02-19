using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. 수중에 100원을 가지고 있는 것으로 시작한다.
            int MyMoney = 1000000;

            //4. 통장 클래스를 가지고 2개의 인스턴트를 만든다
            Bank Abank = new Bank();
            Bank Bbank = new Bank();

            //6. Main에서 선택지를 띄운다. While문을 이용해서 특정키가 들어올때까지 계속 반복한다.
            // 선택지는 1. 입금 2. 출금 3. 이체 3개가 있다.
            // 여기서 선택지는 항상 A통장 기준이다.
           

            while (true)
            {
                Console.WriteLine("무엇을 하시겠습니까?");
                Console.WriteLine("1. 입금");
                Console.WriteLine("2. 출금");
                Console.WriteLine("3. 이체");
                string select = Console.ReadLine();
                int select1 = Convert.ToInt32(select);
                switch (select1)
                {
                    case 1:
                        Console.WriteLine("입금할 금액을 입력하세요.");
                        int PutMoneyCount = int.Parse(Console.ReadLine());
                        Abank.PutMoney(PutMoneyCount);
                        MyMoney = MyMoney - PutMoneyCount;
                        Console.WriteLine($"잔액은 {MyMoney}원 입니다.");
                        break;
                    case 2:
                        Console.WriteLine("출금할 금액을 입력하세요.");
                        int TakeMoneyCount = int.Parse(Console.ReadLine());
                        Abank.TakeMoney(TakeMoneyCount);
                        MyMoney = MyMoney + TakeMoneyCount;
                        Console.WriteLine($"잔액은 {MyMoney}원 입니다.");
                        break;
                    case 3:
                        Console.WriteLine("이체할 금액을 입력하세요.");
                        int TransMoneyCount = int.Parse(Console.ReadLine());
                        Abank.TransMoney1(TransMoneyCount);
                        Bbank.TransMoney2(TransMoneyCount);

                        break;
                }



                //7. 입금을 선택하고 금액을 입력하면, 수중의 돈이 줄어들고 A통장은 금액이 추가된다.
                //8. 출금을 선택하고 금액을 입력하면, 수증의 돈이 추가되고 A통장은 금액이 줄어든다.
                //9. 이체를 선택하고 금액을 입력하면, A통장의 금액이 줄어들고, B통장의 금액이 늘어난다.
                //10. A통장과 B통장의 잔액을 출력한다.

            }
        }
        //1. 통장클래스 제작
        class Bank
        {
            //2. 본 통장 클래스에는 잔고(int)가 있음.
            public int bankmoney;
            public int bankmoney2;

            //3. 입금 / 출금 / 이체 메소드를 보유하고 있다.
            public void PutMoney(int PutMoney)
            {
                bankmoney = bankmoney + PutMoney;
                Console.WriteLine($"A통장의 잔액은 {bankmoney}원 입니다.");
            }

            public void TakeMoney(int TakeMoney)
            {
                bankmoney = bankmoney - TakeMoney;
                Console.WriteLine($"A통장의 잔액은 {bankmoney}원 입니다.");
            }

            public void TransMoney1(int TransMoney)
            {
                bankmoney = bankmoney - TransMoney;
                Console.WriteLine($"A통장의 잔액은 {bankmoney}원 입니다.");
            }
            public void TransMoney2(int TransMoney)
            {
                bankmoney2 = bankmoney2 + TransMoney;
                Console.WriteLine($"B통장의 잔액은 {bankmoney2}원 입니다.");
            }

        }
    }
}
