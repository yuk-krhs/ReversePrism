using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidHandle                            <int> IL2CPP_TYPE_I
    // 008 dump_handles                             bool IL2CPP_TYPE_BOOLEAN
    public partial class MonoIO : DataModel
    {

        public static MonoIO? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoIO() { Pointer= p0 };


            return value;
        }
    }
}
