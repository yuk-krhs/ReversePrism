using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetFriendInvitationTopReply> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstFriendInvitationIdFieldNumber         int IL2CPP_TYPE_I4
    // 038 MstFriendInvitationId                    ModelPrimitiveType int int int Int32
    // 000 FriendInvitationCodeFieldNumber          int IL2CPP_TYPE_I4
    // 040 FriendInvitationCode                     ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 048 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 050 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ReceivedFriendInvitationFieldNumber      int IL2CPP_TYPE_I4
    // 058 ReceivedFriendInvitation                 ModelPrimitiveType bool bool bool Bool
    // 000 SelfMissionListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_selfMissionList_codec          FieldCodec`1<FriendInvitationMissionStatus> IL2CPP_TYPE_GENERICINST
    // 060 SelfMissionList                          ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer
    // 000 FriendMissionListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_friendMissionList_codec        FieldCodec`1<FriendInvitationMissionStatus> IL2CPP_TYPE_GENERICINST
    // 068 FriendMissionList                        ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer
    public partial class GetFriendInvitationTopReply : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstFriendInvitationId                   { get; set; }
        public string                                   FriendInvitationCode                    { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public bool                                     ReceivedFriendInvitation                { get; set; }
        public List<FriendInvitationMissionStatus>?     SelfMissionList                         { get; set; }
        public List<FriendInvitationMissionStatus>?     FriendMissionList                       { get; set; }

        public static GetFriendInvitationTopReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFriendInvitationTopReply() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstFriendInvitationId                     = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstFriendInvitationId       ( ModelPrimitiveType int int int Int32 )
            value.FriendInvitationCode                      = GetString(new IntPtr(p + 0x040)); // 0x40 FriendInvitationCode        ( ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReceivedFriendInvitation                  = GetBool(new IntPtr(p + 0x058)); // 0x58 ReceivedFriendInvitation    ( ModelPrimitiveType bool bool bool Bool )
            value.SelfMissionList                           = GetObjectList<FriendInvitationMissionStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.FriendInvitationMissionStatus.FromPointer); // 0x60 SelfMissionList             ( ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer )
            value.FriendMissionList                         = GetObjectList<FriendInvitationMissionStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.FriendInvitationMissionStatus.FromPointer); // 0x68 FriendMissionList           ( ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
