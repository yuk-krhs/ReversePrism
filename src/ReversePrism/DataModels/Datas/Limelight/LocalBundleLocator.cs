using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstallDataRoot                          000186672F10 ModelPrimitiveType string string string String
    public partial class LocalBundleLocator : DataModel
    {
        public string                                   InstallDataRoot                         { get; set; }

        public static LocalBundleLocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalBundleLocator() { Pointer= p0 };

            value.InstallDataRoot                           = GetString(new IntPtr(p + 0x010)); // 0245A3E04AB8 0x10 InstallDataRoot             ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
