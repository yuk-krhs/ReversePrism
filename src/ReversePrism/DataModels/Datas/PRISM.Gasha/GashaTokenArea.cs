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
    public partial class GashaTokenArea
    {
        public RawImage?                                ImgToken                                { get; set; }
        public UITextMeshProUGUI?                       TxtNm                                   { get; set; }

        public static GashaTokenArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTokenArea();

            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D53B6BF0 0x20 ImgToken                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtNm                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53B6C10 0x28 TxtNm                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
