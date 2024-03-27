using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InFastMemory                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Flags                                    000186558F20 ModelEnumType FastMemoryFlags FastMemoryFlags FastMemoryFlags Int32
    // 018 ResidencyFraction                        000186666050 ModelPrimitiveType float float float Single
    public partial class FastMemoryDesc
    {
        public bool                                     InFastMemory                            { get; set; }
        public FastMemoryFlags                          Flags                                   { get; set; }
        public float                                    ResidencyFraction                       { get; set; }

        public static FastMemoryDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastMemoryDesc();

            value.InFastMemory                              = GetBool(new IntPtr(p + 0x010)); // 0270D90B4468 0x10 InFastMemory                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Flags                                     = (FastMemoryFlags)GetInt32(new IntPtr(p + 0x014)); // 0270D90B4488 0x14 Flags                       ( 000186558F20 ModelEnumType FastMemoryFlags FastMemoryFlags FastMemoryFlags Int32 )
            value.ResidencyFraction                         = GetSingle(new IntPtr(p + 0x018)); // 0270D90B44A8 0x18 ResidencyFraction           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
