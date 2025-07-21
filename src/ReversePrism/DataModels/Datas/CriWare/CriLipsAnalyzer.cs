using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NumChannels                              ModelPrimitiveType uint uint uint UInt32
    // 034 SilenceThresholdVolumeDb                 ModelPrimitiveType float float float Single
    // 038 LipsSampler                              ModelClassType CriLipsSampler CriLipsSampler CriLipsSampler Pointer
    // 040 BehaviourParamsPreset                    ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32
    // 048 Mouths                                   ModelClassListType CriLipsMouth[] CriLipsMouth[] List<CriLipsMouth> Pointer
    // 050 MaxSamplingRate                          ModelPrimitiveType int int int Int32
    // 054 MinimumSupportSamplingRate               ModelPrimitiveType int int int Int32
    // 058 CurrentSamplingRate                      ModelPrimitiveType int int int Int32
    // 05C SamplingRateConfigured                   ModelPrimitiveType bool bool bool Bool
    // 060 processBuffers                           float[][] IL2CPP_TYPE_SZARRAY
    // 068 ProcessTime                              ModelPrimitiveType float float float Single
    // 06C HasMonoBehaviourStarted                  ModelPrimitiveType bool bool bool Bool
    // 070 UnupdatedDuration                        ModelPrimitiveType float float float Single
    public partial class CriLipsAnalyzer : DataModel
    {
        public uint                                     NumChannels                             { get; set; }
        public float                                    SilenceThresholdVolumeDb                { get; set; }
        public CriLipsSampler?                          LipsSampler                             { get; set; }
        public BehaviourParamsPreset                    BehaviourParamsPreset                   { get; set; }
        public List<CriLipsMouth>?                      Mouths                                  { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }
        public int                                      MinimumSupportSamplingRate              { get; set; }
        public int                                      CurrentSamplingRate                     { get; set; }
        public bool                                     SamplingRateConfigured                  { get; set; }
        public float                                    ProcessTime                             { get; set; }
        public bool                                     HasMonoBehaviourStarted                 { get; set; }
        public float                                    UnupdatedDuration                       { get; set; }

        public static CriLipsAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsAnalyzer() { Pointer= p0 };

            value.NumChannels                               = GetUInt32(new IntPtr(p + 0x030)); // 0x30 NumChannels                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.SilenceThresholdVolumeDb                  = GetSingle(new IntPtr(p + 0x034)); // 0x34 SilenceThresholdVolumeDb    ( ModelPrimitiveType float float float Single )
            value.LipsSampler                               = GetObject<CriLipsSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriLipsSampler.FromPointer); // 0x38 LipsSampler                 ( ModelClassType CriLipsSampler CriLipsSampler CriLipsSampler Pointer )
            value.BehaviourParamsPreset                     = (BehaviourParamsPreset)GetInt32(new IntPtr(p + 0x040)); // 0x40 BehaviourParamsPreset       ( ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32 )
            value.Mouths                                    = GetObjectList<CriLipsMouth>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriLipsMouth.FromPointer); // 0x48 Mouths                      ( ModelClassListType CriLipsMouth[] CriLipsMouth[] List<CriLipsMouth> Pointer )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x050)); // 0x50 MaxSamplingRate             ( ModelPrimitiveType int int int Int32 )
            value.MinimumSupportSamplingRate                = GetInt32(new IntPtr(p + 0x054)); // 0x54 MinimumSupportSamplingRate  ( ModelPrimitiveType int int int Int32 )
            value.CurrentSamplingRate                       = GetInt32(new IntPtr(p + 0x058)); // 0x58 CurrentSamplingRate         ( ModelPrimitiveType int int int Int32 )
            value.SamplingRateConfigured                    = GetBool(new IntPtr(p + 0x05C)); // 0x5C SamplingRateConfigured      ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessTime                               = GetSingle(new IntPtr(p + 0x068)); // 0x68 ProcessTime                 ( ModelPrimitiveType float float float Single )
            value.HasMonoBehaviourStarted                   = GetBool(new IntPtr(p + 0x06C)); // 0x6C HasMonoBehaviourStarted     ( ModelPrimitiveType bool bool bool Bool )
            value.UnupdatedDuration                         = GetSingle(new IntPtr(p + 0x070)); // 0x70 UnupdatedDuration           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
