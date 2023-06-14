using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShadowingHidingPrac31
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        public static int number = 10;
        Expand All
	@@ -26,6 +34,9 @@ static void Main(string[] args)
            Console.WriteLine(child.variable);
            Parent p = child;
        Console.WriteLine(p.variable);

            child.Method();
            p.Method();
        }
}
}