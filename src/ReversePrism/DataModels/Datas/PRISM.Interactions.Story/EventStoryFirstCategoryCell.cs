using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnreadBadge                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PeriodText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EventStoryFirstCategoryCell
    {
        public UIButton?                                Button                                  { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }

        public static EventStoryFirstCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCell();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB9681F0 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB968210 0x28 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB968230 0x30 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB968250 0x38 UnreadBadge                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB968270 0x40 PeriodText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
