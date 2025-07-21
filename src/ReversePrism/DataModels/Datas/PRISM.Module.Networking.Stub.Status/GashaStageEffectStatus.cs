using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaStageEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 Phase1FieldNumber                        int IL2CPP_TYPE_I4
    // 018 Phase1                                   ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase2FieldNumber                        int IL2CPP_TYPE_I4
    // 020 Phase2                                   ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase3FieldNumber                        int IL2CPP_TYPE_I4
    // 028 Phase3                                   ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 CharacterEffectListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_characterEffectList_codec      FieldCodec`1<GashaProduceIdolEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 CharacterEffectList                      ModelClassListType RepeatedField`1<GashaProduceIdolEffectStatus> RepeatedField`1<GashaProduceIdolEffectStatus> List<GashaProduceIdolEffectStatus> Pointer
    // 000 Phase4Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 038 Phase4Step1                              ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase4Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 040 Phase4Step2                              ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    public partial class GashaStageEffectStatus : DataModel
    {
        public GashaEffectPhaseStatus?                  Phase1                                  { get; set; }
        public GashaEffectPhaseStatus?                  Phase2                                  { get; set; }
        public GashaEffectPhaseStatus?                  Phase3                                  { get; set; }
        public List<GashaProduceIdolEffectStatus>?      CharacterEffectList                     { get; set; }
        public GashaEffectPhaseStatus?                  Phase4Step1                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase4Step2                             { get; set; }

        public static GashaStageEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaStageEffectStatus() { Pointer= p0 };

            value.Phase1                                    = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x18 Phase1                      ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase2                                    = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x20 Phase2                      ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase3                                    = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x28 Phase3                      ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.CharacterEffectList                       = GetObjectList<GashaProduceIdolEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaProduceIdolEffectStatus.FromPointer); // 0x30 CharacterEffectList         ( ModelClassListType RepeatedField`1<GashaProduceIdolEffectStatus> RepeatedField`1<GashaProduceIdolEffectStatus> List<GashaProduceIdolEffectStatus> Pointer )
            value.Phase4Step1                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x38 Phase4Step1                 ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase4Step2                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x40 Phase4Step2                 ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )

            return value;
        }
    }
}
