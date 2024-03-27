using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class EventScheduleTagView
    {
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public Image?                                   Background                              { get; set; }

        public static EventScheduleTagView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleTagView();

            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBEBF010 0x20 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DBEBF030 0x28 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
