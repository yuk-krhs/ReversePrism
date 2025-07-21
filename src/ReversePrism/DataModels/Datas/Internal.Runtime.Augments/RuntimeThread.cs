using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OptimalMaxSpinWaitsPerSpinIteration      int IL2CPP_TYPE_I4
    // 010 Thread                                   ModelClassType Thread Thread Thread Pointer
    public partial class RuntimeThread : DataModel
    {
        public Thread?                                  Thread                                  { get; set; }

        public static RuntimeThread? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeThread() { Pointer= p0 };

            value.Thread                                    = GetObject<Thread>(new IntPtr(p + 0x010), ReversePrism.DataModels.Thread.FromPointer); // 0x10 Thread                      ( ModelClassType Thread Thread Thread Pointer )

            return value;
        }
    }
}
