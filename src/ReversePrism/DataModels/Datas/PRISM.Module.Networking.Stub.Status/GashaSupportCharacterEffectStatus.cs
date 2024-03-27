using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaSupportCharacterEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 Phase3Step1FieldNumber                   int IL2CPP_TYPE_I4
    // 018 Phase3Step1                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase3Step2FieldNumber                   int IL2CPP_TYPE_I4
    // 020 Phase3Step2                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase3Step0FieldNumber                   int IL2CPP_TYPE_I4
    // 028 Phase3Step0                              0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 NoticeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 NoticeType                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GashaSupportCharacterEffectStatus
    {
        public GashaEffectPhaseStatus?                  Phase3Step1                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase3Step2                             { get; set; }
        public GashaEffectPhaseStatus?                  Phase3Step0                             { get; set; }
        public int                                      NoticeType                              { get; set; }

        public static GashaSupportCharacterEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSupportCharacterEffectStatus();

            value.Phase3Step1                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D15A6D68 0x18 Phase3Step1                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase3Step2                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D15A6DA8 0x20 Phase3Step2                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase3Step0                               = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0270D15A6DE8 0x28 Phase3Step0                 ( 0001865FB090 ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.NoticeType                                = GetInt32(new IntPtr(p + 0x030)); // 0270D15A6E28 0x30 NoticeType                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
