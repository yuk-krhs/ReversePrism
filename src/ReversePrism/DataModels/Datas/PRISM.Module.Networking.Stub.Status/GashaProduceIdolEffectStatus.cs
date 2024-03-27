using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaProduceIdolEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 Phase5Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 018 Phase5Step1                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase5Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 020 Phase5Step2                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase6Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 028 Phase6Step1                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase6Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 030 Phase6Step2                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase6Step3FieldNumber                   int IL2CPP_TYPE_I4
    // 038 Phase6Step3                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase6Step4FieldNumber                   int IL2CPP_TYPE_I4
    // 040 Phase6Step4                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase7FieldNumber                        int IL2CPP_TYPE_I4
    // 048 Phase7                                   000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 Phase8FieldNumber                        int IL2CPP_TYPE_I4
    // 050 Phase8                                   000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 058 MstCostumeSetId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 Phase5Step0FieldNumber                   int IL2CPP_TYPE_I4
    // 060 Phase5Step0                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    public partial class GashaProduceIdolEffectStatus
    {
        public GashaEffectPhaseStatus?                  Phase5Step1                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase5Step2                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase6Step1                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase6Step2                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase6Step3                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase6Step4                             { get; set; }
        public VoiceResourceStatus?                     Phase7                                  { get; set; }
        public VoiceResourceStatus?                     Phase8                                  { get; set; }
        public int                                      MstCostumeSetId                         { get; set; }
        public GashaEffectPhaseStatus?                  Phase5Step0                             { get; set; }

        public static GashaProduceIdolEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProduceIdolEffectStatus();

            value.Phase5Step1                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B730 0x18 Phase5Step1                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase5Step2                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B770 0x20 Phase5Step2                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase6Step1                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B7B0 0x28 Phase6Step1                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase6Step2                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B7F0 0x30 Phase6Step2                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase6Step3                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B830 0x38 Phase6Step3                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase6Step4                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B870 0x40 Phase6Step4                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase7                                    = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 0270D159B8B0 0x48 Phase7                      ( 000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.Phase8                                    = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 0270D159B8F0 0x50 Phase8                      ( 000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x058)); // 0270D159B930 0x58 MstCostumeSetId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase5Step0                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D159B970 0x60 Phase5Step0                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )

            return value;
        }
    }
}
