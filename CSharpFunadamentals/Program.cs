using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpFunadamentals
{
    public class Program
    {
        //void returns nothing 
        //public means it can be accessed fom anywhere
        //methods can not go inside the main method block
        //anything outside the main method will not be executed unless it is being called in the main method
        
        static void Main(string[] args)
        {

            Program toGetData = new Program();
            toGetData.getData();

            Program getClass2 = new Program();
            getClass2.getData2;

            Console.ReadLine();
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        }
        public class class1 : Program
        {
            
        }
    }
}
