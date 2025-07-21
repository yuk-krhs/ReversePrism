using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Major                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Minor                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Build                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Revision                                 ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Major                                     = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Major                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minor                                     = GetUInt16(new IntPtr(p + 0x012)); // 0x12 Minor                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Build                                     = GetUInt16(new IntPtr(p + 0x014)); // 0x14 Build                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Revision                                  = GetUInt16(new IntPtr(p + 0x016)); // 0x16 Revision                    ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
