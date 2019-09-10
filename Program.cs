using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            child ch = new child();
            ch.message();
            ch.messageTest();
            Console.ReadKey();
        }
    }    
    public interface Ibase1
    {
        void message();  
    }
    public interface Ibase2
    {
        void messageTest();
    }
    public class child : Ibase1, Ibase2
    {
        public void message()
        {
            Console.WriteLine("Hello Multiple Inheritance");
        }
        public void messageTest()
        {
            Console.WriteLine("Hello Multiple Inheritance Testing");
        }
    }
}
        
    

