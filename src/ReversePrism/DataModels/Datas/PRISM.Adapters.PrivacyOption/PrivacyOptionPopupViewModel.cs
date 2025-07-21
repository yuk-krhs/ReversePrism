using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAnalyticsToggleOn                      ModelPrimitiveType bool bool bool Bool
    // 011 IsAdvertisementToggleOn                  ModelPrimitiveType bool bool bool Bool
    // 014 ConfirmConsentStatus                     ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32
    public partial class PrivacyOptionPopupViewModel : DataModel
    {
        public bool                                     IsAnalyticsToggleOn                     { get; set; }
        public bool                                     IsAdvertisementToggleOn                 { get; set; }
        public ConfirmConsentStatus                     ConfirmConsentStatus                    { get; set; }

        public static PrivacyOptionPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionPopupViewModel() { Pointer= p0 };

            value.IsAnalyticsToggleOn                       = GetBool(new IntPtr(p + 0x010)); // 0x10 IsAnalyticsToggleOn         ( ModelPrimitiveType bool bool bool Bool )
            value.IsAdvertisementToggleOn                   = GetBool(new IntPtr(p + 0x011)); // 0x11 IsAdvertisementToggleOn     ( ModelPrimitiveType bool bool bool Bool )
            value.ConfirmConsentStatus                      = (ConfirmConsentStatus)GetInt32(new IntPtr(p + 0x014)); // 0x14 ConfirmConsentStatus        ( ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32 )

            return value;
        }
    }
}
