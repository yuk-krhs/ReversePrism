using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsAgreeingAnalyitics                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 IsAgreeingAdvertisement                  000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class PrivacyOptionAgreementSaveData
    {
        public bool                                     IsAgreeingAnalyitics                    { get; set; }
        public bool                                     IsAgreeingAdvertisement                 { get; set; }

        public static PrivacyOptionAgreementSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionAgreementSaveData();

            value.IsAgreeingAnalyitics                      = GetBool(new IntPtr(p + 0x020)); // 027003A7C608 0x20 IsAgreeingAnalyitics        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsAgreeingAdvertisement                   = GetBool(new IntPtr(p + 0x021)); // 027003A7C628 0x21 IsAgreeingAdvertisement     ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
