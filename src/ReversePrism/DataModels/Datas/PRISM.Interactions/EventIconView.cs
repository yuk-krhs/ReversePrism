using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventIconImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 028 EventText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EventIconView : DataModel
    {
        public UIImage?                                 EventIconImage                          { get; set; }
        public UITextMeshProUGUI?                       EventText                               { get; set; }

        public static EventIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventIconView() { Pointer= p0 };

            value.EventIconImage                            = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 EventIconImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EventText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 EventText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
