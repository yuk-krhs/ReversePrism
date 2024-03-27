using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 EventType                                000186611CA0 ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32
    // 018 OpenTime                                 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 CloseTime                                000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 TourPopupViewModel                       0001865B1980 ModelClassType ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel Pointer
    // 040 LivePopupViewModel                       0001865AFCF0 ModelClassType ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel Pointer
    public partial class ProfileEventArchiveInfoPopupViewModel
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
            var value   = new ProfileEventArchiveInfoPopupViewModel();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D5599F68 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventType                                 = (ProfileEventType)GetInt32(new IntPtr(p + 0x014)); // 0270D5599F88 0x14 EventType                   ( 000186611CA0 ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32 )
            value.OpenTime                                  = GetDateTime(new IntPtr(p + 0x018)); // 0270D5599FA8 0x18 OpenTime                    ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CloseTime                                 = GetDateTime(new IntPtr(p + 0x028)); // 0270D5599FC8 0x28 CloseTime                   ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TourPopupViewModel                        = GetObject<ProfileEventArchiveInfoTourPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupViewModel.FromPointer); // 0270D5599FE8 0x38 TourPopupViewModel          ( 0001865B1980 ModelClassType ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel ProfileEventArchiveInfoTourPopupViewModel Pointer )
            value.LivePopupViewModel                        = GetObject<ProfileEventArchiveInfoLivePopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileEventArchiveInfoLivePopupViewModel.FromPointer); // 0270D559A008 0x40 LivePopupViewModel          ( 0001865AFCF0 ModelClassType ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel ProfileEventArchiveInfoLivePopupViewModel Pointer )

            return value;
        }
    }
}
