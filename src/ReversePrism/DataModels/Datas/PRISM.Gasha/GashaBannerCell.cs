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
    public partial class GashaBannerCell
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
            var value   = new GashaBannerCell();

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52EE9B8 0x38 Txt                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Img                                       = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0270D52EE9D8 0x40 Img                         ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52EE9F8 0x48 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52EEA18 0x50 GoBadge                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoDisable                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52EEA38 0x58 GoDisable                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52EEA58 0x60 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D52EEA78 0x68 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
