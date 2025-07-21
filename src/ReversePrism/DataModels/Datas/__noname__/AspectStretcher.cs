using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Aspect                                   ModelPrimitiveType float float float Single
    // 014 M_InverseAspect                          ModelPrimitiveType float float float Single
    // 018 M_CenterX                                ModelPrimitiveType float float float Single
    public partial class AspectStretcher : DataModel
    {
        public float                                    Aspect                                  { get; set; }
        public float                                    M_InverseAspect                         { get; set; }
        public float                                    M_CenterX                               { get; set; }

        public static AspectStretcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AspectStretcher() { Pointer= p0 };

            value.Aspect                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 Aspect                      ( ModelPrimitiveType float float float Single )
            value.M_InverseAspect                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_InverseAspect             ( ModelPrimitiveType float float float Single )
            value.M_CenterX                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_CenterX                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
