using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SpinCountforSpinBeforeWait               int IL2CPP_TYPE_I4
    // 010 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SpinWait : DataModel
    {
        public int                                      Count                                   { get; set; }

        public static SpinWait? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpinWait() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A3EFFA98 0x10 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
