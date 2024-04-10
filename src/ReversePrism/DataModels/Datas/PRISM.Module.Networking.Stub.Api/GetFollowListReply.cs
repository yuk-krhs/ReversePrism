using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastFollowerAddDate                      000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetFollowListReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FollowCountFieldNumber                   int IL2CPP_TYPE_I4
    // 028 FollowCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FollowMaxCountFieldNumber                int IL2CPP_TYPE_I4
    // 02C FollowMaxCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FollowListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_followList_codec               FieldCodec`1<FriendStatus> IL2CPP_TYPE_GENERICINST
    // 030 FollowList                               000185CD91E8 ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 LastFollowerAddDateFieldNumber           int IL2CPP_TYPE_I4
    // 040 _LastFollowerAddDate                     000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetFollowListReply : DataModel
    {
        public DateTime                                 LastFollowerAddDate                     { get; set; }
        public int                                      FollowCount                             { get; set; }
        public int                                      FollowMaxCount                          { get; set; }
        public List<FriendStatus>?                      FollowList                              { get; set; }
        public string                                   Cursor                                  { get; set; }
        public Timestamp?                               _LastFollowerAddDate                    { get; set; }

        public static GetFollowListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFollowListReply() { Pointer= p0 };

            value.LastFollowerAddDate                       = GetDateTime(new IntPtr(p + 0x010)); // 024661398690 0x10 LastFollowerAddDate         ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FollowCount                               = GetInt32(new IntPtr(p + 0x028)); // 024661398710 0x28 FollowCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FollowMaxCount                            = GetInt32(new IntPtr(p + 0x02C)); // 024661398750 0x2C FollowMaxCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FollowList                                = GetObjectList<FriendStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FriendStatus.FromPointer); // 0246613987B0 0x30 FollowList                  ( 000185CD91E8 ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x038)); // 0246613987F0 0x38 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value._LastFollowerAddDate                      = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024661398830 0x40 _LastFollowerAddDate        ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastFollowerAddDate           = ToDateTime(value._LastFollowerAddDate);

            return value;
        }
    }
}
