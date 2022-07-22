using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Reserch
{
    public class ReadonlyRefVsReadonlyValTypes
    {
        public class TestRefClass
        {
            public TestRefClass(int i, string s)
            {
                IVal = i;
                SVal = s;
            }
            public int IVal;
            public string SVal;
            public override string ToString()
            {
                return $"[IVal - {IVal};SVal - {SVal}]";
            }
        }
        public class Ref
        {
            public Ref()
            {
                IValVar = 1;
                iVal = 1;
                SValVar = "1";
                sVal = "1";
                RValVar = new TestRefClass(1, "1");
                rVal = new TestRefClass(1, "1");
            }
            public int IValVar;
            public void SetIValVar(int i) => IValVar = i;

            private int iVal;
            public int IValProp { get => iVal; set => iVal = value; }
            public void SetIValProp(int i) => IValProp = i;
            public void SetIVal(int i) => iVal = i;

            public string SValVar;
            public void SetSValVar(string s) => SValVar = s;

            private string sVal;
            public string SValProp { get => sVal; set => sVal = value; }
            public void SetSValProp(string s) => SValProp = s;
            public void SetSVal(string s) => sVal = s;

            public TestRefClass RValVar;
            public void SetRValVar(TestRefClass r) => RValVar = r;

            private TestRefClass rVal;
            public TestRefClass RValProp { get => rVal; set => rVal = value; }
            public void SetRValProp(TestRefClass r) => RValProp = r;
            public void SetRVal(TestRefClass r) => rVal = r;
        }
        public struct Val
        {
            public Val()
            {
                IValVar = 1;
                iVal = 1;
                SValVar = "1";
                sVal = "1";
                RValVar = new TestRefClass(1, "1");
                rVal = new TestRefClass(1, "1");
            }
            public int IValVar;
            public void SetIValVar(int i) => IValVar = i;

            private int iVal;
            public int IValProp { get => iVal; set => iVal = value; }
            public void SetIValProp(int i) => IValProp = i;
            public void SetIVal(int i) => iVal = i;

            public string SValVar;
            public void SetSValVar(string s) => SValVar = s;

            private string sVal;
            public string SValProp { get => sVal; set => sVal = value; }
            public void SetSValProp(string s) => SValProp = s;
            public void SetSVal(string s) => sVal = s;

            public TestRefClass RValVar;
            public void SetRValVar(TestRefClass r) => RValVar = r;

            private TestRefClass rVal;
            public TestRefClass RValProp { get => rVal; set => rVal = value; }
            public void SetRValProp(TestRefClass r) => RValProp = r;
            public void SetRVal(TestRefClass r) => rVal = r;
        }
        public readonly Ref rr = new Ref();
        public readonly Val rv = new Val();
        public void Test()
        {
            Console.WriteLine("Readonly reference type:");
            Console.WriteLine("I:");
            rr.IValVar = 2;
            Console.WriteLine($"IValVar:{rr.IValVar}");
            rr.SetIValVar(3);
            Console.WriteLine($"IValVar:{rr.IValVar}");
            rr.IValProp = 2;
            Console.WriteLine($"IValProp:{rr.IValProp}");
            rr.SetIVal(3);
            Console.WriteLine($"IValProp:{rr.IValProp}");
            rr.SetIValProp(4);
            Console.WriteLine($"IValProp:{rr.IValProp}");

            Console.WriteLine("R:");
            rr.RValVar = new TestRefClass(2, "2");
            Console.WriteLine($"RValVar:{rr.RValVar}");
            rr.SetRValVar(new TestRefClass(3, "3"));
            Console.WriteLine($"RValVar:{rr.RValVar}");
            rr.RValProp = new TestRefClass(2, "2");
            Console.WriteLine($"RValProp:{rr.RValProp}");
            rr.SetRVal(new TestRefClass(3, "3"));
            Console.WriteLine($"RValProp:{rr.RValProp}");
            rr.SetRValProp(new TestRefClass(4, "4"));
            Console.WriteLine($"RValProp:{rr.RValProp}");

            Console.WriteLine("S:");
            rr.SetSValVar("2");
            Console.WriteLine($"SValVar:{rr.SValVar}");
            rr.SValVar = "3";
            Console.WriteLine($"SValVar:{rr.SValVar}");
            rr.SetSVal("2");
            Console.WriteLine($"SValProp:{rr.SValProp}");
            rr.SetSValProp("3");
            Console.WriteLine($"SValProp:{rr.SValProp}");
            rr.SValProp = "4";
            Console.WriteLine($"SValProp:{rr.SValProp}");

            Console.WriteLine("Readonly value type:");
            Console.WriteLine("I:");
            //rv.IValVar = 2; // impossible
            //Console.WriteLine($"IValVar:{rv.IValVar}");
            rv.SetIValVar(3);
            Console.WriteLine($"IValVar:{rv.IValVar}");
            //rv.IValProp = 2; // impossible
            //Console.WriteLine($"IValProp:{rv.IValProp}");
            rv.SetIVal(3);
            Console.WriteLine($"IValProp:{rv.IValProp}");
            rv.SetIValProp(4);
            Console.WriteLine($"IValProp:{rv.IValProp}");

            Console.WriteLine("R:");
            //rv.RValVar = new TestRefClass(2, "2"); // impossible
            //Console.WriteLine($"RValVar:{rv.RValVar}");
            rv.RValVar.IVal = 2;
            rv.RValVar.SVal = "2";
            Console.WriteLine($"RValVar:{rv.RValVar}");
            rv.SetRValVar(new TestRefClass(3, "3"));
            Console.WriteLine($"RValVar:{rv.RValVar}");
            //rv.RValProp = new TestRefClass(2, "2"); // impossible
            //Console.WriteLine($"RValProp:{rv.RValProp}");
            rv.RValProp.IVal = 2;
            rv.RValProp.SVal = "2";
            Console.WriteLine($"RValVar:{rv.RValProp}");
            rv.SetRVal(new TestRefClass(3, "3"));
            Console.WriteLine($"RValProp:{rv.RValProp}");
            rv.SetRValProp(new TestRefClass(4, "4"));
            Console.WriteLine($"RValProp:{rv.RValProp}");
            

            Console.WriteLine("S:");
            rv.SetSValVar("2");
            Console.WriteLine($"SValVar:{rv.SValVar}");
            //rv.SValVar = "3";// impossible
            //Console.WriteLine($"SValVar:{rv.SValVar}");
            rv.SetSVal("2");
            Console.WriteLine($"SValProp:{rv.SValProp}");
            rv.SetSValProp("3");
            Console.WriteLine($"SValProp:{rv.SValProp}");
            //rv.SValProp = "4"; impossible
            //Console.WriteLine($"SValProp:{rv.SValProp}");
        }
    }
}
