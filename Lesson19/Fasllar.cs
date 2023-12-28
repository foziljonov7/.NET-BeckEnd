using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19
{
    [Flags]
    public enum Fasllar
    {
        None = 0,
        Qish = 1,
        Bahor = 2,
        Yoz = 4,
        Kuz = Bahor | Yoz
    }
}
