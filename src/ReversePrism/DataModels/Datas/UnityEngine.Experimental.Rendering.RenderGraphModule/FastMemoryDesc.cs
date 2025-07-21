using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InFastMemory                             ModelPrimitiveType bool bool bool Bool
    // 014 Flags                                    ModelEnumType FastMemoryFlags FastMemoryFlags FastMemoryFlags Int32
    // 018 ResidencyFraction                        ModelPrimitiveType float float float Single
    public partial class FastMemoryDesc : DataModel
    {
        public bool                                     InFastMemory                            { get; set; }
        public FastMemoryFlags                          Flags                                   { get; set; }
        public float                                    ResidencyFraction                       { get; set; }

        public static FastMemoryDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastMemoryDesc() { Pointer= p0 };

            value.InFastMemory                              = GetBool(new IntPtr(p + 0x010)); // 0x10 InFastMemory                ( ModelPrimitiveType bool bool bool Bool )
            value.Flags                                     = (FastMemoryFlags)GetInt32(new IntPtr(p + 0x014)); // 0x14 Flags                       ( ModelEnumType FastMemoryFlags FastMemoryFlags FastMemoryFlags Int32 )
            value.ResidencyFraction                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 ResidencyFraction           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
