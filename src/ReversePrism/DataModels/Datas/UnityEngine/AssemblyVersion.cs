using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Minor                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Build                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Revision                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class AssemblyVersion : DataModel
    {
        public ushort                                   Major                                   { get; set; }
        public ushort                                   Minor                                   { get; set; }
        public ushort                                   Build                                   { get; set; }
        public ushort                                   Revision                                { get; set; }

        public static AssemblyVersion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyVersion() { Pointer= p0 };

            value.Major                                     = GetUInt16(new IntPtr(p + 0x010)); // 0245A2321138 0x10 Major                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minor                                     = GetUInt16(new IntPtr(p + 0x012)); // 0245A2321158 0x12 Minor                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Build                                     = GetUInt16(new IntPtr(p + 0x014)); // 0245A2321178 0x14 Build                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Revision                                  = GetUInt16(new IntPtr(p + 0x016)); // 0245A2321198 0x16 Revision                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
