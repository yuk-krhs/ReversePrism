using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType uint uint uint UInt32
    // 014 Size                                     ModelPrimitiveType uint uint uint UInt32
    // 018 handle                                   <object> IL2CPP_TYPE_OBJECT
    // 020 ShortLived                               ModelPrimitiveType bool bool bool Bool
    public partial class Alloc : DataModel
    {
        public uint                                     Start                                   { get; set; }
        public uint                                     Size                                    { get; set; }
        public bool                                     ShortLived                              { get; set; }

        public static Alloc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Alloc() { Pointer= p0 };

            value.Start                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Size                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.ShortLived                                = GetBool(new IntPtr(p + 0x020)); // 0x20 ShortLived                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
