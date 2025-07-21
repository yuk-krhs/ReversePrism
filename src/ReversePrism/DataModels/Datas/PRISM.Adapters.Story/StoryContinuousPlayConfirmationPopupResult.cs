using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsVoicePlayActive                        ModelPrimitiveType bool bool bool Bool
    // 011 IsPopupCanceled                          ModelPrimitiveType bool bool bool Bool
    public partial class StoryContinuousPlayConfirmationPopupResult : DataModel
    {
        public bool                                     IsVoicePlayActive                       { get; set; }
        public bool                                     IsPopupCanceled                         { get; set; }

        public static StoryContinuousPlayConfirmationPopupResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryContinuousPlayConfirmationPopupResult() { Pointer= p0 };

            value.IsVoicePlayActive                         = GetBool(new IntPtr(p + 0x010)); // 0x10 IsVoicePlayActive           ( ModelPrimitiveType bool bool bool Bool )
            value.IsPopupCanceled                           = GetBool(new IntPtr(p + 0x011)); // 0x11 IsPopupCanceled             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
