using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType ushort ushort ushort UInt16
    // 012 MaximumLength                            ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Buffer                                   <int> IL2CPP_TYPE_I
    public partial class UNICODE_STRING : DataModel
    {
        public ushort                                   Length                                  { get; set; }
        public ushort                                   MaximumLength                           { get; set; }

        public static UNICODE_STRING? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UNICODE_STRING() { Pointer= p0 };

            value.Length                                    = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.MaximumLength                             = GetUInt16(new IntPtr(p + 0x012)); // 0x12 MaximumLength               ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
