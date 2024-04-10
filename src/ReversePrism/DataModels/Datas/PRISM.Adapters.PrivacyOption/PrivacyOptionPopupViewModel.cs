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

            value.IsAnalyticsToggleOn                       = GetBool(new IntPtr(p + 0x010)); // 0245A4E42420 0x10 IsAnalyticsToggleOn         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsAdvertisementToggleOn                   = GetBool(new IntPtr(p + 0x011)); // 0245A4E42440 0x11 IsAdvertisementToggleOn     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ConfirmConsentStatus                      = (ConfirmConsentStatus)GetInt32(new IntPtr(p + 0x014)); // 0245A4E42460 0x14 ConfirmConsentStatus        ( 0001865B0100 ModelEnumType ConfirmConsentStatus ConfirmConsentStatus ConfirmConsentStatus Int32 )

            return value;
        }
    }
}
