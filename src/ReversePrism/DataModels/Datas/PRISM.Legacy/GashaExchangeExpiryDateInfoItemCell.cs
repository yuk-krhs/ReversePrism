using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBanner                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 TxtNm                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnGotoGasha                             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 TxtHavePoint                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtExpiryDate                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaExchangeExpiryDateInfoItemCell : DataModel
    {
        public Image?                                   ImgBanner                               { get; set; }
        public UITextMeshProUGUI?                       TxtNm                                   { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public ButtonBase?                              BtnGotoGasha                            { get; set; }
        public UITextMeshProUGUI?                       TxtHavePoint                            { get; set; }
        public UITextMeshProUGUI?                       TxtExpiryDate                           { get; set; }

        public static GashaExchangeExpiryDateInfoItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateInfoItemCell() { Pointer= p0 };

            value.ImgBanner                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 024665E6A028 0x20 ImgBanner                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtNm                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A048 0x28 TxtNm                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A068 0x30 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnGotoGasha                              = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665E6A088 0x38 BtnGotoGasha                ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtHavePoint                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A0A8 0x40 TxtHavePoint                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExpiryDate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E6A0C8 0x48 TxtExpiryDate               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
