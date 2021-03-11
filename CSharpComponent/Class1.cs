using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpComponent
{
    public interface Interface1
    {
        void f();
    }
    public interface Interface2
    {
        void g();
    }
    public sealed class Class1 : Interface1, Interface2
    {
        public void f() { }
        public void g() { }
    }
}
