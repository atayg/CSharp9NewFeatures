using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive._2InitOnlySetters
{
    public class InitOnlySetters
    {
        public string ReadOnlyProperty { get; }
        public string Property { get; init; }
    }
}
