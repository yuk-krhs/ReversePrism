using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgToken                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 TxtNm                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 02466542A480 0x20 ImgToken                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtNm                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466542A4A0 0x28 TxtNm                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
