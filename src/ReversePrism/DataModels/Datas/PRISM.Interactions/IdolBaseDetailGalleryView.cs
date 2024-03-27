using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 BtnAlbum                                 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer
    // 030 BtnCostume                               0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer
    // 038 BtnVoice                                 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer
    // 040 BtnMovie                                 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer
    // 048 BtnEtcetera                              0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer
    // 050 <OnTap>k__BackingField                   IObservable`1<GalleryContents> IL2CPP_TYPE_GENERICINST
    public partial class IdolBaseDetailGalleryView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GalleryButton?                           BtnAlbum                                { get; set; }
        public GalleryButton?                           BtnCostume                              { get; set; }
        public GalleryButton?                           BtnVoice                                { get; set; }
        public GalleryButton?                           BtnMovie                                { get; set; }
        public GalleryButton?                           BtnEtcetera                             { get; set; }

        public static IdolBaseDetailGalleryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailGalleryView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA26CD18 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnAlbum                                  = GetObject<GalleryButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryButton.FromPointer); // 0270DA26CD38 0x28 BtnAlbum                    ( 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer )
            value.BtnCostume                                = GetObject<GalleryButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.GalleryButton.FromPointer); // 0270DA26CD58 0x30 BtnCostume                  ( 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer )
            value.BtnVoice                                  = GetObject<GalleryButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.GalleryButton.FromPointer); // 0270DA26CD78 0x38 BtnVoice                    ( 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer )
            value.BtnMovie                                  = GetObject<GalleryButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.GalleryButton.FromPointer); // 0270DA26CD98 0x40 BtnMovie                    ( 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer )
            value.BtnEtcetera                               = GetObject<GalleryButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.GalleryButton.FromPointer); // 0270DA26CDB8 0x48 BtnEtcetera                 ( 0001865E1C70 ModelClassType GalleryButton GalleryButton GalleryButton Pointer )

            return value;
        }
    }
}
