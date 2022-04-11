using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Abserver
{
    public class Base {
        protected String _name = "";
        public bool Update() {
            Console.WriteLine("Object of Class {0} recieved message! ", _name);
            return true;
        }

        public String GetName() {
            return _name;
        }
    }
    public class A : Base{
        public A() { _name = "A"; }
    }
    public class B : Base {
        public B() { _name = "B"; }
    }
    public class C : Base {
        public C() { _name = "C"; }
    }


    public class Countdown { 
        private List<Base> subs = new List<Base>();

        public Countdown AddObserver(Base obj)
        {
            subs.Add(obj);
            Console.WriteLine("{0} has been added! ", obj.GetName() != "" ?  obj.GetName() : "null");
            return this;
        }
        public bool RemoveObserver(Base obj)
        {
            subs.Remove(obj);
            return true;
        }
        public bool Notify()
        {
            Console.WriteLine("Msg has been sent!");
            foreach (Base i in subs)
                if(!i.Update()) return false ;
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int delay = 1000;
            Countdown countdown = new Countdown();
            Console.WriteLine("Enter delay of sending the msg!");
            delay = int.Parse(Console.ReadLine());
            Console.WriteLine("Delay is {0} seconds!", delay / 1000);
            A a = new A();
            B b = new B();
            C c = new C();
            countdown.AddObserver(a).AddObserver(b).AddObserver(c);
            while (true) {
                Console.WriteLine();
                Thread.Sleep(delay);
                countdown.Notify();

            }
            Console.ReadLine();
        }
    }
}
