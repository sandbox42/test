using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public interface IDependency1
    {
        object SomeObject { get; set; }
    }

    public interface IDependency2
    {
        object SomeObject { get; set; }
    }

    public class Dependency1
    {
        public object SomeObject { get; set; }
    }
       
    public class Dependency2
    {
        public object SomeObject { get; set; }
    }

    public class Main
    { }
}
