using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgFullSize                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 RectImage                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 RectImageParent                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 BtnClose                                 ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ResourceId                               ModelPrimitiveType string string string String
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class FullSizeImageOverlayView : DataModel
    {
        public UIRawImage?                              ImgFullSize                             { get; set; }
        public RectTransform?                           RectImage                               { get; set; }
        public RectTransform?                           RectImageParent                         { get; set; }
        public UIButton?                                BtnClose                                { get; set; }
        public string                                   ResourceId                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static FullSizeImageOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FullSizeImageOverlayView() { Pointer= p0 };

            value.ImgFullSize                               = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 ImgFullSize                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RectImage                                 = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 RectImage                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectImageParent                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 RectImageParent             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BtnClose                                  = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnClose                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x048)); // 0x48 ResourceId                  ( ModelPrimitiveType string string string String )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
