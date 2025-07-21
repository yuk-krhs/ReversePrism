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
    // 000 _parser                                  MessageParser`1<ProfileEventDetailStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 038 EventType                                ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 03C MstEventId                               ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LiveFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Live                                     ModelClassType UserProfileEventDetailLiveStatus UserProfileEventDetailLiveStatus UserProfileEventDetailLiveStatus Pointer
    // 000 ChallengeTourFieldNumber                 int IL2CPP_TYPE_I4
    // 058 ChallengeTour                            ModelClassType ProfileChallengeTourStatus ProfileChallengeTourStatus ProfileChallengeTourStatus Pointer
    // 000 PvpFieldNumber                           int IL2CPP_TYPE_I4
    // 060 Pvp                                      ModelClassType UserProfileEventDetailPvpStatus UserProfileEventDetailPvpStatus UserProfileEventDetailPvpStatus Pointer
    public partial class ProfileEventDetailStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public ProfileEventType                         EventType                               { get; set; }
        public int                                      MstEventId                              { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public UserProfileEventDetailLiveStatus?        Live                                    { get; set; }
        public ProfileChallengeTourStatus?              ChallengeTour                           { get; set; }
        public UserProfileEventDetailPvpStatus?         Pvp                                     { get; set; }

        public static ProfileEventDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventDetailStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventType                                 = (ProfileEventType)GetInt32(new IntPtr(p + 0x038)); // 0x38 EventType                   ( ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32 )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Live                                      = GetObject<UserProfileEventDetailLiveStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.UserProfileEventDetailLiveStatus.FromPointer); // 0x50 Live                        ( ModelClassType UserProfileEventDetailLiveStatus UserProfileEventDetailLiveStatus UserProfileEventDetailLiveStatus Pointer )
            value.ChallengeTour                             = GetObject<ProfileChallengeTourStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileChallengeTourStatus.FromPointer); // 0x58 ChallengeTour               ( ModelClassType ProfileChallengeTourStatus ProfileChallengeTourStatus ProfileChallengeTourStatus Pointer )
            value.Pvp                                       = GetObject<UserProfileEventDetailPvpStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.UserProfileEventDetailPvpStatus.FromPointer); // 0x60 Pvp                         ( ModelClassType UserProfileEventDetailPvpStatus UserProfileEventDetailPvpStatus UserProfileEventDetailPvpStatus Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
