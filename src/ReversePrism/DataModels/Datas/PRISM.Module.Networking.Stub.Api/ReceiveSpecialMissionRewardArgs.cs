using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSpecialMissionRewardArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionStepIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstSpecialMissionStepId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstMissionIdListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_mstMissionIdList_codec         FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstMissionIdList                         000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ReceiveSpecialMissionRewardArgs : DataModel
    {
        public int                                      MstSpecialMissionStepId                 { get; set; }
        public List<int>?                               MstMissionIdList                        { get; set; }

        public static ReceiveSpecialMissionRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSpecialMissionRewardArgs() { Pointer= p0 };

            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x018)); // 024662842940 0x18 MstSpecialMissionStepId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstMissionIdList                          = GetInt32List(new IntPtr(p + 0x020)); // 0246628429A0 0x20 MstMissionIdList            ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
