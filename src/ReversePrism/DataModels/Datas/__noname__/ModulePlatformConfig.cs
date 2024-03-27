using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class ModulePlatformConfig
    {
        public sbyte                                    Reserved                                { get; set; }

        public static ModulePlatformConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModulePlatformConfig();

            value.Reserved                                  = GetSByte(new IntPtr(p + 0x010)); // 0270DACBD638 0x10 Reserved                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
