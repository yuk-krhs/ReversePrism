using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 030 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnreadBadge                              ModelClassType GameObject GameObject GameObject Pointer
    // 040 PeriodText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EventStoryFirstCategoryCell : DataModel
    {
        public UIButton?                                CellButton                              { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }

        public static EventStoryFirstCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCell() { Pointer= p0 };

            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 CellButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 UnreadBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 PeriodText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
