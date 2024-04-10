using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WarningTemp                              0001866656B0 ModelPrimitiveType float float float Single
    // 014 ThrottlingTemp                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class ThermalStateTracker : DataModel
    {
        public float                                    WarningTemp                             { get; set; }
        public float                                    ThrottlingTemp                          { get; set; }

        public static ThermalStateTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThermalStateTracker() { Pointer= p0 };

            value.WarningTemp                               = GetSingle(new IntPtr(p + 0x010)); // 02466B6F2640 0x10 WarningTemp                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ThrottlingTemp                            = GetSingle(new IntPtr(p + 0x014)); // 02466B6F2660 0x14 ThrottlingTemp              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
