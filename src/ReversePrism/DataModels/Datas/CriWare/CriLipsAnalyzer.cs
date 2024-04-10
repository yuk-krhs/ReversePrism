using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NumChannels                              000186699040 ModelPrimitiveType uint uint uint UInt32
    // 034 SilenceThresholdVolumeDb                 000186665B50 ModelPrimitiveType float float float Single
    // 038 LipsSampler                              0001866576A0 ModelClassType CriLipsSampler CriLipsSampler CriLipsSampler Pointer
    // 040 BehaviourParamsPreset                    00018655E210 ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32
    // 048 Mouths                                   000185B78260 ModelClassListType CriLipsMouth[] CriLipsMouth[] List<CriLipsMouth> Pointer
    // 050 MaxSamplingRate                          0001865F4700 ModelPrimitiveType int int int Int32
    // 054 MinimumSupportSamplingRate               0001865F4700 ModelPrimitiveType int int int Int32
    // 058 CurrentSamplingRate                      0001865F3220 ModelPrimitiveType int int int Int32
    // 05C SamplingRateConfigured                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 processBuffers                           float[][] IL2CPP_TYPE_SZARRAY
    // 068 ProcessTime                              0001866656B0 ModelPrimitiveType float float float Single
    // 06C HasMonoBehaviourStarted                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 UnupdatedDuration                        0001866656B0 ModelPrimitiveType float float float Single
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

            value.NumChannels                               = GetUInt32(new IntPtr(p + 0x030)); // 02466BC23F80 0x30 NumChannels                 ( 000186699040 ModelPrimitiveType uint uint uint UInt32 )
            value.SilenceThresholdVolumeDb                  = GetSingle(new IntPtr(p + 0x034)); // 02466BC23FA0 0x34 SilenceThresholdVolumeDb    ( 000186665B50 ModelPrimitiveType float float float Single )
            value.LipsSampler                               = GetObject<CriLipsSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriLipsSampler.FromPointer); // 02466BC23FC0 0x38 LipsSampler                 ( 0001866576A0 ModelClassType CriLipsSampler CriLipsSampler CriLipsSampler Pointer )
            value.BehaviourParamsPreset                     = (BehaviourParamsPreset)GetInt32(new IntPtr(p + 0x040)); // 02466BC23FE0 0x40 BehaviourParamsPreset       ( 00018655E210 ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32 )
            value.Mouths                                    = GetObjectList<CriLipsMouth>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriLipsMouth.FromPointer); // 02466BC24000 0x48 Mouths                      ( 000185B78260 ModelClassListType CriLipsMouth[] CriLipsMouth[] List<CriLipsMouth> Pointer )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x050)); // 02466BC24020 0x50 MaxSamplingRate             ( 0001865F4700 ModelPrimitiveType int int int Int32 )
            value.MinimumSupportSamplingRate                = GetInt32(new IntPtr(p + 0x054)); // 02466BC24040 0x54 MinimumSupportSamplingRate  ( 0001865F4700 ModelPrimitiveType int int int Int32 )
            value.CurrentSamplingRate                       = GetInt32(new IntPtr(p + 0x058)); // 02466BC24060 0x58 CurrentSamplingRate         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.SamplingRateConfigured                    = GetBool(new IntPtr(p + 0x05C)); // 02466BC24080 0x5C SamplingRateConfigured      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessTime                               = GetSingle(new IntPtr(p + 0x068)); // 02466BC240C0 0x68 ProcessTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HasMonoBehaviourStarted                   = GetBool(new IntPtr(p + 0x06C)); // 02466BC240E0 0x6C HasMonoBehaviourStarted     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnupdatedDuration                         = GetSingle(new IntPtr(p + 0x070)); // 02466BC24100 0x70 UnupdatedDuration           ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
