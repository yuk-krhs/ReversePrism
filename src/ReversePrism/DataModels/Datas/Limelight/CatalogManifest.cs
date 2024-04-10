using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Checksum                                 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Seed                                     00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Size                                     00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 NameCrc                                  00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
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

            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x010)); // 02466B56CB90 0x10 Checksum                    ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x018)); // 02466B56CBB0 0x18 Seed                        ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x020)); // 02466B56CBD0 0x20 Size                        ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NameCrc                                   = GetUInt64(new IntPtr(p + 0x028)); // 02466B56CBF0 0x28 NameCrc                     ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
