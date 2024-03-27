using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBanner                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 TxtBefor                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtAfter                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaExchangeExpiryDateConversionItemCell
    {
        public Image?                                   ImgBanner                               { get; set; }
        public UITextMeshProUGUI?                       TxtBefor                                { get; set; }
        public UITextMeshProUGUI?                       TxtAfter                                { get; set; }

        public static GashaExchangeExpiryDateConversionItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateConversionItemCell();

            value.ImgBanner                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DB9F6DD8 0x20 ImgBanner                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtBefor                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F6DF8 0x28 TxtBefor                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfter                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F6E18 0x30 TxtAfter                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
