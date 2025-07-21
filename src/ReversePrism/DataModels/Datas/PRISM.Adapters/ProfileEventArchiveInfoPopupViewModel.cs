using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  ModelPrimitiveType int int int Int32
    // 014 EventType                                ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32
    // 018 OpenTime                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 CloseTime                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 TourPopupViewModel                       ModelClassType ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel Pointer
    // 040 LivePopupViewModel                       ModelClassType ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel Pointer
    public partial class ProfileEventArchiveInfoPopupViewModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public ProfileEventType                         EventType                               { get; set; }
        public DateTime                                 OpenTime                                { get; set; }
        public DateTime                                 CloseTime                               { get; set; }
        public ProfileEventArchiveInfoTourPopupViewModel? TourPopupViewModel                      { get; set; }
        public ProfileEventArchiveInfoLivePopupViewModel? LivePopupViewModel                      { get; set; }

        public static ProfileEventArchiveInfoPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoPopupViewModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.EventType                                 = (ProfileEventType)GetInt32(new IntPtr(p + 0x014)); // 0x14 EventType                   ( ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32 )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 OpenTime                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CloseTime                                 = GetDateTime(new IntPtr(p + 0x028)); // 0x28 CloseTime                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TourPopupViewModel                        = GetObject<ProfileEventArchiveInfoTourPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupViewModel.FromPointer); // 0x38 TourPopupViewModel          ( ModelClassType ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel Pointer )
            value.LivePopupViewModel                        = GetObject<ProfileEventArchiveInfoLivePopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileEventArchiveInfoLivePopupViewModel.FromPointer); // 0x40 LivePopupViewModel          ( ModelClassType ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel Pointer )

            return value;
        }
    }
}
