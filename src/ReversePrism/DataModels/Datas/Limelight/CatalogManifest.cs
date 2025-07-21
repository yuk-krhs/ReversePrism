using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Checksum                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Seed                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Size                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 028 NameCrc                                  ModelPrimitiveType ulong ulong ulong UInt64
    public partial class CatalogManifest : DataModel
    {
        public ulong                                    Checksum                                { get; set; }
        public ulong                                    Seed                                    { get; set; }
        public ulong                                    Size                                    { get; set; }
        public ulong                                    NameCrc                                 { get; set; }

        public static CatalogManifest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogManifest() { Pointer= p0 };

            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Checksum                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Seed                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NameCrc                                   = GetUInt64(new IntPtr(p + 0x028)); // 0x28 NameCrc                     ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
