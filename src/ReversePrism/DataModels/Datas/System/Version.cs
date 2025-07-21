using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    ModelPrimitiveType int int int Int32
    // 014 Minor                                    ModelPrimitiveType int int int Int32
    // 018 Build                                    ModelPrimitiveType int int int Int32
    // 01C Revision                                 ModelPrimitiveType int int int Int32
    public partial class Version : DataModel
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
            var value   = new Version() { Pointer= p0 };

            value.Major                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Major                       ( ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Minor                       ( ModelPrimitiveType int int int Int32 )
            value.Build                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Build                       ( ModelPrimitiveType int int int Int32 )
            value.Revision                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Revision                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
