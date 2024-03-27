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
    public partial class CriLipsAnalyzer
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
            var value   = new CriLipsAnalyzer();

            value.NumChannels                               = GetUInt32(new IntPtr(p + 0x030)); // 0270DBBA3A60 0x30 NumChannels                 ( 000186699040 ModelPrimitiveType uint uint uint UInt32 )
            value.SilenceThresholdVolumeDb                  = GetSingle(new IntPtr(p + 0x034)); // 0270DBBA3A80 0x34 SilenceThresholdVolumeDb    ( 000186665B50 ModelPrimitiveType float float float Single )
            value.LipsSampler                               = GetObject<CriLipsSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriLipsSampler.FromPointer); // 0270DBBA3AA0 0x38 LipsSampler                 ( 0001866576A0 ModelClassType CriLipsSampler CriLipsSampler CriLipsSampler Pointer )
            value.BehaviourParamsPreset                     = (BehaviourParamsPreset)GetInt32(new IntPtr(p + 0x040)); // 0270DBBA3AC0 0x40 BehaviourParamsPreset       ( 00018655E210 ModelEnumType BehaviourParamsPreset BehaviourParamsPreset BehaviourParamsPreset Int32 )
            value.Mouths                                    = GetObjectList<CriLipsMouth>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriLipsMouth.FromPointer); // 0270DBBA3AE0 0x48 Mouths                      ( 000185B78260 ModelClassListType CriLipsMouth[] CriLipsMouth[] List<CriLipsMouth> Pointer )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x050)); // 0270DBBA3B00 0x50 MaxSamplingRate             ( 0001865F4700 ModelPrimitiveType int int int Int32 )
            value.MinimumSupportSamplingRate                = GetInt32(new IntPtr(p + 0x054)); // 0270DBBA3B20 0x54 MinimumSupportSamplingRate  ( 0001865F4700 ModelPrimitiveType int int int Int32 )
            value.CurrentSamplingRate                       = GetInt32(new IntPtr(p + 0x058)); // 0270DBBA3B40 0x58 CurrentSamplingRate         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.SamplingRateConfigured                    = GetBool(new IntPtr(p + 0x05C)); // 0270DBBA3B60 0x5C SamplingRateConfigured      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessTime                               = GetSingle(new IntPtr(p + 0x068)); // 0270DBBA3BA0 0x68 ProcessTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HasMonoBehaviourStarted                   = GetBool(new IntPtr(p + 0x06C)); // 0270DBBA3BC0 0x6C HasMonoBehaviourStarted     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnupdatedDuration                         = GetSingle(new IntPtr(p + 0x070)); // 0270DBBA3BE0 0x70 UnupdatedDuration           ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
