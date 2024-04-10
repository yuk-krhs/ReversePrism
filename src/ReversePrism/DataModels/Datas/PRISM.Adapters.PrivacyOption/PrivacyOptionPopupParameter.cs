using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsOnTitleSequence                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 <OnSendConsent>k__BackingField           Action`1<ConsentRequest> IL2CPP_TYPE_GENERICINST
    public partial class PrivacyOptionPopupParameter : DataModel
    {
        public bool                                     IsOnTitleSequence                       { get; set; }

        public static PrivacyOptionPopupParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionPopupParameter() { Pointer= p0 };

            value.IsOnTitleSequence                         = GetBool(new IntPtr(p + 0x010)); // 024666966880 0x10 IsOnTitleSequence           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
