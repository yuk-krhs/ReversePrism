using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtNumberOfTime                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 GoPaidJewel                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoFreeJewel                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImgToken                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 TxtPrice                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoSelector                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoStamp                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ImgCatchphrase                           000186613190 ModelClassType RawImage RawImage RawImage Pointer
    public partial class GashaStepView
    {
        public UITextMeshProUGUI?                       TxtNumberOfTime                         { get; set; }
        public GameObject?                              GoPaidJewel                             { get; set; }
        public GameObject?                              GoFreeJewel                             { get; set; }
        public RawImage?                                ImgToken                                { get; set; }
        public UITextMeshProUGUI?                       TxtPrice                                { get; set; }
        public GameObject?                              GoSelector                              { get; set; }
        public GameObject?                              GoStamp                                 { get; set; }
        public RawImage?                                ImgCatchphrase                          { get; set; }

        public static GashaStepView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaStepView();

            value.TxtNumberOfTime                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53D5B30 0x20 TxtNumberOfTime             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaidJewel                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53D5B50 0x28 GoPaidJewel                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFreeJewel                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53D5B70 0x30 GoFreeJewel                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0270D53D5B90 0x38 ImgToken                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtPrice                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53D5BB0 0x40 TxtPrice                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSelector                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53D5BD0 0x48 GoSelector                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoStamp                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53D5BF0 0x50 GoStamp                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgCatchphrase                            = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0270D53D5C10 0x58 ImgCatchphrase              ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
