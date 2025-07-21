using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BigEndian                                ModelPrimitiveType bool bool bool Bool
    // 024 LastByte                                 ModelPrimitiveType int int int Int32
    public partial class UTF16Decoder : DataModel
    {
        public bool                                     BigEndian                               { get; set; }
        public int                                      LastByte                                { get; set; }

        public static UTF16Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF16Decoder() { Pointer= p0 };

            value.BigEndian                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 BigEndian                   ( ModelPrimitiveType bool bool bool Bool )
            value.LastByte                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 LastByte                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
