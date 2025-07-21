using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtNumberOfTime                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 GoPaidJewel                              ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoFreeJewel                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 ImgToken                                 ModelClassType RawImage RawImage RawImage Pointer
    // 040 TxtPrice                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoSelector                               ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoStamp                                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 ImgCatchphrase                           ModelClassType RawImage RawImage RawImage Pointer
    public partial class GashaStepView : DataModel
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
            var value   = new GashaStepView() { Pointer= p0 };

            value.TxtNumberOfTime                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtNumberOfTime             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaidJewel                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoPaidJewel                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFreeJewel                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoFreeJewel                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImgToken                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtPrice                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtPrice                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoSelector                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoSelector                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoStamp                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoStamp                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgCatchphrase                            = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0x58 ImgCatchphrase              ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
