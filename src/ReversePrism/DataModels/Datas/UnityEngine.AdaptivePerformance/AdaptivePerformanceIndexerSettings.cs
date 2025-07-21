using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_FeatureName                            string IL2CPP_TYPE_STRING
    // 010 M_Active                                 ModelPrimitiveType bool bool bool Bool
    // 014 M_ThermalActionDelay                     ModelPrimitiveType float float float Single
    // 018 M_PerformanceActionDelay                 ModelPrimitiveType float float float Single
    public partial class AdaptivePerformanceIndexerSettings : DataModel
    {
        public bool                                     M_Active                                { get; set; }
        public float                                    M_ThermalActionDelay                    { get; set; }
        public float                                    M_PerformanceActionDelay                { get; set; }

        public static AdaptivePerformanceIndexerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceIndexerSettings() { Pointer= p0 };

            value.M_Active                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 M_Active                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ThermalActionDelay                      = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_ThermalActionDelay        ( ModelPrimitiveType float float float Single )
            value.M_PerformanceActionDelay                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_PerformanceActionDelay    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
