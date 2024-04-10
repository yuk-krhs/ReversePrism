using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Bits                                     0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class UTF8Decoder : DataModel
    {
        public int                                      Bits                                    { get; set; }

        public static UTF8Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF8Decoder() { Pointer= p0 };

            value.Bits                                      = GetInt32(new IntPtr(p + 0x030)); // 0245A33E6DF8 0x30 Bits                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
