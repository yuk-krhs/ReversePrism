using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 IChar                                    ModelPrimitiveType int int int Int32
    // 034 ReadByteCount                            ModelPrimitiveType int int int Int32
    public partial class UTF32Decoder : DataModel
    {
        public int                                      IChar                                   { get; set; }
        public int                                      ReadByteCount                           { get; set; }

        public static UTF32Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF32Decoder() { Pointer= p0 };

            value.IChar                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 IChar                       ( ModelPrimitiveType int int int Int32 )
            value.ReadByteCount                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 ReadByteCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
