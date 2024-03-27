using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveMissionRewardArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMissionIdListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_mstMissionIdList_codec         FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 018 MstMissionIdList                         000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ReceiveMissionRewardArgs
    {
        public List<int>?                               MstMissionIdList                        { get; set; }

        public static ReceiveMissionRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveMissionRewardArgs();

            value.MstMissionIdList                          = GetInt32List(new IntPtr(p + 0x018)); // 0270D22E6980 0x18 MstMissionIdList            ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
