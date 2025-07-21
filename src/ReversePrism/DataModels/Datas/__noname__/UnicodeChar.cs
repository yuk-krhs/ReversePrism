using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unicode                                  ModelPrimitiveType int int int Int32
    // 014 StringIndex                              ModelPrimitiveType int int int Int32
    // 018 Length                                   ModelPrimitiveType int int int Int32
    public partial class UnicodeChar : DataModel
    {
        public int                                      Unicode                                 { get; set; }
        public int                                      StringIndex                             { get; set; }
        public int                                      Length                                  { get; set; }

        public static UnicodeChar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnicodeChar() { Pointer= p0 };

            value.Unicode                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Unicode                     ( ModelPrimitiveType int int int Int32 )
            value.StringIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 StringIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
