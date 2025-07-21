using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SpringPower                              ModelPrimitiveType float float float Single
    // 014 LimitDistance                            ModelPrimitiveType float float float Single
    // 018 NormalLimitRatio                         ModelPrimitiveType float float float Single
    // 01C SpringNoise                              ModelPrimitiveType float float float Single
    public partial class SpringConstraintParams : DataModel
    {
        public float                                    SpringPower                             { get; set; }
        public float                                    LimitDistance                           { get; set; }
        public float                                    NormalLimitRatio                        { get; set; }
        public float                                    SpringNoise                             { get; set; }

        public static SpringConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpringConstraintParams() { Pointer= p0 };

            value.SpringPower                               = GetSingle(new IntPtr(p + 0x010)); // 0x10 SpringPower                 ( ModelPrimitiveType float float float Single )
            value.LimitDistance                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 LimitDistance               ( ModelPrimitiveType float float float Single )
            value.NormalLimitRatio                          = GetSingle(new IntPtr(p + 0x018)); // 0x18 NormalLimitRatio            ( ModelPrimitiveType float float float Single )
            value.SpringNoise                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SpringNoise                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
