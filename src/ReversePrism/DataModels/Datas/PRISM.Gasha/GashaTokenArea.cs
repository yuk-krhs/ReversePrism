using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgToken                                 ModelClassType RawImage RawImage RawImage Pointer
    // 028 TxtNm                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaTokenArea : DataModel
    {
        public RawImage?                                ImgToken                                { get; set; }
        public UITextMeshProUGUI?                       TxtNm                                   { get; set; }

        public static GashaTokenArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTokenArea() { Pointer= p0 };

            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgToken                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtNm                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtNm                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
