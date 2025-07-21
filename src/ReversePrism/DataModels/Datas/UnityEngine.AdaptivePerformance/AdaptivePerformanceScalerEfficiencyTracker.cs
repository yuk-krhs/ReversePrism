using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Scaler                                 ModelClassType AdaptivePerformanceScaler AdaptivePerformanceScaler AdaptivePerformanceScaler Pointer
    // 018 M_LastAverageGpuFrameTime                ModelPrimitiveType float float float Single
    // 01C M_LastAverageCpuFrameTime                ModelPrimitiveType float float float Single
    // 020 M_IsApplied                              ModelPrimitiveType bool bool bool Bool
    public partial class AdaptivePerformanceScalerEfficiencyTracker : DataModel
    {
        public AdaptivePerformanceScaler?               M_Scaler                                { get; set; }
        public float                                    M_LastAverageGpuFrameTime               { get; set; }
        public float                                    M_LastAverageCpuFrameTime               { get; set; }
        public bool                                     M_IsApplied                             { get; set; }

        public static AdaptivePerformanceScalerEfficiencyTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceScalerEfficiencyTracker() { Pointer= p0 };

            value.M_Scaler                                  = GetObject<AdaptivePerformanceScaler>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdaptivePerformanceScaler.FromPointer); // 0x10 M_Scaler                    ( ModelClassType AdaptivePerformanceScaler AdaptivePerformanceScaler AdaptivePerformanceScaler Pointer )
            value.M_LastAverageGpuFrameTime                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_LastAverageGpuFrameTime   ( ModelPrimitiveType float float float Single )
            value.M_LastAverageCpuFrameTime                 = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_LastAverageCpuFrameTime   ( ModelPrimitiveType float float float Single )
            value.M_IsApplied                               = GetBool(new IntPtr(p + 0x020)); // 0x20 M_IsApplied                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
