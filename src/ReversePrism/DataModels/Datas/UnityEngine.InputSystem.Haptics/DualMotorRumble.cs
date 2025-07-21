using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LowFrequencyMotorSpeed                   ModelPrimitiveType float float float Single
    // 014 HighFrequencyMotorSpeed                  ModelPrimitiveType float float float Single
    public partial class DualMotorRumble : DataModel
    {
        public float                                    LowFrequencyMotorSpeed                  { get; set; }
        public float                                    HighFrequencyMotorSpeed                 { get; set; }

        public static DualMotorRumble? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualMotorRumble() { Pointer= p0 };

            value.LowFrequencyMotorSpeed                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 LowFrequencyMotorSpeed      ( ModelPrimitiveType float float float Single )
            value.HighFrequencyMotorSpeed                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 HighFrequencyMotorSpeed     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
