using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 028 ThumbnailButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 038 AssetKey                                 ModelPrimitiveType string string string String
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 048 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ThumbnailPopupView : DataModel
    {
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UIButton?                                ThumbnailButton                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public string                                   AssetKey                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ThumbnailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailPopupView() { Pointer= p0 };

            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ThumbnailButton                           = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ThumbnailButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.AssetKey                                  = GetString(new IntPtr(p + 0x038)); // 0x38 AssetKey                    ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
