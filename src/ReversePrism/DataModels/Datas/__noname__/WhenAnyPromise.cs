using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompletedCount                           ModelPrimitiveType int int int Int32
    // 018 core                                     UniTaskCompletionSourceCore`1<int> IL2CPP_TYPE_GENERICINST
    public partial class WhenAnyPromise : DataModel
    {
        public int                                      CompletedCount                          { get; set; }

        public static WhenAnyPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAnyPromise() { Pointer= p0 };

            value.CompletedCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 CompletedCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
