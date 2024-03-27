using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_activeTasks                            LowLevelDictionary`2<int, Task> IL2CPP_TYPE_GENERICINST
    // 008 s_activeTasksLock                        <object> IL2CPP_TYPE_OBJECT
    public partial class DebuggerSupport
    {

        public static DebuggerSupport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggerSupport();


            return value;
        }
    }
}
