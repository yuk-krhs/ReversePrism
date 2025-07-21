using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Txt                                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Img                                      ModelClassType RawImage RawImage RawImage Pointer
    // 048 GoNew                                    ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoBadge                                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoDisable                                ModelClassType GameObject GameObject GameObject Pointer
    // 060 TxtLimit                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class GashaBannerCell : DataModel
    {
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public RawImage?                                Img                                     { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public GameObject?                              GoBadge                                 { get; set; }
        public GameObject?                              GoDisable                               { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static GashaBannerCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBannerCell() { Pointer= p0 };

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 Txt                         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Img                                       = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 Img                         ( ModelClassType RawImage RawImage RawImage Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoNew                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoBadge                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoDisable                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoDisable                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtLimit                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
