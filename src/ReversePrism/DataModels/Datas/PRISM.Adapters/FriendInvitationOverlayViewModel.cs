using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstFrinedInvitationId                    ModelPrimitiveType int int int Int32
    // 018 MyInvitationCode                         ModelPrimitiveType string string string String
    // 020 UseInvitationCode                        ModelPrimitiveType string string string String
    // 028 IsUseInvitationCode                      ModelPrimitiveType bool bool bool Bool
    // 030 OpenTime                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 CloseTime                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 050 MyMission                                ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer
    // 058 FriendMissions                           ModelClassListType List`1<IFriendInvitationMissionStatus> List`1<IFriendInvitationMissionStatus> List<IFriendInvitationMissionStatus> Pointer
    public partial class FriendInvitationOverlayViewModel : DataModel
    {
        public int                                      MstFrinedInvitationId                   { get; set; }
        public string                                   MyInvitationCode                        { get; set; }
        public string                                   UseInvitationCode                       { get; set; }
        public bool                                     IsUseInvitationCode                     { get; set; }
        public DateTime                                 OpenTime                                { get; set; }
        public DateTime                                 CloseTime                               { get; set; }
        public IFriendInvitationMissionStatus?          MyMission                               { get; set; }
        public List<IFriendInvitationMissionStatus>?    FriendMissions                          { get; set; }

        public static FriendInvitationOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationOverlayViewModel() { Pointer= p0 };

            value.MstFrinedInvitationId                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstFrinedInvitationId       ( ModelPrimitiveType int int int Int32 )
            value.MyInvitationCode                          = GetString(new IntPtr(p + 0x018)); // 0x18 MyInvitationCode            ( ModelPrimitiveType string string string String )
            value.UseInvitationCode                         = GetString(new IntPtr(p + 0x020)); // 0x20 UseInvitationCode           ( ModelPrimitiveType string string string String )
            value.IsUseInvitationCode                       = GetBool(new IntPtr(p + 0x028)); // 0x28 IsUseInvitationCode         ( ModelPrimitiveType bool bool bool Bool )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x030)); // 0x30 OpenTime                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CloseTime                                 = GetDateTime(new IntPtr(p + 0x040)); // 0x40 CloseTime                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MyMission                                 = GetObject<IFriendInvitationMissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IFriendInvitationMissionStatus.FromPointer); // 0x50 MyMission                   ( ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer )
            value.FriendMissions                            = GetObjectList<IFriendInvitationMissionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IFriendInvitationMissionStatus.FromPointer); // 0x58 FriendMissions              ( ModelClassListType List`1<IFriendInvitationMissionStatus> List`1<IFriendInvitationMissionStatus> List<IFriendInvitationMissionStatus> Pointer )

            return value;
        }
    }
}
