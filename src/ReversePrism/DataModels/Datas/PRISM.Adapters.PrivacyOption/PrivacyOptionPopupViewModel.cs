using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAnalyticsToggleOn                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 011 IsAdvertisementToggleOn                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 ConfirmConsentStatus                     0001865B0100 ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32
    public partial class PrivacyOptionPopupViewModel
    {
        public bool                                     IsAnalyticsToggleOn                     { get; set; }
        public bool                                     IsAdvertisementToggleOn                 { get; set; }
        public ConfirmConsentStatus                     ConfirmConsentStatus                    { get; set; }

        public static PrivacyOptionPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionPopupViewModel();

            value.IsAnalyticsToggleOn                       = GetBool(new IntPtr(p + 0x010)); // 027004E16050 0x10 IsAnalyticsToggleOn         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsAdvertisementToggleOn                   = GetBool(new IntPtr(p + 0x011)); // 027004E16070 0x11 IsAdvertisementToggleOn     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ConfirmConsentStatus                      = (ConfirmConsentStatus)GetInt32(new IntPtr(p + 0x014)); // 027004E16090 0x14 ConfirmConsentStatus        ( 0001865B0100 ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32 )

            return value;
        }
    }
}
