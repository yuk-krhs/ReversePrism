using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveInviteCodeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstFriendInvitationIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstFriendInvitationId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Result                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 ReceivedFriendInvitationFieldNumber      int IL2CPP_TYPE_I4
    // 028 ReceivedFriendInvitation                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SelfMissionListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_selfMissionList_codec          FieldCodec`1<FriendInvitationMissionStatus> IL2CPP_TYPE_GENERICINST
    // 030 SelfMissionList                          000185CD8FA8 ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 038 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReceiveInviteCodeReply : DataModel
    {
        public int                                      MstFriendInvitationId                   { get; set; }
        public bool                                     Result                                  { get; set; }
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public bool                                     ReceivedFriendInvitation                { get; set; }
        public List<FriendInvitationMissionStatus>?     SelfMissionList                         { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReceiveInviteCodeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveInviteCodeReply() { Pointer= p0 };

            value.MstFriendInvitationId                     = GetInt32(new IntPtr(p + 0x018)); // 0246614E6990 0x18 MstFriendInvitationId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Result                                    = GetBool(new IntPtr(p + 0x01C)); // 0246614E69D0 0x1C Result                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0246614E6A30 0x20 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.ReceivedFriendInvitation                  = GetBool(new IntPtr(p + 0x028)); // 0246614E6A70 0x28 ReceivedFriendInvitation    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelfMissionList                           = GetObjectList<FriendInvitationMissionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FriendInvitationMissionStatus.FromPointer); // 0246614E6AD0 0x30 SelfMissionList             ( 000185CD8FA8 ModelClassListType RepeatedField`1<FriendInvitationMissionStatus> RepeatedField`1<FriendInvitationMissionStatus> List<FriendInvitationMissionStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246614E6B10 0x38 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
