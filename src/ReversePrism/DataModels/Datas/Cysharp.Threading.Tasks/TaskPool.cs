using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxPoolSize                              int IL2CPP_TYPE_I4
    // 008 sizes                                    Dictionary`2<Type, Func`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class TaskPool
    {

        public static TaskPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskPool();


            return value;
        }
    }
}
