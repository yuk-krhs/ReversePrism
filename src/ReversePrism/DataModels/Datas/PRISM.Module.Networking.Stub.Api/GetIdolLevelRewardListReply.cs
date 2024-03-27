using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetIdolLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolLevelRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_idolLevelRewardList_codec      FieldCodec`1<IdolLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolLevelRewardList                      000185CDFD68 ModelClassListType RepeatedField`1<IdolLevelRewardStatus> RepeatedField`1<IdolLevelRewardStatus> List<IdolLevelRewardStatus> Pointer
    public partial class GetIdolLevelRewardListReply
    {
        public int                                      MstIdolId                               { get; set; }
        public List<IdolLevelRewardStatus>?             IdolLevelRewardList                     { get; set; }

        public static GetIdolLevelRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetIdolLevelRewardListReply();

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D20FDD68 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolLevelRewardList                       = GetObjectList<IdolLevelRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolLevelRewardStatus.FromPointer); // 0270D20FDDC8 0x20 IdolLevelRewardList         ( 000185CDFD68 ModelClassListType RepeatedField`1<IdolLevelRewardStatus> RepeatedField`1<IdolLevelRewardStatus> List<IdolLevelRewardStatus> Pointer )

            return value;
        }
    }
}
