using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NormalBias                               ModelPrimitiveType float float float Single
    // 014 ViewBias                                 ModelPrimitiveType float float float Single
    // 018 ScaleBiasByMinDistanceBetweenProbes      ModelPrimitiveType bool bool bool Bool
    // 01C SamplingNoise                            ModelPrimitiveType float float float Single
    // 020 Weight                                   ModelPrimitiveType float float float Single
    // 024 LeakReductionMode                        ModelEnumType APVLeakReductionMode APVLeakReductionMode APVLeakReductionMode Int32
    // 028 OcclusionWeightContribution              ModelPrimitiveType float float float Single
    // 02C MinValidNormalWeight                     ModelPrimitiveType float float float Single
    // 030 FrameIndexForNoise                       ModelPrimitiveType int int int Int32
    // 034 ReflNormalizationLowerClamp              ModelPrimitiveType float float float Single
    // 038 ReflNormalizationUpperClamp              ModelPrimitiveType float float float Single
    public partial class ProbeVolumeShadingParameters : DataModel
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
            var value   = new ProbeVolumeShadingParameters() { Pointer= p0 };

            value.NormalBias                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 NormalBias                  ( ModelPrimitiveType float float float Single )
            value.ViewBias                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 ViewBias                    ( ModelPrimitiveType float float float Single )
            value.ScaleBiasByMinDistanceBetweenProbes       = GetBool(new IntPtr(p + 0x018)); // 0x18 ScaleBiasByMinDistanceBetweenProbes ( ModelPrimitiveType bool bool bool Bool )
            value.SamplingNoise                             = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SamplingNoise               ( ModelPrimitiveType float float float Single )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x020)); // 0x20 Weight                      ( ModelPrimitiveType float float float Single )
            value.LeakReductionMode                         = (APVLeakReductionMode)GetInt32(new IntPtr(p + 0x024)); // 0x24 LeakReductionMode           ( ModelEnumType APVLeakReductionMode APVLeakReductionMode APVLeakReductionMode Int32 )
            value.OcclusionWeightContribution               = GetSingle(new IntPtr(p + 0x028)); // 0x28 OcclusionWeightContribution ( ModelPrimitiveType float float float Single )
            value.MinValidNormalWeight                      = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MinValidNormalWeight        ( ModelPrimitiveType float float float Single )
            value.FrameIndexForNoise                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 FrameIndexForNoise          ( ModelPrimitiveType int int int Int32 )
            value.ReflNormalizationLowerClamp               = GetSingle(new IntPtr(p + 0x034)); // 0x34 ReflNormalizationLowerClamp ( ModelPrimitiveType float float float Single )
            value.ReflNormalizationUpperClamp               = GetSingle(new IntPtr(p + 0x038)); // 0x38 ReflNormalizationUpperClamp ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
