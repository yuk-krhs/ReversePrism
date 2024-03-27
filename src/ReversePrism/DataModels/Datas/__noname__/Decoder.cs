using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 LastByte                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 034 lastChar                                 char IL2CPP_TYPE_CHAR
    public partial class Decoder
    {
        public int                                      LastByte                                { get; set; }

        public static Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Decoder();

            value.LastByte                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D6B65CE0 0x30 LastByte                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
