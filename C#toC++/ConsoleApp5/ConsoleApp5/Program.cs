using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Name
        {
            public int age;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string FirstName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string LastName;
            public int age2;
        };

        [DllImport("TestDll.dll")]
        public static extern void GetName(ref Name name);

        [DllImport("TestDll.dll")]
        public static extern void SetName(Name name);


        [DllImport("TestDll.dll")]
        public static extern void Hello();

        static void Main(string[] args)
        {
            Hello();
            var name = new Name();
            var name2 = new Name();
            GetName(ref name);
            name2.FirstName = "koby";
            name2.LastName = "levi";
            name2.age = 10;
            name2.age2 = 20;
            SetName(name2);
            Console.WriteLine(name.FirstName);

        }
    }
}

