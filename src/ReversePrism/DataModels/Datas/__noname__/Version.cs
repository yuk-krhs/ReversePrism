using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Minor                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Patch                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Version
    {
        public int                                      Major                                   { get; set; }
        public int                                      Minor                                   { get; set; }
        public int                                      Patch                                   { get; set; }

        public static Version? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Version();

            value.Major                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DBF14468 0x10 Major                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x014)); // 0270DBF14488 0x14 Minor                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Patch                                     = GetInt32(new IntPtr(p + 0x018)); // 0270DBF144A8 0x18 Patch                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
