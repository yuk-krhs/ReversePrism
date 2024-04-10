using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timeout                                  00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 consentTypeHeader                        string IL2CPP_TYPE_STRING
    // 000 subUrlTerm                               string IL2CPP_TYPE_STRING
    // 000 subUrlConsentInfos                       string IL2CPP_TYPE_STRING
    // 000 subUrlConsentInfosUserId                 string IL2CPP_TYPE_STRING
    // 018 BaseUrl                                  000186672F10 ModelPrimitiveType string string string String
    // 020 Token                                    000186672F10 ModelPrimitiveType string string string String
    public partial class PrivacyOptionCommunicator : DataModel
    {
        public TimeSpan                                 Timeout                                 { get; set; }
        public string                                   BaseUrl                                 { get; set; }
        public string                                   Token                                   { get; set; }

        public static PrivacyOptionCommunicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionCommunicator() { Pointer= p0 };

            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0245A4E42908 0x10 Timeout                     ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.BaseUrl                                   = GetString(new IntPtr(p + 0x018)); // 0245A4E429A8 0x18 BaseUrl                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Token                                     = GetString(new IntPtr(p + 0x020)); // 0245A4E429C8 0x20 Token                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
