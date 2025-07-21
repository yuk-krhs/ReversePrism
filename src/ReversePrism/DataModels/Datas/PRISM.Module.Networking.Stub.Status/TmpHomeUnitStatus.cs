using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TmpHomeUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HomeUnitIdolListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_homeUnitIdolList_codec         FieldCodec`1<TmpHomeUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 HomeUnitIdolList                         ModelClassListType RepeatedField`1<TmpHomeUnitIdolStatus> RepeatedField`1<TmpHomeUnitIdolStatus> List<TmpHomeUnitIdolStatus> Pointer
    // 000 VoiceMotionListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_voiceMotionList_codec          FieldCodec`1<HomeVoiceMotionStatus> IL2CPP_TYPE_GENERICINST
    // 020 VoiceMotionList                          ModelClassListType RepeatedField`1<HomeVoiceMotionStatus> RepeatedField`1<HomeVoiceMotionStatus> List<HomeVoiceMotionStatus> Pointer
    public partial class TmpHomeUnitStatus : DataModel
    {
        public List<TmpHomeUnitIdolStatus>?             HomeUnitIdolList                        { get; set; }
        public List<HomeVoiceMotionStatus>?             VoiceMotionList                         { get; set; }

        public static TmpHomeUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TmpHomeUnitStatus() { Pointer= p0 };

            value.HomeUnitIdolList                          = GetObjectList<TmpHomeUnitIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TmpHomeUnitIdolStatus.FromPointer); // 0x18 HomeUnitIdolList            ( ModelClassListType RepeatedField`1<TmpHomeUnitIdolStatus> RepeatedField`1<TmpHomeUnitIdolStatus> List<TmpHomeUnitIdolStatus> Pointer )
            value.VoiceMotionList                           = GetObjectList<HomeVoiceMotionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeVoiceMotionStatus.FromPointer); // 0x20 VoiceMotionList             ( ModelClassListType RepeatedField`1<HomeVoiceMotionStatus> RepeatedField`1<HomeVoiceMotionStatus> List<HomeVoiceMotionStatus> Pointer )

            return value;
        }
    }
}
