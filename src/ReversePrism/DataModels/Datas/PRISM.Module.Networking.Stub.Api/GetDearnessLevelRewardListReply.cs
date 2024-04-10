using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDearnessLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DearnessLevelRewardListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_dearnessLevelRewardList_codec  FieldCodec`1<DearnessLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 DearnessLevelRewardList                  000185CD32C8 ModelClassListType RepeatedField`1<DearnessLevelRewardStatus> RepeatedField`1<DearnessLevelRewardStatus> List<DearnessLevelRewardStatus> Pointer
    public partial class GetDearnessLevelRewardListReply : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public List<DearnessLevelRewardStatus>?         DearnessLevelRewardList                 { get; set; }

        public static GetDearnessLevelRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDearnessLevelRewardListReply() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 024662067708 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DearnessLevelRewardList                   = GetObjectList<DearnessLevelRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.DearnessLevelRewardStatus.FromPointer); // 024662067768 0x20 DearnessLevelRewardList     ( 000185CD32C8 ModelClassListType RepeatedField`1<DearnessLevelRewardStatus> RepeatedField`1<DearnessLevelRewardStatus> List<DearnessLevelRewardStatus> Pointer )

            return value;
        }
    }
}
