using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastFollowerAddDate                      000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetFollowerListReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FollowerCountFieldNumber                 int IL2CPP_TYPE_I4
    // 028 FollowerCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FollowerMaxCountFieldNumber              int IL2CPP_TYPE_I4
    // 02C FollowerMaxCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FollowerListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_followerList_codec             FieldCodec`1<FriendStatus> IL2CPP_TYPE_GENERICINST
    // 030 FollowerList                             000185CD91E8 ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 LastFollowerAddDateFieldNumber           int IL2CPP_TYPE_I4
    // 040 _LastFollowerAddDate                     000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetFollowerListReply
    {
        public DateTime                                 LastFollowerAddDate                     { get; set; }
        public int                                      FollowerCount                           { get; set; }
        public int                                      FollowerMaxCount                        { get; set; }
        public List<FriendStatus>?                      FollowerList                            { get; set; }
        public string                                   Cursor                                  { get; set; }
        public Timestamp?                               _LastFollowerAddDate                    { get; set; }

        public static GetFollowerListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFollowerListReply();

            value.LastFollowerAddDate                       = GetDateTime(new IntPtr(p + 0x010)); // 0270D14170B0 0x10 LastFollowerAddDate         ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FollowerCount                             = GetInt32(new IntPtr(p + 0x028)); // 0270D1417130 0x28 FollowerCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FollowerMaxCount                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D1417170 0x2C FollowerMaxCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FollowerList                              = GetObjectList<FriendStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FriendStatus.FromPointer); // 0270D14171D0 0x30 FollowerList                ( 000185CD91E8 ModelClassListType RepeatedField`1<FriendStatus> RepeatedField`1<FriendStatus> List<FriendStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x038)); // 0270D1417210 0x38 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value._LastFollowerAddDate                      = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1417250 0x40 _LastFollowerAddDate        ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastFollowerAddDate           = ToDateTime(value._LastFollowerAddDate);

            return value;
        }
    }
}
