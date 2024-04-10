using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Txt                                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Img                                      000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 GoNew                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoBadge                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoDisable                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665362160 0x38 Txt                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Img                                       = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 024665362180 0x40 Img                         ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0246653621A0 0x48 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246653621C0 0x50 GoBadge                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoDisable                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0246653621E0 0x58 GoDisable                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665362200 0x60 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665362220 0x68 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
