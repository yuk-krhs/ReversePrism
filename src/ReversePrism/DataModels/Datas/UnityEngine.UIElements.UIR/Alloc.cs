using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Size                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 handle                                   <object> IL2CPP_TYPE_OBJECT
    // 020 ShortLived                               000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class Alloc
    {
        public uint                                     Start                                   { get; set; }
        public uint                                     Size                                    { get; set; }
        public bool                                     ShortLived                              { get; set; }

        public static Alloc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Alloc();

            value.Start                                     = GetUInt32(new IntPtr(p + 0x010)); // 0270066DFEF8 0x10 Start                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x014)); // 0270066DFF18 0x14 Size                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ShortLived                                = GetBool(new IntPtr(p + 0x020)); // 0270066DFF58 0x20 ShortLived                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
