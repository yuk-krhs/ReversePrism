using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Caches                                   ImmutableReturnInt32Observable[] IL2CPP_TYPE_SZARRAY
    // 010 X                                        0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ImmutableReturnInt32Observable : DataModel
    {
        public int                                      X                                       { get; set; }

        public static ImmutableReturnInt32Observable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImmutableReturnInt32Observable() { Pointer= p0 };

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0246697945C8 0x10 X                           ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
