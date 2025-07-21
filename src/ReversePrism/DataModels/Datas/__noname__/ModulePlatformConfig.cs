using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class ModulePlatformConfig : DataModel
    {
        public sbyte                                    Reserved                                { get; set; }

        public static ModulePlatformConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModulePlatformConfig() { Pointer= p0 };

            value.Reserved                                  = GetSByte(new IntPtr(p + 0x010)); // 0x10 Reserved                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
