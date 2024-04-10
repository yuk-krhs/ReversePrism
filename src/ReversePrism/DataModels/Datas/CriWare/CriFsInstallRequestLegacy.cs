using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Installer                                000186651610 ModelClassType CriFsInstaller CriFsInstaller CriFsInstaller Pointer
    public partial class CriFsInstallRequestLegacy : DataModel
    {
        public CriFsInstaller?                          Installer                               { get; set; }

        public static CriFsInstallRequestLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsInstallRequestLegacy() { Pointer= p0 };

            value.Installer                                 = GetObject<CriFsInstaller>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriFsInstaller.FromPointer); // 02466AD1E5B8 0x58 Installer                   ( 000186651610 ModelClassType CriFsInstaller CriFsInstaller CriFsInstaller Pointer )

            return value;
        }
    }
}
