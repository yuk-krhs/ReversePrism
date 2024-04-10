using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dress                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Hairstyle                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Glasses                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Earrings                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Makeup                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class IdolCostumeId : DataModel
    {
        public int                                      Dress                                   { get; set; }
        public int                                      Hairstyle                               { get; set; }
        public int                                      Glasses                                 { get; set; }
        public int                                      Earrings                                { get; set; }
        public int                                      Makeup                                  { get; set; }

        public static IdolCostumeId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolCostumeId() { Pointer= p0 };

            value.Dress                                     = GetInt32(new IntPtr(p + 0x010)); // 024665157E40 0x10 Dress                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Hairstyle                                 = GetInt32(new IntPtr(p + 0x014)); // 024665157E60 0x14 Hairstyle                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Glasses                                   = GetInt32(new IntPtr(p + 0x018)); // 024665157E80 0x18 Glasses                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Earrings                                  = GetInt32(new IntPtr(p + 0x01C)); // 024665157EA0 0x1C Earrings                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Makeup                                    = GetInt32(new IntPtr(p + 0x020)); // 024665157EC0 0x20 Makeup                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
