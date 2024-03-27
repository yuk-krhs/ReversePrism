using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Value                                    000186666050 ModelPrimitiveType float float float Single
    public partial class AisacControl
    {
        public uint                                     Id                                      { get; set; }
        public float                                    Value                                   { get; set; }

        public static AisacControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacControl();

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 0270DAC6E538 0x10 Id                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 0270DAC6E558 0x14 Value                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
