using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsAgreeingAnalyitics                     ModelPrimitiveType bool bool bool Bool
    // 021 IsAgreeingAdvertisement                  ModelPrimitiveType bool bool bool Bool
    public partial class PrivacyOptionAgreementSaveData : DataModel
    {
        public bool                                     IsAgreeingAnalyitics                    { get; set; }
        public bool                                     IsAgreeingAdvertisement                 { get; set; }

        public static PrivacyOptionAgreementSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionAgreementSaveData() { Pointer= p0 };

            value.IsAgreeingAnalyitics                      = GetBool(new IntPtr(p + 0x020)); // 0x20 IsAgreeingAnalyitics        ( ModelPrimitiveType bool bool bool Bool )
            value.IsAgreeingAdvertisement                   = GetBool(new IntPtr(p + 0x021)); // 0x21 IsAgreeingAdvertisement     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
