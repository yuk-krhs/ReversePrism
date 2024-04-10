using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgFullSize                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 RectImage                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 RectImageParent                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 BtnClose                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 050 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
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

            value.ImgFullSize                               = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A2E3C50 0x20 ImgFullSize                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RectImage                                 = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2E3C70 0x28 RectImage                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectImageParent                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2E3C90 0x30 RectImageParent             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BtnClose                                  = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2E3CB0 0x38 BtnClose                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x048)); // 02466A2E3CF0 0x48 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466A2E3D10 0x50 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
