using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TroubleColorImage                        0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 TroubleText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ScheduleTroubleContent : DataModel
    {
        public UIRawImage?                              TroubleColorImage                       { get; set; }
        public UITextMeshProUGUI?                       TroubleText                             { get; set; }

        public static ScheduleTroubleContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleTroubleContent() { Pointer= p0 };

            value.TroubleColorImage                         = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1E01C8 0x20 TroubleColorImage           ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TroubleText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1E01E8 0x28 TroubleText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
