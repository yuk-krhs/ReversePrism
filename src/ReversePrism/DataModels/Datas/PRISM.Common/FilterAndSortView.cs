using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FilterBtn                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 FilterBg                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 TxtFilterBtn                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SortBtn                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TxtSortBtn                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClickSubject                           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class FilterAndSortView : DataModel
    {
        public UIButton?                                FilterBtn                               { get; set; }
        public Image?                                   FilterBg                                { get; set; }
        public UITextMeshProUGUI?                       TxtFilterBtn                            { get; set; }
        public UIButton?                                SortBtn                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSortBtn                              { get; set; }

        public static FilterAndSortView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilterAndSortView() { Pointer= p0 };

            value.FilterBtn                                 = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466534A998 0x20 FilterBtn                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FilterBg                                  = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 02466534A9B8 0x28 FilterBg                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtFilterBtn                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466534A9D8 0x30 TxtFilterBtn                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortBtn                                   = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466534A9F8 0x38 SortBtn                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtSortBtn                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466534AA18 0x40 TxtSortBtn                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
