using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  ModelPrimitiveType float float float Single
    // 000 MinValue                                 float IL2CPP_TYPE_R4
    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 000 MaxValue                                 float IL2CPP_TYPE_R4
    // 000 PositiveInfinity                         float IL2CPP_TYPE_R4
    // 000 NegativeInfinity                         float IL2CPP_TYPE_R4
    // 000 NaN                                      float IL2CPP_TYPE_R4
    // 000 NegativeZero                             float IL2CPP_TYPE_R4
    public partial class Single : DataModel
    {
        public float                                    M_value                                 { get; set; }

        public static Single? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Single() { Pointer= p0 };

            value.M_value                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_value                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
