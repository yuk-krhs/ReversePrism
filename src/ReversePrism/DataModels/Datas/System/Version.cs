using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Minor                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Build                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Revision                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Version
    {
        public int                                      Major                                   { get; set; }
        public int                                      Minor                                   { get; set; }
        public int                                      Build                                   { get; set; }
        public int                                      Revision                                { get; set; }

        public static Version? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Version();

            value.Major                                     = GetInt32(new IntPtr(p + 0x010)); // 027003F4AC48 0x10 Major                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x014)); // 027003F4AC68 0x14 Minor                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Build                                     = GetInt32(new IntPtr(p + 0x018)); // 027003F4AC88 0x18 Build                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Revision                                  = GetInt32(new IntPtr(p + 0x01C)); // 027003F4ACA8 0x1C Revision                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
