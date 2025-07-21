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
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 CurrentSpriteIndex                       ModelPrimitiveType int int int Int32
    public partial class MobileThumbnailOverlayView : DataModel
    {
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UIButton?                                ThumbnailButton                         { get; set; }
        public int                                      CurrentSpriteIndex                      { get; set; }

        public static MobileThumbnailOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileThumbnailOverlayView() { Pointer= p0 };

            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ThumbnailButton                           = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ThumbnailButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CurrentSpriteIndex                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 CurrentSpriteIndex          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
