using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastFollowerAddDate                      ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetRecommendedUserListReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FollowCountFieldNumber                   int IL2CPP_TYPE_I4
    // 028 FollowCount                              ModelPrimitiveType int int int Int32
    // 000 FollowMaxCountFieldNumber                int IL2CPP_TYPE_I4
    // 02C FollowMaxCount                           ModelPrimitiveType int int int Int32
    // 000 RecommendedUserListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_recommendedUserList_codec      FieldCodec`1<FriendStatus> IL2CPP_TYPE_GENERICINST
    // 030 RecommendedUserList                      ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer
    // 000 LastFollowerAddDateFieldNumber           int IL2CPP_TYPE_I4
    // 038 _LastFollowerAddDate                     ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetRecommendedUserListReply : DataModel
    {
        public DateTime                                 LastFollowerAddDate                     { get; set; }
        public int                                      FollowCount                             { get; set; }
        public int                                      FollowMaxCount                          { get; set; }
        public List<FriendStatus>?                      RecommendedUserList                     { get; set; }
        public Timestamp?                               _LastFollowerAddDate                    { get; set; }

        public static GetRecommendedUserListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRecommendedUserListReply() { Pointer= p0 };

            value.LastFollowerAddDate                       = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastFollowerAddDate         ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FollowCount                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 FollowCount                 ( ModelPrimitiveType int int int Int32 )
            value.FollowMaxCount                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C FollowMaxCount              ( ModelPrimitiveType int int int Int32 )
            value.RecommendedUserList                       = GetObjectList<FriendStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FriendStatus.FromPointer); // 0x30 RecommendedUserList         ( ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer )
            value._LastFollowerAddDate                      = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _LastFollowerAddDate        ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastFollowerAddDate           = ToDateTime(value._LastFollowerAddDate);

            return value;
        }
    }
}
