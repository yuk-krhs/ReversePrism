using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SelectFavoriteMarkPopupViewFactory       ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 038 SCharaFullImageOverlayViewFactory        ModelClassType SCharaFullImageOverlayViewFactory SCharaFullImageOverlayViewFactory SCharaFullImageOverlayViewFactory Pointer
    public partial class SCharaDetailPopupViewFactory : DataModel
    {
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public SCharaFullImageOverlayViewFactory?       SCharaFullImageOverlayViewFactory       { get; set; }

        public static SCharaDetailPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailPopupViewFactory() { Pointer= p0 };

            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0x30 SelectFavoriteMarkPopupViewFactory ( ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.SCharaFullImageOverlayViewFactory         = GetObject<SCharaFullImageOverlayViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaFullImageOverlayViewFactory.FromPointer); // 0x38 SCharaFullImageOverlayViewFactory ( ModelClassType SCharaFullImageOverlayViewFactory SCharaFullImageOverlayViewFactory SCharaFullImageOverlayViewFactory Pointer )

            return value;
        }
    }
}
