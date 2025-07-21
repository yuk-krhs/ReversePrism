using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Text                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 Background                               ModelClassType Image Image Image Pointer
    public partial class EventScheduleTagView : DataModel
    {
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public Image?                                   Background                              { get; set; }

        public static EventScheduleTagView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleTagView() { Pointer= p0 };

            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 Text                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Background                  ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
