using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NormalBias                               000186666050 ModelPrimitiveType float float float Single
    // 014 ViewBias                                 000186666050 ModelPrimitiveType float float float Single
    // 018 ScaleBiasByMinDistanceBetweenProbes      000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C SamplingNoise                            000186666050 ModelPrimitiveType float float float Single
    // 020 Weight                                   000186666050 ModelPrimitiveType float float float Single
    // 024 LeakReductionMode                        00018666C390 ModelEnumType APVLeakReductionMode APVLeakReductionMode APVLeakReductionMode Int32
    // 028 OcclusionWeightContribution              000186666050 ModelPrimitiveType float float float Single
    // 02C MinValidNormalWeight                     000186666050 ModelPrimitiveType float float float Single
    // 030 FrameIndexForNoise                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 ReflNormalizationLowerClamp              000186666050 ModelPrimitiveType float float float Single
    // 038 ReflNormalizationUpperClamp              000186666050 ModelPrimitiveType float float float Single
    public partial class ProbeVolumeShadingParameters
    {
        public float                                    NormalBias                              { get; set; }
        public float                                    ViewBias                                { get; set; }
        public bool                                     ScaleBiasByMinDistanceBetweenProbes     { get; set; }
        public float                                    SamplingNoise                           { get; set; }
        public float                                    Weight                                  { get; set; }
        public APVLeakReductionMode                     LeakReductionMode                       { get; set; }
        public float                                    OcclusionWeightContribution             { get; set; }
        public float                                    MinValidNormalWeight                    { get; set; }
        public int                                      FrameIndexForNoise                      { get; set; }
        public float                                    ReflNormalizationLowerClamp             { get; set; }
        public float                                    ReflNormalizationUpperClamp             { get; set; }

        public static ProbeVolumeShadingParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeShadingParameters();

            value.NormalBias                                = GetSingle(new IntPtr(p + 0x010)); // 0270D91E6370 0x10 NormalBias                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.ViewBias                                  = GetSingle(new IntPtr(p + 0x014)); // 0270D91E6390 0x14 ViewBias                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.ScaleBiasByMinDistanceBetweenProbes       = GetBool(new IntPtr(p + 0x018)); // 0270D91E63B0 0x18 ScaleBiasByMinDistanceBetweenProbes ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SamplingNoise                             = GetSingle(new IntPtr(p + 0x01C)); // 0270D91E63D0 0x1C SamplingNoise               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x020)); // 0270D91E63F0 0x20 Weight                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.LeakReductionMode                         = (APVLeakReductionMode)GetInt32(new IntPtr(p + 0x024)); // 0270D91E6410 0x24 LeakReductionMode           ( 00018666C390 ModelEnumType APVLeakReductionMode APVLeakReductionMode APVLeakReductionMode Int32 )
            value.OcclusionWeightContribution               = GetSingle(new IntPtr(p + 0x028)); // 0270D91E6430 0x28 OcclusionWeightContribution ( 000186666050 ModelPrimitiveType float float float Single )
            value.MinValidNormalWeight                      = GetSingle(new IntPtr(p + 0x02C)); // 0270D91E6450 0x2C MinValidNormalWeight        ( 000186666050 ModelPrimitiveType float float float Single )
            value.FrameIndexForNoise                        = GetInt32(new IntPtr(p + 0x030)); // 0270D91E6470 0x30 FrameIndexForNoise          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReflNormalizationLowerClamp               = GetSingle(new IntPtr(p + 0x034)); // 0270D91E6490 0x34 ReflNormalizationLowerClamp ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReflNormalizationUpperClamp               = GetSingle(new IntPtr(p + 0x038)); // 0270D91E64B0 0x38 ReflNormalizationUpperClamp ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
