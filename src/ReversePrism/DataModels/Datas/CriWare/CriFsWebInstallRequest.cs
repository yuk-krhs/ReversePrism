using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Installer                                000186653850 ModelClassType CriFsWebInstaller CriFsWebInstaller CriFsWebInstaller Pointer
    // 060 Crc32                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 064 Crc32_set                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriFsWebInstallRequest : DataModel
    {
        public CriFsWebInstaller?                       Installer                               { get; set; }
        public uint                                     Crc32                                   { get; set; }
        public bool                                     Crc32_set                               { get; set; }

        public static CriFsWebInstallRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsWebInstallRequest() { Pointer= p0 };

            value.Installer                                 = GetObject<CriFsWebInstaller>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriFsWebInstaller.FromPointer); // 02466AD1E788 0x58 Installer                   ( 000186653850 ModelClassType CriFsWebInstaller CriFsWebInstaller CriFsWebInstaller Pointer )
            value.Crc32                                     = GetUInt32(new IntPtr(p + 0x060)); // 02466AD1E7A8 0x60 Crc32                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Crc32_set                                 = GetBool(new IntPtr(p + 0x064)); // 02466AD1E7C8 0x64 Crc32_set                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
