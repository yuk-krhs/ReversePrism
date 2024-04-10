using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSelfRankingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MyRankingListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_myRankingList_codec            FieldCodec`1<RankedUserStatus> IL2CPP_TYPE_GENERICINST
    // 018 MyRankingList                            000185CEE9F8 ModelClassListType RepeatedField`1<RankedUserStatus> RepeatedField`1<RankedUserStatus> List<RankedUserStatus> Pointer
    public partial class GetSelfRankingReply : DataModel
    {
        public List<RankedUserStatus>?                  MyRankingList                           { get; set; }

        public static GetSelfRankingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSelfRankingReply() { Pointer= p0 };

            value.MyRankingList                             = GetObjectList<RankedUserStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RankedUserStatus.FromPointer); // 024660FAAFE0 0x18 MyRankingList               ( 000185CEE9F8 ModelClassListType RepeatedField`1<RankedUserStatus> RepeatedField`1<RankedUserStatus> List<RankedUserStatus> Pointer )

            return value;
        }
    }
}
