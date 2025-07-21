using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Frequency                                ModelPrimitiveType float float float Single
    // 014 Amplitude                                ModelPrimitiveType float float float Single
    // 018 Constant                                 ModelPrimitiveType bool bool bool Bool
    public partial class NoiseParams : DataModel
    {
        public float                                    Frequency                               { get; set; }
        public float                                    Amplitude                               { get; set; }
        public bool                                     Constant                                { get; set; }

        public static NoiseParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoiseParams() { Pointer= p0 };

            value.Frequency                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 Frequency                   ( ModelPrimitiveType float float float Single )
            value.Amplitude                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 Amplitude                   ( ModelPrimitiveType float float float Single )
            value.Constant                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Constant                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
