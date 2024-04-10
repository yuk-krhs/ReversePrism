using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UserProfileEventDetailLiveStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Point                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 RankListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_rankList_codec                 FieldCodec`1<ProfileRankingStatus> IL2CPP_TYPE_GENERICINST
    // 020 RankList                                 000185CECFF8 ModelClassListType RepeatedField`1<ProfileRankingStatus> RepeatedField`1<ProfileRankingStatus> List<ProfileRankingStatus> Pointer
    public partial class UserProfileEventDetailLiveStatus : DataModel
    {
        public long                                     Point                                   { get; set; }
        public List<ProfileRankingStatus>?              RankList                                { get; set; }

        public static UserProfileEventDetailLiveStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileEventDetailLiveStatus() { Pointer= p0 };

            value.Point                                     = GetInt64(new IntPtr(p + 0x018)); // 02466268C380 0x18 Point                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RankList                                  = GetObjectList<ProfileRankingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileRankingStatus.FromPointer); // 02466268C3E0 0x20 RankList                    ( 000185CECFF8 ModelClassListType RepeatedField`1<ProfileRankingStatus> RepeatedField`1<ProfileRankingStatus> List<ProfileRankingStatus> Pointer )

            return value;
        }
    }
}
