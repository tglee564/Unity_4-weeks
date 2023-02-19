using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTestClassFirst InterfaceFirst = new InterfaceTestClassFirst();
            InterfaceFirst.TestInterfaceMethod();

            InterfaceTestClassSecond InterfaceSecond = new InterfaceTestClassSecond();
            InterfaceFirst.TestInterfaceMethod();

        }
        
        interface IInterfaceTest
        {
            void TestInterfaceMethod();
        }

        class InterfaceTestClassFirst : IInterfaceTest
        {
            public void TestInterfaceMethod()
            {
                System.Console.WriteLine("Hello");
            }
        }
        class InterfaceTestClassSecond : IInterfaceTest
        {
            public void TestInterfaceMethod()
            {
                System.Console.WriteLine("Hi!!");
            }
        }
    }
}
