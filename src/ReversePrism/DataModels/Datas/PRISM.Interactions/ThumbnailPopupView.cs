using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ThumbnailButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 PopupParameter                           000186661E60 ModelClassType ThumbnailPopupParameter ThumbnailPopupParameter ThumbnailPopupParameter Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 040 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ThumbnailPopupView : DataModel
    {
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UIButton?                                ThumbnailButton                         { get; set; }
        public ThumbnailPopupParameter?                 PopupParameter                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ThumbnailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailPopupView() { Pointer= p0 };

            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466B60A5C0 0x20 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ThumbnailButton                           = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466B60A5E0 0x28 ThumbnailButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PopupParameter                            = GetObject<ThumbnailPopupParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ThumbnailPopupParameter.FromPointer); // 02466B60A600 0x30 PopupParameter              ( 000186661E60 ModelClassType ThumbnailPopupParameter ThumbnailPopupParameter ThumbnailPopupParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B60A620 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
