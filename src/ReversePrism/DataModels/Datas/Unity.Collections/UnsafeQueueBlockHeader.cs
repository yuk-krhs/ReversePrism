using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_NextBlock                              IntPtr IL2CPP_TYPE_PTR
    // 018 M_NumItems                               ModelPrimitiveType int int int Int32
    public partial class UnsafeQueueBlockHeader : DataModel
    {
        public int                                      M_NumItems                              { get; set; }

        public static UnsafeQueueBlockHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeQueueBlockHeader() { Pointer= p0 };

            value.M_NumItems                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_NumItems                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
