using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstFrinedInvitationId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MyInvitationCode                         000186671910 ModelPrimitiveType string string string String
    // 020 UseInvitationCode                        000186671910 ModelPrimitiveType string string string String
    // 028 IsUseInvitationCode                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 OpenTime                                 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 CloseTime                                000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 050 MyMission                                000186519EF0 ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer
    // 058 FriendMissions                           000185CE39E8 ModelClassListType List`1<IFriendInvitationMissionStatus> List`1<IFriendInvitationMissionStatus> List<IFriendInvitationMissionStatus> Pointer
    public partial class FriendInvitationOverlayViewModel
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
            var value   = new FriendInvitationOverlayViewModel();

            value.MstFrinedInvitationId                     = GetInt32(new IntPtr(p + 0x010)); // 0270D61E8FD0 0x10 MstFrinedInvitationId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MyInvitationCode                          = GetString(new IntPtr(p + 0x018)); // 0270D61E8FF0 0x18 MyInvitationCode            ( 000186671910 ModelPrimitiveType string string string String )
            value.UseInvitationCode                         = GetString(new IntPtr(p + 0x020)); // 0270D61E9010 0x20 UseInvitationCode           ( 000186671910 ModelPrimitiveType string string string String )
            value.IsUseInvitationCode                       = GetBool(new IntPtr(p + 0x028)); // 0270D61E9030 0x28 IsUseInvitationCode         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x030)); // 0270D61E9050 0x30 OpenTime                    ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CloseTime                                 = GetDateTime(new IntPtr(p + 0x040)); // 0270D61E9070 0x40 CloseTime                   ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MyMission                                 = GetObject<IFriendInvitationMissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IFriendInvitationMissionStatus.FromPointer); // 0270D61E9090 0x50 MyMission                   ( 000186519EF0 ModelClassType IFriendInvitationMissionStatus IFriendInvitationMissionStatus IFriendInvitationMissionStatus Pointer )
            value.FriendMissions                            = GetObjectList<IFriendInvitationMissionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IFriendInvitationMissionStatus.FromPointer); // 0270D61E90B0 0x58 FriendMissions              ( 000185CE39E8 ModelClassListType List`1<IFriendInvitationMissionStatus> List`1<IFriendInvitationMissionStatus> List<IFriendInvitationMissionStatus> Pointer )

            return value;
        }
    }
}
